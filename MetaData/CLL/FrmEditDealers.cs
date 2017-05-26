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
    public partial class FrmEditDealers : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditDealers()
        {
            InitializeComponent();
        }

        public FrmEditDealers(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsMetaDataDbChanges();
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
                grd_editDealer.Columns.Add(col);
                grd_editDealer.DataSource = MANAGEDB.getDealerDetails();
                grd_editDealer.Columns["deleteFlg"].Visible = false;

                cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditDealers_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editDealer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int dealerId = 0;
            BLL.ClsDealerData dealerData = new BLL.ClsDealerData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        dealerId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        dealerData = MANAGEDB.getSingleDealerData(dealerId);

                        FrmAddDealers frmDealer = new FrmAddDealers(dealerData, USERNAME);
                        frmDealer.WindowState = FormWindowState.Normal;
                        frmDealer.ShowDialog();
                        grd_editDealer.DataSource = MANAGEDB.getDealerDetails();
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
                        grd_editDealer.DataSource = dt;
                    }
                }
                else
                {
                    COM_MESSAGE.validationMessage("Please Select Type to Search ");
                }
                
            }
            catch(Exception ex)
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
                if (type == 1)
                {
                    dt = MANAGEDB.getDealerWhileSearching(type, txt_search.Text);
                    grd_editDealer.DataSource = dt;
                }
                else if(type > 1)
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
