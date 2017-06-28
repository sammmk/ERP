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
    public partial class FrmAddUnits : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsUnitData ADD_UNIT;
        private BLL.ClsMetaDataDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING;

        public FrmAddUnits()
        {
            InitializeComponent();
        }

        public FrmAddUnits(string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_UNIT = new BLL.ClsUnitData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.ActiveControl = txt_description;
                IS_UPDATING = false;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        public FrmAddUnits(BLL.ClsUnitData unit, string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_UNIT = new BLL.ClsUnitData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                IS_UPDATING = true;
                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

                fillData(unit);

                this.StartPosition = FormStartPosition.CenterScreen;
                this.ActiveControl = txt_description;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void fillData(BLL.ClsUnitData unitData)
        {
            try
            {
                txt_unitId.Text = unitData._unitId.ToString();
                txt_description.Text = unitData._description;
                txt_symbol.Text = unitData._symbol;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAddUnits_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    //get max item Id
                    txt_unitId.Text = MANAGEDB.getMaxUnitId().ToString();
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
                DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE a Unit....\n\r Are you Sure???", "Delete A Measure Unit");

                if (result == DialogResult.Yes)
                {
                    if (MANAGEDB.deleteUnit(Convert.ToInt32(txt_unitId.Text)))
                    {
                        IS_SUCCESS_MESSAGE = true;
                        this.Close();
                        COM_MESSAGE.successfullMessage("Successfully deleted the Asset");
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

        private void FrmAddUnits_FormClosing(object sender, FormClosingEventArgs e)
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
                    string unitId = txt_unitId.Text;
                    string description = txt_description.Text;
                    string symbol = txt_symbol.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("description", description));
                    dataList.Add(new Tuple<string, string>("symbol", symbol));

                    isError = checkInsertedAssetData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_UNIT._unitId = Convert.ToInt32(unitId);
                        ADD_UNIT._description = description;
                        ADD_UNIT._symbol = symbol;

                        if (MANAGEDB.insertData_unit(ADD_UNIT))
                        {
                            COM_MESSAGE.successfullMessage("Successfully Insert the Unit ");
                            COMM_METHODS.clearAllText(this);
                            txt_unitId.Text = MANAGEDB.getMaxUnitId().ToString();
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
                    string unitId = txt_unitId.Text;
                    string description = txt_description.Text;
                    string symbol = txt_symbol.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("description", description));
                    dataList.Add(new Tuple<string, string>("symbol", symbol));

                    isError = checkInsertedAssetData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_UNIT._unitId = Convert.ToInt32(unitId);
                        ADD_UNIT._description = description;
                        ADD_UNIT._symbol = symbol;

                        if (MANAGEDB.updateData_unit(ADD_UNIT))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the Unit ");
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

        private bool checkInsertedAssetData(List<Tuple<string, string>> dataList)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    switch (dataList[i].Item1)
                    {
                        case "description":
                            if (VALIDATION.isEmptyTextBox(dataList[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Description Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(dataList[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Description should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "symbol":
                            if (VALIDATION.isEmptyTextBox(dataList[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Symbol Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(dataList[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Symbol should contains only Numbers and letters !!!");
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
