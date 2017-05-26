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
    public partial class FrmSelectDealer : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;
        public string DealerId { get; set; }
        public string DealerName { get; set; }

        public FrmSelectDealer()
        {
            InitializeComponent();
        }

        public FrmSelectDealer(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            USERNAME = userName;

            InitializeComponent();

            fillData();
        }

        private void fillData()
        {
            try
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.DataPropertyName = "dealerId";
                col.Name = "dealerId";
                col.HeaderText = "Dealer Id";
                grd_selectDealer.Columns.Add(col);
                grd_selectDealer.DataSource = MANAGEDB.getDealerDetails();

                cmb_search.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void grd_selectDealer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    DealerId = senderGrid.SelectedCells[e.ColumnIndex].Value.ToString();
                    DealerName = senderGrid.Rows[e.RowIndex].Cells["dealerName"].Value.ToString();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int type = cmb_search.SelectedIndex;

            try
            {
                if (type > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txt_search.Text))
                    {
                        dt = MANAGEDB.getDealerWhileSearching(type, txt_search.Text);
                        grd_selectDealer.DataSource = dt;
                    }
                }
                else
                {
                    COM_MESSAGE.validationMessage("Please Select Type to Search ");
                }

            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int type = cmb_search.SelectedIndex;

            try
            {
                if (type == 0)
                {
                    dt = MANAGEDB.getDealerWhileSearching(type, txt_search.Text);
                    grd_selectDealer.DataSource = dt;
                }
                else if (type > 0)
                {
                    txt_search.Focus();
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
