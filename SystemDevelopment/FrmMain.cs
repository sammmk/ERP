using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelopment
{
    public partial class Frm_Main : Form
    {
        private FormWindowState prevState;
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;

        public Frm_Main()
        {
            InitializeComponent();
            prevState = this.WindowState;
            CONN = new CommonControls.Classes.dbConnection();
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();

            this.ActiveControl = btn_userManage;
        }

        /// <summary>
        /// main form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //load main form in maximize state
            this.WindowState = FormWindowState.Maximized;

            hideButtons();

            //set user manage panel
            pnl_userManage.Height = 27;
            btn_userManage.Image = Properties.Resources.down;

            //set meta data panel
            pnl_metaData.Height = 27;
            btn_metaData.Image = Properties.Resources.down;

            //set inventory manage panel
            pnl_inventoryManage.Height = 27;
            btn_invManage.Image = Properties.Resources.down;

            lbl_loggedUser.Text = frm_Login.USERNAME;
        }

        private void hideButtons()
        {
            //hide the menu buttons
            btn_createUser.Visible = false;
            btn_editUser.Visible = false;
            btn_setFormPermission.Visible = false;
            btn_userRole.Visible = false;
            btn_editUserRole.Visible = false;

            btn_addItem.Visible = false;
            btn_editItem.Visible = false;
            btn_addItemType.Visible = false;
            btn_editItemType.Visible = false;
            btn_addDealer.Visible = false;
            btn_editDealer.Visible = false;
            btn_addDestination.Visible = false;
            btn_editDestination.Visible = false;
            btn_addAssets.Visible = false;
            btn_editAssets.Visible = false;

            btn_stockIntake.Visible = false;
            btn_adjustStock.Visible = false;
            btn_releaseStock.Visible = false;
            btn_adjustReleasedStock.Visible = false;
            btn_editStockEntry.Visible = false;
        }

        /// <summary>
        /// expand the User_Manage menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_userManage_Click(object sender, EventArgs e)
        {
            //show menu according to permission
            if (pnl_userManage.Height == 27)
            {
                //check permission
                int cnt = checkViewPermission_userManage();

                pnl_userManage.Height = (27 * cnt) + 2;
                btn_userManage.Image = Properties.Resources.up;
            }
            else
            {
                pnl_userManage.Height = 27;
                btn_userManage.Image = Properties.Resources.down;
                btn_createUser.Visible = false;
                btn_editUser.Visible = false;
                btn_setFormPermission.Visible = false;
                btn_userRole.Visible = false;
                btn_editUserRole.Visible = false;
            }
        }

        /// <summary>
        /// expand the Meta Data menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_metaData_Click(object sender, EventArgs e)
        {
            //show menu according to permission
            if (pnl_metaData.Height == 27)
            {
                //check permission
                int cnt = checkViewPermission_metaData();

                pnl_metaData.Height = (27 * cnt) + 2;
                btn_metaData.Image = Properties.Resources.up;
            }
            else
            {
                pnl_metaData.Height = 27;
                btn_metaData.Image = Properties.Resources.down;
                btn_addItem.Visible = false;
                btn_editItem.Visible = false;
                btn_addItemType.Visible = false;
                btn_editItemType.Visible = false;
                btn_addDealer.Visible = false;
                btn_editDealer.Visible = false;
                btn_addDestination.Visible = false;
                btn_editDestination.Visible = false;
                btn_addAssets.Visible = false;
                btn_editAssets.Visible = false;
            }
        }

        /// <summary>
        /// expand the Inventory_Manage menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_invManage_Click(object sender, EventArgs e)
        {
            //show menu according to permission
            if (pnl_inventoryManage.Height == 27)
            {
                //check permission
                int cnt = checkViewPermission_inventoryManage();

                pnl_inventoryManage.Height = (27 * cnt) + 2;
                btn_invManage.Image = Properties.Resources.up;
            }
            else
            {
                pnl_inventoryManage.Height = 27;
                btn_invManage.Image = Properties.Resources.down;
                btn_stockIntake.Visible = false;
                btn_adjustStock.Visible = false;
                btn_releaseStock.Visible = false;
                btn_adjustReleasedStock.Visible = false;
                btn_editStockEntry.Visible = false;
            }
        }

        /// <summary>
        /// Open the form create_user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createUser_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;

            UserManage.FrmCreateUser createUser = new UserManage.FrmCreateUser(lbl_loggedUser.Text);
            
            isFormOpen = windowOpenCheck(createUser.Name);

            if (isFormOpen)
            {
                createUser.BringToFront();
            }
            else
            {
                createUser.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(createUser);
                createUser.WindowState = FormWindowState.Maximized;
                createUser.Show();
            }
        }

        private void btn_userRole_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;

            UserManage.CLL.FrmAddUserRole addUserRole = new UserManage.CLL.FrmAddUserRole(lbl_loggedUser.Text);
            
            isFormOpen = windowOpenCheck(addUserRole.Name);

            if (isFormOpen)
            {
                addUserRole.BringToFront();
            }
            else
            {
                addUserRole.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addUserRole);

                addUserRole.Show();
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            UserManage.CLL.FrmEditUser editUser = new UserManage.CLL.FrmEditUser(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editUser.Name);

            if (isFormOpen)
            {
                editUser.BringToFront();
            }
            else
            {
                editUser.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editUser);

                editUser.Show();
            }
        }

        private void btn_editUserRole_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            UserManage.CLL.FrmEditUserRole editUserRole = new UserManage.CLL.FrmEditUserRole(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editUserRole.Name);

            if (isFormOpen)
            {
                editUserRole.BringToFront();
            }
            else
            {
                editUserRole.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editUserRole);

                editUserRole.Show();
            }
        }

        private void btn_setFormPermission_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            UserManage.CLL.FrmSetUserPermission userPermission = new UserManage.CLL.FrmSetUserPermission(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(userPermission.Name);

            if(isFormOpen)
            {
                userPermission.BringToFront();
            }
            else
            {
                userPermission.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(userPermission);

                userPermission.Show();
            }
        }


        private void btn_addItemType_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmAddItemType addItemType = new MetaData.CLL.FrmAddItemType(lbl_loggedUser.Text);
            
            isFormOpen = windowOpenCheck(addItemType.Name);

            if (isFormOpen)
            {
                addItemType.BringToFront();
            }
            else
            {
                addItemType.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addItemType);

                addItemType.Show();
            }
        }


        private void btn_editItemType_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmEditItemType editItemType = new MetaData.CLL.FrmEditItemType(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editItemType.Name);

            if (isFormOpen)
            {
                editItemType.BringToFront();
            }
            else
            {
                editItemType.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editItemType);

                editItemType.Show();
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmAddItem addItem = new MetaData.CLL.FrmAddItem(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(addItem.Name);

            if (isFormOpen)
            {
                addItem.BringToFront();
            }
            else
            {
                addItem.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addItem);

                addItem.Show();
            }
        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmEditItem editItem = new MetaData.CLL.FrmEditItem(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editItem.Name);

            if (isFormOpen)
            {
                editItem.BringToFront();
            }
            else
            {
                editItem.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editItem);

                editItem.Show();
            }
        }

        private void btn_addDealer_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmAddDealers addDealer = new MetaData.CLL.FrmAddDealers(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(addDealer.Name);

            if (isFormOpen)
            {
                addDealer.BringToFront();
            }
            else
            {
                addDealer.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addDealer);

                addDealer.Show();
            }
        }

        private void btn_editDealer_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmEditDealers editDealer = new MetaData.CLL.FrmEditDealers(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editDealer.Name);

            if (isFormOpen)
            {
                editDealer.BringToFront();
            }
            else
            {
                editDealer.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editDealer);

                editDealer.Show();
            }
        }

        private void btn_addDestination_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmAddDestinations addDestination = new MetaData.CLL.FrmAddDestinations(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(addDestination.Name);

            if (isFormOpen)
            {
                addDestination.BringToFront();
            }
            else
            {
                addDestination.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addDestination);

                addDestination.Show();
            }
        }

        private void btn_editDestination_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmEditDestinations editDestination = new MetaData.CLL.FrmEditDestinations(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editDestination.Name);

            if (isFormOpen)
            {
                editDestination.BringToFront();
            }
            else
            {
                editDestination.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editDestination);

                editDestination.Show();
            }
        }

        private void btn_addAssets_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmAddAssets addAssets = new MetaData.CLL.FrmAddAssets(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(addAssets.Name);

            if (isFormOpen)
            {
                addAssets.BringToFront();
            }
            else
            {
                addAssets.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addAssets);

                addAssets.Show();
            }
        }

        private void btn_editAssets_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            MetaData.CLL.FrmEditAssets editAssets = new MetaData.CLL.FrmEditAssets(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editAssets.Name);

            if (isFormOpen)
            {
                editAssets.BringToFront();
            }
            else
            {
                editAssets.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editAssets);

                editAssets.Show();
            }
        }

        private void btn_stockIntake_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            InventoryManage.CLL.FrmStockIntake  stock= new InventoryManage.CLL.FrmStockIntake(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(stock.Name);

            if (isFormOpen)
            {
                stock.BringToFront();
            }
            else
            {
                stock.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(stock);

                stock.Show();
            }
        }

        private void btn_editStockEntry_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            InventoryManage.CLL.FrmEditStockIntake editStock = new InventoryManage.CLL.FrmEditStockIntake(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(editStock.Name);

            if (isFormOpen)
            {
                editStock.BringToFront();
            }
            else
            {
                editStock.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editStock);

                editStock.Show();
            }
        }        
        
        private void btn_releaseStock_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            InventoryManage.CLL.FrmReleaseStock releaseStock = new InventoryManage.CLL.FrmReleaseStock(lbl_loggedUser.Text);

            isFormOpen = windowOpenCheck(releaseStock.Name);

            if (isFormOpen)
            {
                releaseStock.BringToFront();
            }
            else
            {
                releaseStock.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(releaseStock);

                releaseStock.Show();
            }
        }

        private void btn_formManage_Click(object sender, EventArgs e)
        {
            FrmManageForms formsManage = new FrmManageForms();

            formsManage.MdiParent = this;
            this.splitContainer1.Panel2.Controls.Add(formsManage);

            formsManage.Show();
        }

        private bool windowOpenCheck(string frmName)
        {
            bool ret = false;
            FormCollection FC = Application.OpenForms;

            try
            {
                foreach(Form frm in FC)
                {
                    if (frm.Name.Equals(frmName))
                    {
                        ret = true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        /// <summary>
        /// expandable menu
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            if (prevState != this.WindowState)
            {
                prevState = this.WindowState;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    //this.FormBorderStyle = FormBorderStyle.None;
                    //pnl_forms.Size = this.ClientSize;
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    //this.FormBorderStyle = FormBorderStyle.Sizable;
                    //pnl_forms.Size = pnl_formsSize;
                }
            }
            base.OnResize(e);
        }

        /// <summary>
        /// Logout button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login LoginForm = new frm_Login();
            LoginForm.Show();
        }
        
        private void lbl_changePassMouseHover(object sender, EventArgs e)
        {
            lbl_changePass.ForeColor = System.Drawing.Color.DarkGray;
            lbl_changePass.Cursor = Cursors.Hand;
        }

        private void lbl_changePassMouseLeave(object sender, EventArgs e)
        {
            lbl_changePass.ForeColor = System.Drawing.Color.Blue;
        }

        private void lbl_changePass_Click(object sender, EventArgs e)
        {
            FrmChangePassWd changePass = new FrmChangePassWd(lbl_loggedUser.Text);
            changePass.ShowDialog();

            if (FrmChangePassWd.IS_SUCCESS_MESSAGE)
            {
                this.Close();
                frm_Login login = new frm_Login();
                login.Show();
            }
        }

        private int checkViewPermission_inventoryManage()
        {            
            //btn_stockIntake.Visible = false;
            //btn_adjustStock.Visible = false;
            //btn_releaseStock.Visible = false;
            //btn_adjustReleasedStock.Visible = false;
            //btn_editStockEntry.Visible = false;

            int buttonCnt = 0;
            int userRoleId;
            DataTable dt = new DataTable();

            try
            {
                //get userId
                userRoleId = CONN.getUserRoleId(lbl_loggedUser.Text);

                //check the permission
                dt = CONN.getformPermissionPerUser(userRoleId);

                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt16(row["viewPermission"]) == 1)
                    {
                        switch (row["btnName"].ToString())
                        {                            
                            case "btn_stockIntake":
                                btn_stockIntake.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_adjustStock":
                                btn_adjustStock.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_releaseStock":
                                btn_releaseStock.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_adjustReleasedStock":
                                btn_adjustReleasedStock.Visible = true;
                                buttonCnt++;
                                break;                            
                            case "btn_editStockEntry":
                                btn_editStockEntry.Visible = true;
                                buttonCnt++;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }

            return buttonCnt + 1;
        }

        private int checkViewPermission_metaData()
        {
            int buttonCnt = 0;
            int userRoleId = 0;
            DataTable dt = new DataTable();

            //btn_addItem.Visible = false;
            //btn_editItem.Visible = false;
            //btn_addItemType.Visible = false;
            //btn_editItemType.Visible = false;
            //btn_addDealer.Visible = false;
            //btn_editDealer.Visible = false;
            //btn_addDestination.Visible = false;
            //btn_editDestination.Visible = false;
            //btn_addAssets.Visible = false;
            //btn_editAssets.Visible = false;

            try
            {
                //get userId
                userRoleId = CONN.getUserRoleId(lbl_loggedUser.Text);

                //check the permission
                dt = CONN.getformPermissionPerUser(userRoleId);

                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt16(row["viewPermission"]) == 1)
                    {
                        switch (row["btnName"].ToString())
                        {
                            case "btn_addItem":
                                btn_addItem.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editItem":
                                btn_editItem.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_addItemType":
                                btn_addItemType.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editItemType":
                                btn_editItemType.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_addDealer":
                                btn_addDealer.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editDealer":
                                btn_editDealer.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_addDestination":
                                btn_addDestination.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editDestination":
                                btn_editDestination.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_addAssets":
                                btn_addAssets.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editAssets":
                                btn_editAssets.Visible = true;
                                buttonCnt++;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }

            return buttonCnt;
        }

        private int checkViewPermission_userManage()
        {
            //btn_createUser.Visible = false;
            //btn_editUser.Visible = false;
            //btn_setFormPermission.Visible = false;
            //btn_userRole.Visible = false;
            //btn_editUserRole.Visible = false;

            int buttonCnt = 0;
            int userRoleId;
            DataTable dt = new DataTable();

            try
            {
                //get userId
                userRoleId = CONN.getUserRoleId(lbl_loggedUser.Text);

                //check the permission
                dt = CONN.getformPermissionPerUser(userRoleId);

                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt16(row["viewPermission"]) == 1)
                    {
                        switch (row["btnName"].ToString())
                        {
                            case "btn_createUser":
                                btn_createUser.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editUser":
                                btn_editUser.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_setFormPermission":
                                btn_setFormPermission.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_userRole":
                                btn_userRole.Visible = true;
                                buttonCnt++;
                                break;
                            case "btn_editUserRole":
                                btn_editUserRole.Visible = true;
                                buttonCnt++;
                                break;
                            default:
                                break;
                        }
                    }                        
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }

            return buttonCnt + 1;
        }

    }
}
