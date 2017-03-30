using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManage.CLL
{
    public partial class FrmSetUserPermission : Form
    { 
        private BLL.ClsUserManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        /// <summary>
        /// empty parameter constructor
        /// </summary>
        public FrmSetUserPermission()
        {
            InitializeComponent();
        }

        public FrmSetUserPermission(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsUserManageDbChanges();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            USERNAME = userName;

            InitializeComponent();
            
            getAllFormData();
        }

        private void getAllFormData()
        {
            DataTable dt_userPermission = new DataTable();

            try
            {
                dt_userPermission = MANAGEDB.getFormDetails();
                grd_userPermission.DataSource = dt_userPermission;

                DataGridViewCheckBoxColumn chkColView = new DataGridViewCheckBoxColumn();
                chkColView.Name = "View_permision";
                chkColView.HeaderText = "View Permission";
                grd_userPermission.Columns.Add(chkColView);

                DataGridViewCheckBoxColumn chkCol_act = new DataGridViewCheckBoxColumn();
                chkCol_act.Name = "act_permision";
                chkCol_act.HeaderText = "Action Permission";
                grd_userPermission.Columns.Add(chkCol_act);

                //hide columns
                grd_userPermission.Columns["isCommonForm"].Visible = false;

            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
        
        private void frm_userPermissionLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            grd_userPermission.DataSource = MANAGEDB.getUserRole_bySearch(txt_search.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<BLL.clsUserPermission> data = new List<BLL.clsUserPermission>();
            DataTable dt = new DataTable();
            bool isOK = false;

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    foreach (DataGridViewColumn col in grd_userPermission.Columns)
                    {
                        dt.Columns.Add(col.HeaderText);
                    }

                    foreach (DataGridViewRow row in grd_userPermission.Rows)
                    {
                        DataRow dRow = dt.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null)
                            {
                                dRow[cell.ColumnIndex] = 0;
                            }
                            else if (cell.Value is Boolean)
                            {
                                if (Convert.ToBoolean(cell.Value))
                                    dRow[cell.ColumnIndex] = 1;
                                else
                                    dRow[cell.ColumnIndex] = 0;
                            }
                            else
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                        }
                        dt.Rows.Add(dRow);
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CheckBox chk_view = dt.Rows[i]["View Permission"] as CheckBox;
                        CheckBox chk_act = dt.Rows[i]["Action Permission"] as CheckBox;

                        data.Add(new BLL.clsUserPermission()
                        {
                            _userRoleName = dt.Rows[i]["userRoleName"].ToString(),
                            _roleId = Convert.ToInt32(dt.Rows[i]["userRoleId"]),
                            _formId = Convert.ToInt32(dt.Rows[i]["formId"]),
                            _formName = dt.Rows[i]["formName"].ToString(),
                            _project = dt.Rows[i]["project"].ToString(),
                            _view = Convert.ToInt16(dt.Rows[i]["View Permission"]),
                            _action = Convert.ToInt16(dt.Rows[i]["Action Permission"])
                        });
                    }

                    //insert to db
                    isOK = MANAGEDB.insert_userPermission(data);

                    if (isOK)
                    {
                        COM_MESSAGE.successfullMessage("Successfully Updated user Permissions !!!");
                        this.Close();
                    }
                    else
                    {
                        COM_MESSAGE.errorMessage("user Permissions not updated successfully !!!", "EEROR");
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

        private void grd_userPermission_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                //should run only after added the checkbox columns
                if (grd_userPermission.Columns.Contains("View_permision") && grd_userPermission.Columns.Contains("act_permision"))
                {
                    DataTable dt_current = MANAGEDB.getCurrentPermission();

                    foreach (DataGridViewColumn col in grd_userPermission.Columns)
                    {
                        if ((string.Equals(col.Name, "View_permision")) || (string.Equals(col.Name, "act_permision")) || (string.Equals(col.Name, "isCommonForm")))
                        {
                            col.ReadOnly = false;
                        }
                        else
                        {
                            col.ReadOnly = true;
                        }
                    }

                    for (int a = 0; a < grd_userPermission.Rows.Count; a++)
                    {
                        for (int i = 0; i < dt_current.Rows.Count; i++)
                        {
                            if (grd_userPermission.Rows[a].Cells["formId"].Value.ToString() == dt_current.Rows[i].ItemArray[0].ToString() && grd_userPermission.Rows[a].Cells["userRoleId"].Value.ToString() == dt_current.Rows[i].ItemArray[1].ToString())
                            {
                                if (Convert.ToInt16(dt_current.Rows[i]["viewPermission"]) == 0)
                                {
                                    grd_userPermission.Rows[a].Cells["View_permision"].Value = false;
                                }
                                else
                                {
                                    grd_userPermission.Rows[a].Cells["View_permision"].Value = true;
                                }

                                if (Convert.ToInt16(dt_current.Rows[i]["actionPermission"]) == 0)
                                {
                                    grd_userPermission.Rows[a].Cells["act_permision"].Value = false;
                                }
                                else
                                {
                                    grd_userPermission.Rows[a].Cells["act_permision"].Value = true;
                                }
                                break;
                            }
                        }
                    }
                }

                this.grd_userPermission.Sort(this.grd_userPermission.Columns["userRoleId"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
