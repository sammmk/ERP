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
    public partial class FrmSelectDestination : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;
        public string DestinationId { get; set; }
        public string DestinationName { get; set; }

        public FrmSelectDestination()
        {
            InitializeComponent();
        }

        public FrmSelectDestination(string userName)
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
                col.DataPropertyName = "destinationId";
                col.Name = "destinationId";
                col.HeaderText = "Destination Id";
                grd_selectDestination.Columns.Add(col);
                grd_selectDestination.DataSource = MANAGEDB.getDestinationDetails();

                cmb_search.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void grd_selectDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    DestinationId = senderGrid.SelectedCells[e.ColumnIndex].Value.ToString();
                    DestinationName = senderGrid.Rows[e.RowIndex].Cells["destinationName"].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
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
                        dt = MANAGEDB.getDestinationWhileSearching(type, txt_search.Text);
                        grd_selectDestination.DataSource = dt;
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
                    dt = MANAGEDB.getDestinationWhileSearching(type, txt_search.Text);
                    grd_selectDestination.DataSource = dt;
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

        private void btn_addDestination_Click(object sender, EventArgs e)
        {
            try
            {
                using(MetaData.CLL.FrmAddDestinations destination = new MetaData.CLL.FrmAddDestinations(USERNAME))
                {
                    destination.WindowState = FormWindowState.Normal;
                    destination.ShowDialog();
                    this.grd_selectDestination.DataSource = null;
                    this.grd_selectDestination.Refresh();
                    this.fillData();
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
