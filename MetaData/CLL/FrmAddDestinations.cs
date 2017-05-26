using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaData.CLL
{
    public partial class FrmAddDestinations : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsDestinationData ADD_DESTINATION;
        private BLL.ClsMetaDataDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAddDestinations()
        {
            InitializeComponent();
        }

        public FrmAddDestinations(string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_DESTINATION = new BLL.ClsDestinationData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.ActiveControl = txt_destinationName;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        public FrmAddDestinations(BLL.ClsDestinationData destination, string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_DESTINATION = new BLL.ClsDestinationData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                IS_UPDATING = true;
                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

                fillData(destination);

                this.StartPosition = FormStartPosition.CenterScreen;
                this.ActiveControl = txt_destinationName;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void fillData(BLL.ClsDestinationData destinationData)
        {
            try
            {
                txt_destinationId.Text = destinationData._destId.ToString();
                txt_destinationName.Text = destinationData._destName;
                txt_ownerName.Text = destinationData._ownerName;
                txt_address.Text = destinationData._address;
                txt_phoneNo.Text = destinationData._phoneNo;
                txt_mobile.Text = destinationData._mobile;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAddDestinations_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    //get max item Id
                    txt_destinationId.Text = MANAGEDB.getMaxDestinationId().ToString();
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the Destination....\n\r Are you Sure???", "Delete the Destination");

                if (result == DialogResult.Yes)
                {
                    if (MANAGEDB.deleteDestination(Convert.ToInt32(txt_destinationId.Text)))
                    {
                        IS_SUCCESS_MESSAGE = true;
                        this.Close();
                        COM_MESSAGE.successfullMessage("Successfully deleted the User");
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddDestinations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = DialogResult.Yes;

                if (!IS_SUCCESS_MESSAGE)
                    result = COM_MESSAGE.informationMessage("Do you realy want to CANCEL!!! you will lost all unsaved data", "Confirmation");

                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    string destId = txt_destinationId.Text;
                    string destName = txt_destinationName.Text;
                    string ownerName = txt_ownerName.Text;
                    string address = txt_address.Text;
                    string phoneNo = txt_phoneNo.Text;
                    string mobile = txt_mobile.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("destName", destName));
                    dataList.Add(new Tuple<string, string>("ownerName", ownerName));
                    dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));
                    dataList.Add(new Tuple<string, string>("mobile", mobile));

                    isError = checkInsertedDestinationData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_DESTINATION._destId = Convert.ToInt32(destId);
                        ADD_DESTINATION._destName = destName;
                        ADD_DESTINATION._ownerName = ownerName;
                        ADD_DESTINATION._address = address;
                        ADD_DESTINATION._phoneNo = phoneNo;
                        ADD_DESTINATION._mobile = mobile;

                        if (MANAGEDB.insertData_destination(ADD_DESTINATION))
                        {
                            COM_MESSAGE.successfullMessage("Successfully created the Item ");
                            COMM_METHODS.clearAllText(this);
                            txt_destinationId.Text = MANAGEDB.getMaxDestinationId().ToString();
                        }
                    }
                }
                else
                {
                    COM_MESSAGE.permissionMessage("Sorry You dont have permission to do action !!!");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    string destId = txt_destinationId.Text;
                    string destName = txt_destinationName.Text;
                    string ownerName = txt_ownerName.Text;
                    string address = txt_address.Text;
                    string phoneNo = txt_phoneNo.Text;
                    string mobile = txt_mobile.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("destName", destName));
                    dataList.Add(new Tuple<string, string>("ownerName", ownerName));
                    dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));
                    dataList.Add(new Tuple<string, string>("mobile", mobile));

                    isError = checkInsertedDestinationData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_DESTINATION._destId = Convert.ToInt32(destId);
                        ADD_DESTINATION._destName = destName;
                        ADD_DESTINATION._ownerName = ownerName;
                        ADD_DESTINATION._address = address;
                        ADD_DESTINATION._phoneNo = phoneNo;
                        ADD_DESTINATION._mobile = mobile;

                        if (MANAGEDB.updateData_destination(ADD_DESTINATION))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the Destination ");
                        }
                    }
                }
                else
                {
                    COM_MESSAGE.permissionMessage("Sorry You dont have permission to do action !!!");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private bool checkInsertedDestinationData(List<Tuple<string, string>> destinationData)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < destinationData.Count; i++)
                {
                    switch (destinationData[i].Item1)
                    {
                        case "destName":
                            if (VALIDATION.isEmptyTextBox(destinationData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Destination Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(destinationData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Destination Name should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "ownerName":
                            if (VALIDATION.isEmptyTextBox(destinationData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Owner Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(destinationData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Owner Name should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "phoneNo":
                            if (!VALIDATION.isEmptyTextBox(destinationData[i].Item2))
                            {
                                if (!VALIDATION.isNumberOnly(destinationData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Phone Number should contains only numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "mobile":
                            if (!VALIDATION.isEmptyTextBox(destinationData[i].Item2))
                            {
                                if (!VALIDATION.isNumberOnly(destinationData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Mobile Phone Number should contains only numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isError;
        }
    }
}
