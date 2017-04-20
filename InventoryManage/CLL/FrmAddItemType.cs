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
    public partial class FrmAddItemType : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsInventoryManageDbChanges MANAGEDB;

        private static string USERNAME;
        private static bool IS_UPDATING = false;
        private static bool IS_SUCCESS_MESSAGE = false;

        public FrmAddItemType()
        {
            InitializeComponent();
        }

        public FrmAddItemType(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            USERNAME = userName;
            btn_update.Visible = false;
            btn_add.Visible = true;
            IS_UPDATING = false;
        }

        public FrmAddItemType(BLL.ClsItemTypeData itemType, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();
            USERNAME = userName;

            InitializeComponent();

            txt_itemTypeID.Text = itemType._itemTypeId.ToString();
            txt_itemType.Text = itemType._itemTypeName;

            IS_UPDATING = true;
            btn_update.Visible = true;
            btn_add.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_itemType;
        }

        private void FrmAddItemType_Load(object sender, EventArgs e)
        {
            if (!IS_UPDATING)
            {
                //get max item type Id
                txt_itemTypeID.Text = MANAGEDB.getMaxItemTypeID().ToString();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddItemType_FormClosing(object sender, FormClosingEventArgs e)
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
            bool isError = false;
            int itemTypeIdId = Convert.ToInt16(txt_itemTypeID.Text);
            string itemType = txt_itemType.Text;

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    //validate item Type name
                    if (VALIDATION.isEmptyTextBox(itemType))
                    {
                        COM_MESSAGE.validationMessage("Item Type Cannot be Empty !!!");
                        isError = true;
                    }
                    else
                    {
                        if (!VALIDATION.isLetterAndNumberOnly(itemType))
                        {
                            COM_MESSAGE.validationMessage("Item Type should contains only Letters and Numbers !!!");
                            isError = true;
                        }
                    }

                    if (!isError)
                    {
                        //insert data to tbl_itemtype
                        if (MANAGEDB.insertData_itemType(itemTypeIdId, itemType))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            COM_MESSAGE.successfullMessage("Successfully created the Item Type !!!");
                            clearAllText(this);
                            txt_itemTypeID.Text = MANAGEDB.getMaxItemTypeID().ToString();
                            txt_itemType.Focus();
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

        private void clearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllText(c);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                bool isError = false;
                int itemTypeId = Convert.ToInt16(txt_itemTypeID.Text);
                string itemType = txt_itemType.Text;

                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    //validate User Role
                    if (VALIDATION.isEmptyTextBox(itemType))
                    {
                        COM_MESSAGE.validationMessage("User Role Cannot be Empty !!!");
                        isError = true;
                    }
                    else
                    {
                        if (!VALIDATION.isLetterAndNumberOnly(itemType))
                        {
                            COM_MESSAGE.validationMessage("User Role should contains only Letters and Numbers !!!");
                            isError = true;
                        }
                    }

                    if (!isError)
                    {
                        //update data to tbl_itemtype
                        if (MANAGEDB.updateData_itemType(itemTypeId, itemType))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            COM_MESSAGE.successfullMessage("Successfully Updated the user Role ");
                            this.Close();
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
    }
}
