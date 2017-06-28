using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaData.BLL;

namespace MetaData.CLL
{
    public partial class FrmAddTax : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsTaxData ADD_TAX;
        private BLL.ClsMetaDataDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAddTax()
        {
            InitializeComponent();
        }

        public FrmAddTax(string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_TAX = new BLL.ClsTaxData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                USERNAME = userName;
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
                grp_duration.Enabled = false;
                IS_UPDATING = false;
                IS_SUCCESS_MESSAGE = false;

                this.WindowState = FormWindowState.Maximized;
                this.ActiveControl = txt_symbol;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        public FrmAddTax(BLL.ClsTaxData tax, string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_TAX = new BLL.ClsTaxData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                IS_UPDATING = true;
                USERNAME = userName;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

                fillData(tax);

                this.StartPosition = FormStartPosition.CenterScreen;
                this.ActiveControl = txt_symbol;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void fillData(BLL.ClsTaxData taxData)
        {
            try
            {
                txt_taxId.Text = taxData._taxId.ToString();
                txt_symbol.Text = taxData._symbol;
                txt_description.Text = taxData._description;
                txt_taxPercentage.Text = taxData._taxPercentage.ToString();
                if (!taxData._effectFrom.Equals(DateTime.MinValue))
                {
                    chk_timePeriod.Checked = true;
                    grp_duration.Enabled = true;
                    dateTime_from.Value = taxData._effectFrom;
                    dateTime_to.Value = taxData._effectTo;
                }
                else
                {
                    chk_timePeriod.Checked = false;
                    grp_duration.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAddTax_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    //get max item Id
                    txt_taxId.Text = MANAGEDB.getMaxTaxId().ToString();
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
                DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the Tax Entry....\n\r Are you Sure???", "Delete the Tax Entry");

                if (result == DialogResult.Yes)
                {
                    if (MANAGEDB.deleteTax(Convert.ToInt32(txt_taxId.Text)))
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

        private void FrmAddTax_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    string taxId = txt_taxId.Text;
                    string symbol = txt_symbol.Text;
                    string description = txt_description.Text;
                    string taxPercentage = txt_taxPercentage.Text;
                    DateTime from = DateTime.MinValue.Date;
                    DateTime to = DateTime.MinValue.Date; 
                    
                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("symbol", symbol));
                    dataList.Add(new Tuple<string, string>("description", description));
                    dataList.Add(new Tuple<string, string>("taxPercentage", taxPercentage));

                    isError = checkInsertedTaxData(dataList);

                    if (chk_timePeriod.Checked)
                    {
                        from = dateTime_from.Value.Date;
                        to = dateTime_to.Value.Date;

                        if(from > to)
                        {
                            isError = true;
                            COM_MESSAGE.validationMessage("From Date cannot be greater than To Date !!!");
                        }
                    }

                    if (!isError)
                    {
                        //insert data to db
                        ADD_TAX._taxId = Convert.ToInt32(taxId);
                        ADD_TAX._symbol = symbol;
                        ADD_TAX._description = description;
                        ADD_TAX._taxPercentage = Convert.ToDouble(taxPercentage);
                        ADD_TAX._effectFrom = from;
                        ADD_TAX._effectTo = to;
                        

                        if (MANAGEDB.insertData_tax(ADD_TAX))
                        {
                            COM_MESSAGE.successfullMessage("Successfully Insert the Tax ");
                            COMM_METHODS.clearAllText(this);
                            txt_taxId.Text = MANAGEDB.getMaxTaxId().ToString();

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
                    string taxId = txt_taxId.Text;
                    string symbol = txt_symbol.Text;
                    string description = txt_description.Text;
                    string taxPercentage = txt_taxPercentage.Text;
                    DateTime from = DateTime.MinValue.Date;
                    DateTime to = DateTime.MinValue.Date;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("symbol", symbol));
                    dataList.Add(new Tuple<string, string>("description", description));
                    dataList.Add(new Tuple<string, string>("taxPercentage", taxPercentage));

                    isError = checkInsertedTaxData(dataList);

                    if (chk_timePeriod.Checked)
                    {
                        from = dateTime_from.Value.Date;
                        to = dateTime_to.Value.Date;

                        if (from > to)
                        {
                            isError = true;
                            COM_MESSAGE.validationMessage("From Date cannot be greater than To Date !!!");
                        }
                    }

                    if (!isError)
                    {
                        //insert data to db
                        ADD_TAX._taxId = Convert.ToInt32(taxId);
                        ADD_TAX._symbol = symbol;
                        ADD_TAX._description = description;
                        ADD_TAX._taxPercentage = Convert.ToDouble(taxPercentage);
                        ADD_TAX._effectFrom = from;
                        ADD_TAX._effectTo = to;

                        if (MANAGEDB.updateData_tax(ADD_TAX))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the Tax ");
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

        private bool checkInsertedTaxData(List<Tuple<string, string>> taxData)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < taxData.Count; i++)
                {
                    switch (taxData[i].Item1)
                    {                        
                        case "description":
                            if (!VALIDATION.isEmptyTextBox(taxData[i].Item2))
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(taxData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Description should contains only Letters numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "symbol":
                            if (VALIDATION.isEmptyTextBox(taxData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Symbol Cannot be Empty !!!");
                                isError = true;
                            }
                            if (!VALIDATION.isLetterAndNumberOnly(taxData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Symbol should contains only Letters numbers !!!");
                                isError = true;
                            }
                            break;
                        case "taxPercentage":
                            if (VALIDATION.isEmptyTextBox(taxData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Percentage Cannot be Empty !!!");
                                isError = true;
                            }
                            if (!VALIDATION.isDoubleValue(taxData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Percentage should contains only double values !!!");
                                isError = true;
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

        private void txt_taxPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void dateTime_from_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dateTime_to.MinDate = dateTime_from.Value;
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void chk_timePeriod_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_timePeriod.Checked)
                {
                    grp_duration.Enabled = true;
                }
                else
                {
                    grp_duration.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
