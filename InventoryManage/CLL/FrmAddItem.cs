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
    public partial class FrmAddItem : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsItemData CREATEITEM;
        private BLL.ClsInventoryManageDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;
        private static bool IS_UPDATING = false;

        public FrmAddItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when create item
        /// </summary>
        /// <param name="userName"></param>
        public FrmAddItem(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            CREATEITEM = new BLL.ClsItemData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            txt_itemID.Text = MANAGEDB.getMaxItemId().ToString();
            //fill data for itemType from db
            dropDown_itemType.DataSource = MANAGEDB.getItemTypeList();
            dropDown_itemType.DisplayMember = "itemType";
            dropDown_itemType.ValueMember = "typeId";
            dropDown_itemType.BindingContext = this.BindingContext;
            dropDown_itemType.SelectedIndex = -1;

            USERNAME = userName;

            btn_cancel.Visible = true;
            btn_create.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;

            this.WindowState = FormWindowState.Maximized;
            this.ActiveControl = txt_itemCode;
        }

        /// <summary>
        /// when Update
        /// </summary>
        /// <param name="singleItemDetails"></param>
        /// <param name="userName"></param>
        public FrmAddItem(BLL.ClsItemData singleItemDetails, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            CREATEITEM = new BLL.ClsItemData();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();

            InitializeComponent();

            txt_itemID.Text = singleItemDetails._itemId.ToString();
            txt_itemCode.Text = singleItemDetails._itemCode.ToString();
            txt_altName.Text = singleItemDetails._altName;
            txt_itemName.Text = singleItemDetails._itemName;
            txt_itemCode.Enabled = false;

            dropDown_itemType.DataSource = MANAGEDB.getItemTypeList();
            dropDown_itemType.DisplayMember = "itemType";
            dropDown_itemType.ValueMember = "typeId";
            dropDown_itemType.BindingContext = this.BindingContext;
            dropDown_itemType.SelectedIndex = dropDown_itemType.FindString(singleItemDetails._itemTypeName);

            btn_cancel.Visible = true;
            btn_create.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;

            IS_UPDATING = true;
            USERNAME = userName;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_itemCode;
        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {
            if (!IS_UPDATING)
            {
                //get max item Id
                txt_itemID.Text = MANAGEDB.getMaxItemId().ToString();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the user....\n\r Are you Sure???", "Delete the Item");

            if (result == DialogResult.Yes)
            {
                if (MANAGEDB.deleteItem(Convert.ToInt32(txt_itemID.Text)))
                {
                    IS_SUCCESS_MESSAGE = true;
                    this.Close();
                    COM_MESSAGE.successfullMessage("Successfully deleted the User");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddItem_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    string itemId = txt_itemID.Text;
                    string itemCode = txt_itemCode.Text;
                    string itemName = txt_itemName.Text;
                    string altName = txt_altName.Text;
                    string itemType = (dropDown_itemType.SelectedIndex != -1) ? dropDown_itemType.SelectedItem.ToString() : string.Empty;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("itemCode", itemCode));
                    dataList.Add(new Tuple<string, string>("itemName", itemName));
                    dataList.Add(new Tuple<string, string>("altName", altName));
                    dataList.Add(new Tuple<string, string>("itemType", itemType));

                    isError = checkInsertedItemData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        CREATEITEM._itemId = Convert.ToInt32(itemId);
                        CREATEITEM._itemCode = itemCode;
                        CREATEITEM._itemName = itemName;
                        CREATEITEM._altName = altName;
                        CREATEITEM._itemTypeId = Convert.ToInt32(dropDown_itemType.SelectedValue);

                        if (MANAGEDB.insertData_item(CREATEITEM))
                        {
                            COM_MESSAGE.successfullMessage("Successfully created the Item ");
                            COMM_METHODS.clearAllText(this);
                            dropDown_itemType.SelectedIndex = -1;
                            txt_itemID.Text = MANAGEDB.getMaxItemId().ToString();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    bool isError = false;
                    string itemId = txt_itemID.Text;
                    string itemCode = txt_itemCode.Text;
                    string itemName = txt_itemName.Text;
                    string altName = txt_altName.Text;
                    string itemType = (dropDown_itemType.SelectedIndex != -1) ? dropDown_itemType.SelectedItem.ToString() : string.Empty;

                    var dataList = new List<Tuple<string, string>>();

                    dataList.Add(new Tuple<string, string>("itemCode", itemCode));
                    dataList.Add(new Tuple<string, string>("itemName", itemName));
                    dataList.Add(new Tuple<string, string>("altName", altName));
                    dataList.Add(new Tuple<string, string>("itemType", itemType));

                    isError = checkInsertedItemData(dataList);

                    if (!isError)
                    {
                        //insert data to db
                        CREATEITEM._itemId = Convert.ToInt32(itemId);
                        CREATEITEM._itemCode = itemCode;
                        CREATEITEM._itemName = itemName;
                        CREATEITEM._altName = altName;
                        CREATEITEM._itemTypeId = Convert.ToInt32(dropDown_itemType.SelectedValue);

                        //insert to tbl_userDetail and tbl_login
                        if (MANAGEDB.updateData_item(CREATEITEM))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            this.Close();
                            COM_MESSAGE.successfullMessage("Successfully Updated the user ");
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

        private bool checkInsertedItemData(List<Tuple<string, string>> userData)
        {
            bool isError = false;
            
            try
            {
                for (int i = 0; i < userData.Count; i++)
                {
                    switch (userData[i].Item1)
                    {
                        case "itemCode":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Item Code Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Item Code should contains only Numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "itemName":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Item Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (VALIDATION.isSpecialChars(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Item Name should not contains special characters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "altName":
                            if (!VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                if (VALIDATION.isSpecialChars(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Alternative Name should not contains special characters !!!");
                                    isError = true;
                                }
                            }
                            break;
                        case "itemType":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Item Type Cannot be Empty !!!");
                                isError = true;
                            }
                            break;
                        default:
                            isError = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isError;
        }
    }
}
