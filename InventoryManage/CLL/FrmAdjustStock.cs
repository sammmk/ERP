using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManage.CLL
{
    public partial class FrmAdjustStock : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsStockData STOCKDATA;
        private BLL.ClsInventoryManageDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAdjustStock()
        {
            InitializeComponent();
        }

        public FrmAdjustStock(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsStockData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.ActiveControl = txt_itemCode;
        }

        public FrmAdjustStock(BLL.ClsStockData stockData, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsStockData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            IS_UPDATING = true;
            USERNAME = userName;
            STOCKDATA = stockData;

            fillData();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_itemCode;

        }

        private void fillData()
        {
            try
            {
                txt_entryId.Text = STOCKDATA._stockEntryId.ToString();
                txt_itemCode.Text = STOCKDATA._itemCode;
                txt_itemId.Text = STOCKDATA._itemId.ToString();
                txt_itemName.Text = STOCKDATA._itemName;
                txt_quantity.Text = STOCKDATA._quantity.ToString();
                txt_buyUnitPrice.Text = STOCKDATA._buyUnitPrice.ToString();
                txt_sellUnitPrice.Text = STOCKDATA._sellUnitPrice.ToString();
                txt_stockEntryDate.Text = STOCKDATA._stockEntryDate.ToString("yyyy/MM/dd");
                txt_expireDate.Text = STOCKDATA._expireDate.ToString("yyyy/MM/dd");
                txt_totalValue.Text = STOCKDATA._totalValue.ToString();
                txt_priceAfterDiscount.Text = STOCKDATA._priceAfterDiscount.ToString();
                txt_comment.Text = STOCKDATA._comment;
                txt_remainQuantity.Text = STOCKDATA._remainQuantity.ToString();
                txt_misPlaced.Text = STOCKDATA._misPlacedQty.ToString();
                txt_dealerId.Text = STOCKDATA._dealerId.ToString();
                txt_dealer.Text = STOCKDATA._dealerName;
            }

            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmAdjustStock_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    BLL.ClsStockData newStockData = new BLL.ClsStockData();
                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("quantity", txt_quantity.Text));
                    dataList.Add(new Tuple<string, string>("buyingUnitPrice", txt_buyUnitPrice.Text));
                    dataList.Add(new Tuple<string, string>("sellingUnitPrice", txt_sellUnitPrice.Text));
                    dataList.Add(new Tuple<string, string>("priceAfterDiscount", txt_sellUnitPrice.Text));

                    isError = checkInsertedStockEntry(dataList);

                    if (!isError)
                    {
                        newStockData._stockEntryId = Convert.ToInt64(txt_entryId.Text);
                        newStockData._itemCode = txt_itemCode.Text;
                        newStockData._itemId = Convert.ToInt32(txt_itemId.Text);
                        newStockData._quantity = Convert.ToDouble(txt_quantity.Text);
                        newStockData._buyUnitPrice = Convert.ToDouble(txt_buyUnitPrice.Text);
                        newStockData._sellUnitPrice = Convert.ToDouble(txt_sellUnitPrice.Text);
                        newStockData._stockEntryDate = Convert.ToDateTime(txt_stockEntryDate.Text);
                        newStockData._expireDate = Convert.ToDateTime(txt_expireDate.Text);
                        //newStockData._createDate = DateTime.Today;
                        newStockData._totalValue = Convert.ToDouble(txt_totalValue.Text);
                        newStockData._updateDate = DateTime.Today;
                        newStockData._remainQuantity = Convert.ToDouble(txt_remainQuantity.Text);
                        newStockData._priceAfterDiscount = Convert.ToDouble(txt_priceAfterDiscount.Text);
                        newStockData._comment = txt_comment.Text;
                        newStockData._misPlacedQty = Convert.ToDouble(txt_misPlaced.Text);
                        newStockData._dealerId = Convert.ToInt32(txt_dealerId.Text);

                        if (MANAGEDB.updateData_stockEntry(newStockData))
                        {
                            COM_MESSAGE.successfullMessage("Successfully Updated the Stock Entry ");
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }

            Cursor.Current = Cursors.Default;
        }

        private bool checkInsertedStockEntry(List<Tuple<string, string>> stockEntry)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < stockEntry.Count; i++)
                {
                    switch (stockEntry[i].Item1)
                    {
                        case "quantity":
                            if (VALIDATION.isEmptyTextBox(stockEntry[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Quantity Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isDoubleValue(stockEntry[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Quantity is not Correct in format !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "buyingUnitPrice":
                            if (VALIDATION.isEmptyTextBox(stockEntry[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Buying Unit Price Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isDoubleValue(stockEntry[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Buying Unit Price is not in Correct format !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "sellingUnitPrice":
                            if (VALIDATION.isEmptyTextBox(stockEntry[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Selling Unit Price Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isDoubleValue(stockEntry[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Selling Unit Price is not in Correct format !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "priceAfterDiscount":
                            if (!VALIDATION.isEmptyTextBox(stockEntry[i].Item2))
                            {
                                if (!VALIDATION.isDoubleValue(stockEntry[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Price After Discount is not in Correct format !!!");
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

        private void txt_buyUnitPrice_Leave(object sender, EventArgs e)
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
                string buyUnitPrice = txt_buyUnitPrice.Text;
                string quantity = txt_quantity.Text;

                if (!string.IsNullOrEmpty(buyUnitPrice) && !string.IsNullOrEmpty(quantity))
                {
                    double totalVal = Convert.ToDouble(quantity) * Convert.ToDouble(buyUnitPrice);
                    txt_totalValue.Text = totalVal.ToString();
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_remainQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                txt_misPlaced.Text = ((STOCKDATA._remainQuantity - Convert.ToDouble(txt_remainQuantity.Text)) + STOCKDATA._misPlacedQty).ToString();
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_selectDealer_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSelectDealer dealer = new FrmSelectDealer(USERNAME))
                {
                    dealer.WindowState = FormWindowState.Normal;
                    dealer.ShowDialog();
                    this.txt_dealer.Text = (!string.IsNullOrEmpty(dealer.DealerName)) ? dealer.DealerName : this.txt_dealer.Text;
                    this.txt_dealerId.Text = (!string.IsNullOrEmpty(dealer.DealerId)) ? dealer.DealerId : this.txt_dealerId.Text; 
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
