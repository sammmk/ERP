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
    public partial class FrmStockIntake : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsStockData STOCKDATA;
        private BLL.ClsInventoryManageDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmStockIntake()
        {
            InitializeComponent();
        }

        public FrmStockIntake(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsStockData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            txt_stockEntryDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
            USERNAME = userName;
            fillGrid();

            this.WindowState = FormWindowState.Maximized;
            this.ActiveControl = txt_itemCode;
        }

        public FrmStockIntake(BLL.ClsStockData stockData, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsStockData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            IS_UPDATING = true;
            USERNAME = userName;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_itemCode;
        }

        private void FrmStockIntake_Load(object sender, EventArgs e)
        {
            if (!IS_UPDATING)
            {
                setStockEntryId();

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void setStockEntryId()
        {
            try
            {
                string curr_date = DateTime.Today.ToString("yyyy/MM/dd").Replace("/", "");                
                int prefix = MANAGEDB.getIdPrefix("stockEntryId");
                string newId = string.Concat(curr_date, prefix.ToString(), "0001");

                //get max item Id
                long maxId = MANAGEDB.getMaxId("stockEntryId", "tbl_stockentry");

                //if there are no any id in db
                if (maxId <= 1)
                {
                    //set the start Id 
                    txt_entryId.Text = newId;
                }
                else
                {
                    string tmp = maxId.ToString().Substring(0, 8);

                    //same day stock entry
                    if (string.Equals(curr_date, tmp))
                    {
                        txt_entryId.Text = maxId.ToString();
                    }
                    //different day stock entry
                    else
                    {
                        txt_entryId.Text = newId;
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmStockIntake_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dateTime_stockEntry_ValueChanged(object sender, EventArgs e)
        {
            txt_stockEntryDate.Text = dateTime_stockEntry.Value.Date.ToString("yyyy/MM/dd");
        }

        private void dateTime_expire_ValueChanged(object sender, EventArgs e)
        {
            txt_expireDate.Text = dateTime_expire.Value.Date.ToString("yyyy/MM/dd");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("quantity", txt_quantity.Text));
                    dataList.Add(new Tuple<string, string>("buyingUnitPrice", txt_buyUnitPrice.Text));
                    dataList.Add(new Tuple<string, string>("sellingUnitPrice", txt_sellUnitPrice.Text));
                    dataList.Add(new Tuple<string, string>("priceAfterDiscount", txt_sellUnitPrice.Text));

                    isError = checkInsertedStockEntry(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        createStockData();

                        if (MANAGEDB.insertData_stockEntry(STOCKDATA))
                        {
                            COM_MESSAGE.successfullMessage("Successfully created the Stock Entry ");
                            COMM_METHODS.clearAllText(this);
                            setStockEntryId();
                            txt_stockEntryDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
                            fillGrid();
                            txt_itemCode.Focus();
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

            Cursor.Current = Cursors.Default;
        }

        private void createStockData()
        {
            try
            {
                STOCKDATA._stockEntryId = Convert.ToInt64(txt_entryId.Text);
                STOCKDATA._itemCode = txt_itemCode.Text;
                STOCKDATA._itemId = Convert.ToInt32(txt_itemId.Text);
                STOCKDATA._quantity = Convert.ToDouble(txt_quantity.Text);
                STOCKDATA._buyUnitPrice = Convert.ToDouble(txt_buyUnitPrice.Text);
                STOCKDATA._sellUnitPrice = Convert.ToDouble(txt_sellUnitPrice.Text);
                STOCKDATA._stockEntryDate = Convert.ToDateTime(txt_stockEntryDate.Text);
                STOCKDATA._expireDate = Convert.ToDateTime(txt_expireDate.Text);
                STOCKDATA._createDate = DateTime.Today;
                STOCKDATA._totalValue = Convert.ToDouble(txt_totalValue.Text);
                STOCKDATA._updateDate = DateTime.Today;
                STOCKDATA._remainQuantity = Convert.ToDouble(txt_quantity.Text);
                STOCKDATA._priceAfterDiscount = Convert.ToDouble(txt_priceAfterDiscount.Text);
                STOCKDATA._comment = txt_comment.Text;
                STOCKDATA._dealerId = (!string.IsNullOrEmpty(txt_dealerId.Text)) ? Convert.ToInt32(txt_dealerId.Text) : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        private void fillGrid()
        {
            try
            {
                //clear the gridview if there are any rows
                grd_stockCurrent.DataSource = null;
                grd_stockCurrent.Refresh();

                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.DataPropertyName = "stockEntryId";
                col.Name = "stockEntryId";
                col.HeaderText = "Stock Entry Id";
                grd_stockCurrent.Columns.Add(col);
                grd_stockCurrent.DataSource = MANAGEDB.getCurrentDayStockDetails();
                grd_stockCurrent.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

                //arrange the gridview
                grd_stockCurrent.Columns["stockEntryId"].DisplayIndex = 0;
                grd_stockCurrent.Columns["itemCode"].DisplayIndex = 1;
                grd_stockCurrent.Columns["itemName"].DisplayIndex = 2;
                grd_stockCurrent.Columns["quantity"].DisplayIndex = 3;
                grd_stockCurrent.Columns["remainQuantity"].DisplayIndex = 4;
                grd_stockCurrent.Columns["buyingUnitPrice"].DisplayIndex = 5;
                grd_stockCurrent.Columns["totalValue"].DisplayIndex = 6;
                grd_stockCurrent.Columns["sellingUnitPrice"].DisplayIndex = 7;
                grd_stockCurrent.Columns["createDate"].DisplayIndex = 8;
                //grd_stockCurrent.Columns["updateDate"].DisplayIndex = 9;
                //grd_stockCurrent.Columns["stockEntryDate"].DisplayIndex = 10;
                //grd_stockCurrent.Columns["expirationDate"].DisplayIndex = 11;
                grd_stockCurrent.Columns["dealerName"].DisplayIndex = 12;

                //change the header names
                grd_stockCurrent.Columns["stockEntryId"].HeaderText = "Stock_Id";
                grd_stockCurrent.Columns["itemCode"].HeaderText = "Item_Code";
                grd_stockCurrent.Columns["itemName"].HeaderText = "Item_Name";
                grd_stockCurrent.Columns["quantity"].HeaderText = "Qty";
                grd_stockCurrent.Columns["remainQuantity"].HeaderText = "Remain_Qty";
                grd_stockCurrent.Columns["buyingUnitPrice"].HeaderText = "Unit_Price(Buy)";
                grd_stockCurrent.Columns["totalValue"].HeaderText = "Total";
                grd_stockCurrent.Columns["sellingUnitPrice"].HeaderText = "Unit_Price(Sell)";
                grd_stockCurrent.Columns["createDate"].HeaderText = "Create";
                grd_stockCurrent.Columns["updateDate"].HeaderText = "Update";
                grd_stockCurrent.Columns["stockEntryDate"].HeaderText = "Entry";
                grd_stockCurrent.Columns["expirationDate"].HeaderText = "Expire";
                grd_stockCurrent.Columns["dealerName"].HeaderText = "Dealer"; 

                //hide columns
                grd_stockCurrent.Columns["updateDate"].Visible = false;
                grd_stockCurrent.Columns["stockEntryDate"].Visible = false;
                grd_stockCurrent.Columns["expirationDate"].Visible = false;
                grd_stockCurrent.Columns["itemId"].Visible = false;
                grd_stockCurrent.Columns["priceAfterDiscount"].Visible = false;
                grd_stockCurrent.Columns["comment"].Visible = false;
                grd_stockCurrent.Columns["releaseFlg"].Visible = false;
                grd_stockCurrent.Columns["dealerId"].Visible = false;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_itemCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();

                //get item data and fill data
                dt = MANAGEDB.getItemDataForStockEntry(txt_itemCode.Text);

                if (dt.Rows.Count >= 1)
                {
                    txt_itemId.Text = dt.Rows[0]["itemId"].ToString();
                    txt_itemName.Text = dt.Rows[0]["itemName"].ToString();

                    txt_quantity.Focus();
                    //System.Media.SystemSounds.Beep.Play();
                    //System.Media.SystemSounds.Asterisk.Play();
                    //System.Media.SystemSounds.Exclamation.Play();
                    //System.Media.SystemSounds.Question.Play();
                    //System.Media.SystemSounds.Hand.Play();
                }
                else
                {
                    txt_itemCode.Clear();
                    //System.Media.SystemSounds.Beep.Play();
                    //System.Media.SystemSounds.Asterisk.Play();
                    //System.Media.SystemSounds.Exclamation.Play();
                    //System.Media.SystemSounds.Question.Play();
                    //System.Media.SystemSounds.Hand.Play();
                }
            }
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
                    if (VALIDATION.isDoubleValue(buyUnitPrice) && VALIDATION.isDoubleValue(quantity))
                    {
                        double totalVal = Convert.ToDouble(quantity) * Convert.ToDouble(buyUnitPrice);
                        txt_totalValue.Text = totalVal.ToString();
                    }
                }
                else
                {
                    txt_totalValue.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void grd_stockCurrent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            long stockEntryId = 0;
            BLL.ClsStockData stockData = new BLL.ClsStockData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        stockEntryId = Convert.ToInt64(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        stockData = MANAGEDB.getSingleStockDetail(stockEntryId);

                        if (stockData._releaseFlg == 0)
                        {
                            FrmAdjustStock frmUser = new FrmAdjustStock(stockData, USERNAME);
                            frmUser.WindowState = FormWindowState.Normal;
                            frmUser.ShowDialog();
                            fillGrid();
                        }
                        else
                        {
                            COM_MESSAGE.warningMessage("The Entry you are trying to edit is released !!!", "Released Entry");
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

        private void btn_selectDealer_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSelectDealer dealer = new FrmSelectDealer(USERNAME))
                {
                    dealer.WindowState = FormWindowState.Normal;
                    dealer.ShowDialog();
                    this.txt_dealer.Text = dealer.DealerName;
                    this.txt_dealerId.Text = dealer.DealerId;
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
