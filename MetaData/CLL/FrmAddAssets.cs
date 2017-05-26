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
    public partial class FrmAddAssets : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsAssetData ADD_ASSET;
        private BLL.ClsMetaDataDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAddAssets()
        {
            InitializeComponent();
        }

        public FrmAddAssets(string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_ASSET = new BLL.ClsAssetData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.ActiveControl = txt_assetName;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        public FrmAddAssets(BLL.ClsAssetData asset, string userName)
        {
            try
            {
                COM_MESSAGE = new CommonControls.Classes.ClsMessages();
                VALIDATION = new CommonControls.Classes.ClsValidation();
                COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
                ADD_ASSET = new BLL.ClsAssetData();
                MANAGEDB = new BLL.ClsMetaDataDbChanges();

                InitializeComponent();

                IS_UPDATING = true;
                USERNAME = userName;
                btn_cancel.Visible = true;
                btn_create.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

                fillData(asset);

                this.StartPosition = FormStartPosition.CenterScreen;
                this.ActiveControl = txt_assetName;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void fillData(BLL.ClsAssetData assetData)
        {
            try
            {
                txt_assetId.Text = assetData._assetId.ToString();
                txt_assetName.Text = assetData._assetName;
                txt_description.Text = assetData._descrption;
                txt_value.Text = assetData._value.ToString();
                txt_quantity.Text = assetData._quantity.ToString();
                txt_total.Text = assetData._totalValue.ToString();
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAddAssets_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    //get max item Id
                    txt_assetId.Text = MANAGEDB.getMaxAssetId().ToString();
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
                DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the Asset....\n\r Are you Sure???", "Delete the Destination");

                if (result == DialogResult.Yes)
                {
                    if (MANAGEDB.deleteAsset(Convert.ToInt32(txt_assetId.Text)))
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

        private void FrmAddAssets_FormClosing(object sender, FormClosingEventArgs e)
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
                    string assetId = txt_assetId.Text;
                    string assetName = txt_assetName.Text;
                    string value = txt_value.Text;
                    string description = txt_description.Text;
                    string quantity = txt_quantity.Text;
                    string totalValue = txt_total.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("assetName", assetName));
                    dataList.Add(new Tuple<string, string>("value", value));
                    dataList.Add(new Tuple<string, string>("quantity", quantity));

                    isError = checkInsertedAssetData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_ASSET._assetId = Convert.ToInt32(assetId);
                        ADD_ASSET._assetName = assetName;
                        ADD_ASSET._value = (!string.IsNullOrEmpty(value)) ? Convert.ToDouble(value) : 0;
                        ADD_ASSET._descrption = description;
                        ADD_ASSET._quantity = (!string.IsNullOrEmpty(quantity)) ? Convert.ToDouble(quantity) : 0; 
                        ADD_ASSET._totalValue = (!string.IsNullOrEmpty(totalValue)) ? Convert.ToDouble(totalValue) : 0;

                        if (MANAGEDB.insertData_asset(ADD_ASSET))
                        {
                            COM_MESSAGE.successfullMessage("Successfully Insert the Asset ");
                            COMM_METHODS.clearAllText(this);
                            txt_assetId.Text = MANAGEDB.getMaxAssetId().ToString();
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
                    string assetId = txt_assetId.Text;
                    string assetName = txt_assetName.Text;
                    string value = txt_value.Text;
                    string description = txt_description.Text;
                    string quantity = txt_quantity.Text;
                    string totalValue = txt_total.Text;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("assetName", assetName));
                    dataList.Add(new Tuple<string, string>("value", value));
                    dataList.Add(new Tuple<string, string>("quantity", quantity));

                    isError = checkInsertedAssetData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        ADD_ASSET._assetId = Convert.ToInt32(assetId);
                        ADD_ASSET._assetName = assetName;
                        ADD_ASSET._value = (!string.IsNullOrEmpty(value)) ? Convert.ToDouble(value) : 0;
                        ADD_ASSET._descrption = description;
                        ADD_ASSET._quantity = (!string.IsNullOrEmpty(quantity)) ? Convert.ToDouble(quantity) : 0;
                        ADD_ASSET._totalValue = (!string.IsNullOrEmpty(totalValue)) ? Convert.ToDouble(totalValue) : 0;

                        if (MANAGEDB.updateData_asset(ADD_ASSET))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the Asset ");
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

        private bool checkInsertedAssetData(List<Tuple<string, string>> assetData)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < assetData.Count; i++)
                {
                    switch (assetData[i].Item1)
                    {
                        case "assetName":
                            if (VALIDATION.isEmptyTextBox(assetData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Asset Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(assetData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Asset Name should contains only Numbers and letters !!!");
                                    isError = true;
                                }
                            }
                            break;                        
                        case "value":
                            if (!VALIDATION.isEmptyTextBox(assetData[i].Item2))
                            {
                                if (!VALIDATION.isDoubleValue(assetData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Value should contains only numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "quantity":
                            if (!VALIDATION.isEmptyTextBox(assetData[i].Item2))
                            {
                                if (!VALIDATION.isDoubleValue(assetData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("quantity should contains only numbers !!!");
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

        private void txt_value_Leave(object sender, EventArgs e)
        {
            setTotalValue();
        }

        private void txt_quantity_Leave(object sender, EventArgs e)
        {
            setTotalValue();
        }

        private void setTotalValue()
        {
            try
            {
                string value = txt_value.Text;
                string quantity = txt_quantity.Text;

                if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(quantity))
                {
                    if (VALIDATION.isDoubleValue(value) && VALIDATION.isDoubleValue(quantity))
                    {
                        double totalVal = Convert.ToDouble(quantity) * Convert.ToDouble(value);
                        txt_total.Text = totalVal.ToString();
                    }
                }
                else
                {
                    txt_total.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

    }
}
