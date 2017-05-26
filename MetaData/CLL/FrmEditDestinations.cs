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
    public partial class FrmEditDestinations : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditDestinations()
        {
            InitializeComponent();
        }

        public FrmEditDestinations(string userName)
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
                col.DataPropertyName = "destinationId";
                col.Name = "destinationId";
                col.HeaderText = "Destination Id";
                grd_editDestination.Columns.Add(col);
                grd_editDestination.DataSource = MANAGEDB.getDestinationDetails();
                grd_editDestination.Columns["deleteFlg"].Visible = false;

                cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditDestinations_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int destinationId = 0;
            BLL.ClsDestinationData destinationData = new BLL.ClsDestinationData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        destinationId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        destinationData = MANAGEDB.getSingleDestinationData(destinationId);

                        FrmAddDestinations frmAddDestination = new FrmAddDestinations(destinationData, USERNAME);
                        frmAddDestination.WindowState = FormWindowState.Normal;
                        frmAddDestination.ShowDialog();
                        grd_editDestination.DataSource = MANAGEDB.getDestinationDetails();
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
                        dt = MANAGEDB.getDestinationWhileSearching(type, txt_search.Text);
                        grd_editDestination.DataSource = dt;
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
                if (type == 1)
                {
                    dt = MANAGEDB.getDestinationWhileSearching(type, txt_search.Text);
                    grd_editDestination.DataSource = dt;
                }
                else if (type > 1)
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
