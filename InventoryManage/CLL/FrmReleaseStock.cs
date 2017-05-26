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
    public partial class FrmReleaseStock : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsReleaseStock STOCKDATA;
        private BLL.ClsInventoryManageDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;
        private static bool MULTIPLE_STOCK_ID = false;
        private int ROW_INDEX = 0;
        private List<string> STOCK_ID_LIST = new List<string>();
        List<BLL.ClsManageReleaseQty> RELEASE = new List<BLL.ClsManageReleaseQty>();

        public FrmReleaseStock()
        {
            InitializeComponent();
        }

        public FrmReleaseStock(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsReleaseStock();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            dt_delivery.Value = DateTime.Today;
            USERNAME = userName;            

            this.WindowState = FormWindowState.Maximized;
            this.ActiveControl = btn_selectDestination;

            txt_billAmt.Text = 0.ToString();
            dt_delivery.MinDate = DateTime.Today;
            btn_add.Visible = true;
            btn_Cancel.Visible = false;
            btn_clear.Visible = true;
            btn_release.Visible = true;
        }

        public FrmReleaseStock(BLL.ClsReleaseStock releseStockData, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            STOCKDATA = new BLL.ClsReleaseStock();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            IS_UPDATING = true;
            USERNAME = userName;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_itemCode;

            btn_add.Visible = false;
            btn_Cancel.Visible = true;
            btn_clear.Visible = true;
            btn_release.Visible = false;
        }
        private void FrmReleaseStock_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IS_UPDATING)
                {
                    setReleaseId();

                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void setReleaseId()
        {
            try
            {
                string curr_date = DateTime.Today.ToString("yyyy/MM/dd").Replace("/", "");
                int prefix = MANAGEDB.getIdPrefix("stockReleaseId");
                string newId = string.Concat(curr_date, prefix.ToString(), "0001");

                //get max item Id
                long maxId = MANAGEDB.getMaxId("releaseId", "tbl_stockrelease");

                //if there are no any id in db
                if (maxId <= 1)
                {
                    //set the start Id 
                    txt_releaseId.Text = newId;
                }
                else
                {
                    string tmp = maxId.ToString().Substring(0, 8);

                    //same day stock entry
                    if (string.Equals(curr_date, tmp))
                    {
                        txt_releaseId.Text = maxId.ToString();
                    }
                    //different day stock entry
                    else
                    {
                        txt_releaseId.Text = newId;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void FrmReleaseStock_FormClosing(object sender, FormClosingEventArgs e)
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

                    var dataList = new List<Tuple<string, string>>();

                    isError = checkInsertedReleaseEntry(dataList);

                    if (!isError)
                    {
                        //insert to DataGrid
                        createDataRow();
                        clearAfterAdd();
                        txt_billAmt.Text = (Convert.ToDouble(txt_billAmt.Text) + Convert.ToDouble(txt_total.Text)).ToString();
                        txt_itemCode.Focus();
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

        private void createDataRow()
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                grd_releaseStock.Rows.Add(row);

                grd_releaseStock.Rows[ROW_INDEX].Cells["itemCode"].Value = txt_itemCode.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["itemName"].Value = txt_itemName.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["quantity"].Value = txt_releaseQty.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["unitPrice"].Value = txt_UnitPrice.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["discount"].Value = txt_discount.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["subTotal"].Value = txt_total.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["availableQty"].Value = txt_inStockQty.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["afterQty"].Value = (Convert.ToDouble(txt_inStockQty.Text) - Convert.ToDouble(txt_releaseQty.Text)).ToString();
                grd_releaseStock.Rows[ROW_INDEX].Cells["stockId"].Value = txt_stockEntryId.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["itemId"].Value = txt_itemId.Text;
                grd_releaseStock.Rows[ROW_INDEX].Cells["comment"].Value = txt_comment.Text;                
            }
            catch(Exception ex)
            {
                throw ex;
            }

            ROW_INDEX++;
        }

        private bool manageReleaseQty(double stockIdQty, double releaseQty)
        {
            bool isMultiple = false;

            try
            {
                //get total stock amount
                double totalAmt = MANAGEDB.getTotalStockAmountForItem(txt_itemCode.Text);
                DataTable dt = MANAGEDB.getStockEntryDetailsForItem(txt_itemCode.Text);
                double tmp = stockIdQty;
                int i = 1;
                RELEASE.Clear();
                STOCK_ID_LIST.Clear();

                //add first stockId details
                RELEASE.Add(new BLL.ClsManageReleaseQty()
                {
                    _stockEntryId = txt_stockEntryId.Text,
                    _availableQty = Convert.ToDouble(txt_stockIdQty.Text),
                    _issuedQty = Convert.ToDouble(txt_stockIdQty.Text),
                    _remainAfterIssuedQty = 0
                });

                STOCK_ID_LIST.Add(txt_stockEntryId.Text);

                double shortageQty = stockIdQty - releaseQty;

                while(shortageQty < 0)
                {
                    double a = Math.Abs(shortageQty);
                    double nextStockQty = Convert.ToDouble(dt.Rows[i]["remainQuantity"].ToString());
                    STOCK_ID_LIST.Add(dt.Rows[i]["stockEntryId"].ToString());
                    
                    shortageQty = nextStockQty - a;
                    RELEASE.Add(new BLL.ClsManageReleaseQty()
                    {
                        _stockEntryId = dt.Rows[i]["stockEntryId"].ToString(),
                        _availableQty = nextStockQty,
                        _issuedQty = (shortageQty <= 0) ? nextStockQty : a,
                        _remainAfterIssuedQty = (shortageQty <= 0) ? 0 : shortageQty
                    });

                    i++;
                }
                isMultiple = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return isMultiple;
        }

        private void clearAfterAdd()
        {
            try
            {
                txt_itemCode.Clear();
                txt_itemName.Clear();
                txt_itemId.Clear();
                txt_UnitPrice.Clear();
                txt_stockEntryId.Clear();
                txt_inStockQty.Clear();
                txt_releaseQty.Clear();
                txt_comment.Clear();
                txt_discount.Clear();
                txt_total.Clear();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private bool checkInsertedReleaseEntry(List<Tuple<string, string>> dataList)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    switch (dataList[i].Item1)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isError;
        }

        private void btn_selectDestination_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSelectDestination destination = new FrmSelectDestination(USERNAME))
                {
                    destination.WindowState = FormWindowState.Normal;
                    destination.ShowDialog();
                    this.txt_destName.Text = destination.DestinationName;
                    this.txt_destinationId.Text = destination.DestinationId;
                    this.txt_itemCode.Focus();
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_selectStockId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_itemCode.Text))
                {
                    using (FrmSelectStockEntry stockEntry = new FrmSelectStockEntry(USERNAME, txt_itemCode.Text, txt_releaseQty.Text, txt_stockIdQty.Text, STOCK_ID_LIST))
                    {
                        stockEntry.WindowState = FormWindowState.Normal;
                        stockEntry.ShowDialog();
                        this.txt_stockEntryId.Text = stockEntry.StockEntryId;
                        this.txt_inStockQty.Text = stockEntry.InStockQty.ToString();
                        this.txt_UnitPrice.Text = stockEntry.UnitPrice.ToString();
                    }
                }
                else
                {
                    COM_MESSAGE.validationMessage("Please Input Item Code");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_itemCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = new DataTable();
                    DataTable stock = new DataTable();
                    string itemCode = txt_itemCode.Text;
                    
                    //get item data and fill data
                    dt = MANAGEDB.getItemDataForStockEntry(itemCode);

                    if (dt.Rows.Count >= 1)
                    {
                        txt_itemId.Text = dt.Rows[0]["itemId"].ToString();
                        txt_itemName.Text = dt.Rows[0]["itemName"].ToString();
                        txt_itemCode.Text = dt.Rows[0]["itemCode"].ToString();

                        //get stock entry for item
                        stock = MANAGEDB.getStockEntryForItem(dt.Rows[0]["itemCode"].ToString());

                        if (stock.Rows.Count > 0)
                        {
                            txt_inStockQty.Text = MANAGEDB.getTotalStockAmountForItem(itemCode).ToString();
                            txt_stockIdQty.Text = stock.Rows[0]["remainQuantity"].ToString();
                            txt_UnitPrice.Text = stock.Rows[0]["sellingUnitPrice"].ToString();
                            txt_stockEntryId.Text = stock.Rows[0]["stockEntryId"].ToString();
                            //STOCK_ID_LIST.Add(txt_stockEntryId.Text);
                            

                            txt_releaseQty.Focus();
                            //System.Media.SystemSounds.Beep.Play();
                            //System.Media.SystemSounds.Asterisk.Play();
                            //System.Media.SystemSounds.Exclamation.Play();
                            //System.Media.SystemSounds.Question.Play();
                            //System.Media.SystemSounds.Hand.Play();
                        }
                        else
                        {
                            COM_MESSAGE.warningMessage("There are no Remain Quantity for the item you entered", "No Items Remain");
                        }
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
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_itemCode_Leave(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_releaseQty_Leave(object sender, EventArgs e)
        {
            try
            {
                double stockIdQty = 0;
                double releaseQty = 0;

                if (!string.IsNullOrEmpty(txt_inStockQty.Text) && 
                    !string.IsNullOrEmpty(txt_releaseQty.Text) && 
                    !string.IsNullOrEmpty(txt_stockIdQty.Text))
                {
                    stockIdQty = Convert.ToDouble(txt_stockIdQty.Text);
                    releaseQty = Convert.ToDouble(txt_releaseQty.Text);
                    double qty = Convert.ToDouble(txt_inStockQty.Text);

                    if (qty > releaseQty)
                    {
                        if (stockIdQty < releaseQty)
                        {
                            //COM_MESSAGE.warningMessage("Cannot release more than Available", "Not enough goods");
                            //txt_releaseQty.Text = string.Empty;
                            //txt_releaseQty.Focus();

                            MULTIPLE_STOCK_ID = manageReleaseQty(stockIdQty, releaseQty);

                            if (MULTIPLE_STOCK_ID)
                            {
                                txt_stockEntryId.Text = "Multiple";
                            }
                            //using (FrmSelectStockEntry select = new FrmSelectStockEntry(USERNAME, txt_itemCode.Text, releaseQty.ToString(), stockIdQty.ToString(), STOCK_ID_LIST))
                            //{
                            //    select.WindowState = FormWindowState.Normal;
                            //    select.ShowDialog();
                            //}
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txt_UnitPrice.Text))
                            {
                                if (string.IsNullOrEmpty(txt_discount.Text))
                                {
                                    txt_total.Text = (Convert.ToDouble(txt_UnitPrice.Text) * releaseQty).ToString();
                                    txt_discount.Focus();
                                }
                                else
                                {
                                    double unitPrice = Convert.ToDouble(txt_UnitPrice.Text);
                                    double discount = Convert.ToDouble(txt_discount.Text);
                                    txt_total.Text = Math.Ceiling(((unitPrice * releaseQty) * (100 - discount)) / 100).ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        COM_MESSAGE.warningMessage("Release Quantity is more than in Stock", "Not Enough Goods");
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_discount.Text))
                {
                    txt_discount.Text = 0.ToString();
                }
                if (!string.IsNullOrEmpty(txt_UnitPrice.Text) && !string.IsNullOrEmpty(txt_releaseQty.Text))
                {
                    double unitPrice = Convert.ToDouble(txt_UnitPrice.Text);
                    double qty = Convert.ToDouble(txt_releaseQty.Text);
                    double discount = Convert.ToDouble(txt_discount.Text);
                    double total = Math.Ceiling(((unitPrice * qty) * (100 - discount)) / 100);

                    txt_total.Text = total.ToString();
                    btn_add.Focus();
                }
                else
                {
                    COM_MESSAGE.warningMessage("Need both Quantity and Unit Price", "not enough data");
                }
                
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_total_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_UnitPrice.Text) &&
                    !string.IsNullOrEmpty(txt_total.Text) &&
                    !string.IsNullOrEmpty(txt_releaseQty.Text))
                {
                    double unitPrice = Convert.ToDouble(txt_UnitPrice.Text);
                    double qty = Convert.ToDouble(txt_releaseQty.Text);
                    double total = Convert.ToDouble(txt_total.Text);
                    double discount = Math.Round(100 - ((total * 100) / (unitPrice * qty)), 2);

                    txt_discount.Text = discount.ToString();
                    btn_add.Focus();
                }
                else
                {
                    COM_MESSAGE.warningMessage("Need both discount percentage and unit price", "not enough data");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void checkInputForDoubleValue(object sender, KeyPressEventArgs e)
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
                throw ex;
            }
        }

        private void txt_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                checkInputForDoubleValue(sender, e);
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_UnitPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!VALIDATION.isDoubleValue(txt_UnitPrice.Text))
                {
                    txt_UnitPrice.Text = string.Empty;
                    txt_UnitPrice.Focus();
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_releaseQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                checkInputForDoubleValue(sender, e);
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                checkInputForDoubleValue(sender, e);
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                checkInputForDoubleValue(sender, e);
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
