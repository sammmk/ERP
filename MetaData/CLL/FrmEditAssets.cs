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
    public partial class FrmEditAssets : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditAssets()
        {
            InitializeComponent();
        }

        public FrmEditAssets(string userName)
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
                col.DataPropertyName = "assetId";
                col.Name = "assetId";
                col.HeaderText = "Asset Id";
                grd_editAssets.Columns.Add(col);
                grd_editAssets.DataSource = MANAGEDB.getAssetDetails();
                grd_editAssets.Columns["deleteFlg"].Visible = false;
                grd_editAssets.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

                //set grid view column headers
                grd_editAssets.Columns["assetName"].HeaderText = "Asset Name";
                grd_editAssets.Columns["value"].HeaderText = "Value of Asset";
                grd_editAssets.Columns["description"].HeaderText = "Description";
                grd_editAssets.Columns["quantity"].HeaderText = "Quantity";
                grd_editAssets.Columns["totalValue"].HeaderText = "Total Value";

                cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditAssets_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int assetId = 0;
            BLL.ClsAssetData assetData = new BLL.ClsAssetData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        assetId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        assetData = MANAGEDB.getSingleAssetData(assetId);

                        FrmAddAssets frmAddAssets = new FrmAddAssets(assetData, USERNAME);
                        frmAddAssets.WindowState = FormWindowState.Normal;
                        frmAddAssets.ShowDialog();
                        grd_editAssets.DataSource = MANAGEDB.getAssetDetails();
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
                        dt = MANAGEDB.getAssetWhileSearching(type, txt_search.Text);
                        grd_editAssets.DataSource = dt;
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
                    dt = MANAGEDB.getAssetWhileSearching(type, txt_search.Text);
                    grd_editAssets.DataSource = dt;
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
