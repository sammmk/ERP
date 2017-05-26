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
    public partial class FrmAddDealers : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsDealerData ADD_DEALER;
        private BLL.ClsMetaDataDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAddDealers()
        {
            InitializeComponent();
        }

        public FrmAddDealers(string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_DEALER = new BLL.ClsDealerData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.ActiveControl = txt_dealerName;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        public FrmAddDealers(BLL.ClsDealerData dealerDetails, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            ADD_DEALER = new BLL.ClsDealerData();
            MANAGEDB = new BLL.ClsMetaDataDbChanges();

            InitializeComponent();

            IS_UPDATING = true;
            USERNAME = userName;
            btn_cancel.Visible = true;
            btn_create.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;

            fillData(dealerDetails);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_dealerName;
        }

        private void fillData(BLL.ClsDealerData dealerData)
        {
            try
            {
                txt_dealerID.Text = dealerData._dealerId.ToString();
                txt_dealerName.Text = dealerData._dealerName;
                txt_companyName.Text = dealerData._companyName;
                txt_address.Text = dealerData._address;
                txt_phoneNo.Text = dealerData._phoneNo;
                txt_mobile.Text = dealerData._mobile;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAddDealers_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    //get max item Id
                    txt_dealerID.Text = MANAGEDB.getMaxDealerId().ToString();
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the dealer....\n\r Are you Sure???", "Delete the Dealer");

                if (result == DialogResult.Yes)
                {
                    if (MANAGEDB.deleteDealer(Convert.ToInt32(txt_dealerID.Text)))
                    {
                        IS_SUCCESS_MESSAGE = true;
                        this.Close();
                        COM_MESSAGE.successfullMessage("Successfully deleted the User");
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddDealers_FormClosing(object sender, FormClosingEventArgs e)
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
                    string dealerId = txt_dealerID.Text;
                    string dealerName = txt_dealerName.Text;
                    string companyName = txt_companyName.Text;
                    string address = txt_address.Text;
                    string phoneNo = txt_phoneNo.Text;
                    string mobile = txt_mobile.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("dealerName", dealerName));
                    dataList.Add(new Tuple<string, string>("companyName", companyName));
                    dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));
                    dataList.Add(new Tuple<string, string>("mobile", mobile));

                    isError = checkInsertedDealerData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_DEALER._dealerId = Convert.ToInt32(dealerId);
                        ADD_DEALER._dealerName = dealerName;
                        ADD_DEALER._companyName = companyName;
                        ADD_DEALER._address = address;
                        ADD_DEALER._phoneNo = phoneNo;
                        ADD_DEALER._mobile = mobile;

                        if (MANAGEDB.insertData_dealer(ADD_DEALER))
                        {
                            COM_MESSAGE.successfullMessage("Successfully created the Item ");
                            COMM_METHODS.clearAllText(this);
                            txt_dealerID.Text = MANAGEDB.getMaxDealerId().ToString();
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
                    string dealerId = txt_dealerID.Text;
                    string dealerName = txt_dealerName.Text;
                    string companyName = txt_companyName.Text;
                    string address = txt_address.Text;
                    string phoneNo = txt_phoneNo.Text;
                    string mobile = txt_mobile.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("dealerName", dealerName));
                    dataList.Add(new Tuple<string, string>("companyName", companyName));
                    dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));
                    dataList.Add(new Tuple<string, string>("mobile", mobile));

                    isError = checkInsertedDealerData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_DEALER._dealerId = Convert.ToInt32(dealerId);
                        ADD_DEALER._dealerName = dealerName;
                        ADD_DEALER._companyName = companyName;
                        ADD_DEALER._address = address;
                        ADD_DEALER._phoneNo = phoneNo;
                        ADD_DEALER._mobile = mobile;

                        if (MANAGEDB.updateData_dealer(ADD_DEALER))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the Dealer ");
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

        private bool checkInsertedDealerData(List<Tuple<string, string>> dealerData)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < dealerData.Count; i++)
                {
                    switch (dealerData[i].Item1)
                    {
                        case "dealerName":
                            if (VALIDATION.isEmptyTextBox(dealerData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Dealer Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(dealerData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Dealer Name should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "companyName":
                            if (VALIDATION.isEmptyTextBox(dealerData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Company Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(dealerData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Company Name should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "phoneNo":
                            if (!VALIDATION.isEmptyTextBox(dealerData[i].Item2))
                            {
                                if (!VALIDATION.isNumberOnly(dealerData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Phone Number should contains only numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "mobile":
                            if (!VALIDATION.isEmptyTextBox(dealerData[i].Item2))
                            {
                                if (!VALIDATION.isNumberOnly(dealerData[i].Item2))
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
