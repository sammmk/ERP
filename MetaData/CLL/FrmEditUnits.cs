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
    public partial class FrmEditUnits : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditUnits()
        {
            InitializeComponent();
        }

        public FrmEditUnits(string userName)
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
                col.DataPropertyName = "unitId";
                col.Name = "unitId";
                col.HeaderText = "Unit Id";
                grd_editUnits.Columns.Add(col);
                grd_editUnits.DataSource = MANAGEDB.getUnitDetails();
                grd_editUnits.Columns["deleteFlg"].Visible = false;
                grd_editUnits.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

                //set grid view column headers
                grd_editUnits.Columns["unitId"].HeaderText = "Unit Id";
                grd_editUnits.Columns["description"].HeaderText = "Description";
                grd_editUnits.Columns["symbol"].HeaderText = "Symbol";

                cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditUnits_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int unitId = 0;
            BLL.ClsUnitData unitData = new BLL.ClsUnitData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        unitId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        unitData = MANAGEDB.getSingleUnitData(unitId);

                        FrmAddUnits frmAddUnits = new FrmAddUnits(unitData, USERNAME);
                        frmAddUnits.WindowState = FormWindowState.Normal;
                        frmAddUnits.ShowDialog();
                        grd_editUnits.DataSource = MANAGEDB.getUnitDetails();
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
                        dt = MANAGEDB.getUnitWhileSearching(type, txt_search.Text);
                        grd_editUnits.DataSource = dt;
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
                    dt = MANAGEDB.getUnitWhileSearching(type, txt_search.Text);
                    grd_editUnits.DataSource = dt;
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
