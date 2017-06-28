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
    public partial class FrmEditTax : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditTax()
        {
            InitializeComponent();
        }

        public FrmEditTax(string userName)
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
                col.DataPropertyName = "taxId";
                col.Name = "taxId";
                col.HeaderText = "Tax Id";
                grd_editTax.Columns.Add(col);
                grd_editTax.DataSource = MANAGEDB.getTaxDetails();
                grd_editTax.Columns["deleteFlg"].Visible = false;

                //cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditTax_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editTax_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int taxId = 0;
            BLL.ClsTaxData taxData = new BLL.ClsTaxData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        taxId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        taxData = MANAGEDB.getSingleTaxData(taxId);

                        FrmAddTax frmTax = new FrmAddTax(taxData, USERNAME);
                        frmTax.WindowState = FormWindowState.Normal;
                        frmTax.ShowDialog();
                        grd_editTax.DataSource = MANAGEDB.getTaxDetails();
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
    }
}
