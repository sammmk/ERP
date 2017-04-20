using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UserManage.BLL
{
    public class ClsUserManageDbChanges
    {
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsCommonMethods COMMON;
        private CommonControls.Classes.ClsCommonMethods COM_METHODS;

        public ClsUserManageDbChanges()
        {
            CONN = new CommonControls.Classes.dbConnection();
            COMMON = new CommonControls.Classes.ClsCommonMethods();
            COM_METHODS = new CommonControls.Classes.ClsCommonMethods();
        }

        public int getMaxUserID()
        {
            int maxUserId = 1;

            try
            {
                string querry = "SELECT MAX(userId) from tbl_login;";
                maxUserId = CONN.getMaxId(querry);

                //1000 for company Id or something like that : add only for the first value   
                if (maxUserId <= 1)
                    maxUserId += 1000;
            }
            catch (Exception e)
            {
                throw e;
            }

            return maxUserId;
        }

        public int getMaxUserRoleId()
        {
            int maxRoleId = 1;

            try
            {
                string querry = "SELECT MAX(userRoleId) from tbl_userrole;";
                maxRoleId = CONN.getMaxId(querry);

                //1000 for company Id or something like that : add only for the first value   
                if (maxRoleId <= 1)
                    maxRoleId += 20000;
            }
            catch (Exception e)
            {
                throw e;
            }

            return maxRoleId;
        }

        public DataTable getUserRoleList()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_userrole;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                dt = null;
                throw ex;
            }

            return dt;
        }

        public bool InsertData_userDetail(ClsUserManageData UserData)
        {
            bool ret = false;
            string insertToUserDetail = string.Empty;
            string insertToLogin = string.Empty;

            try
            {
                //create querry for tbl_userdetail
                insertToUserDetail = "INSERT INTO tbl_userdetail ( userId, userName, firstName, lastName, dob, NIC, address, email, roleId, phoneNo ) VALUES ( ";
                insertToUserDetail += "'" + UserData._userId + "',";
                insertToUserDetail += "'" + UserData._userName + "',";
                insertToUserDetail += "'" + UserData._firstName + "',";
                insertToUserDetail += "'" + UserData._lastName + "',";
                insertToUserDetail += "'" + UserData._dob + "',";
                insertToUserDetail += "'" + UserData._idNumber + "',";
                insertToUserDetail += "'" + UserData._address + "',";
                insertToUserDetail += "'" + UserData._email + "',";
                insertToUserDetail += "'" + UserData._roleId + "',";
                insertToUserDetail += "'" + UserData._phoneNo;
                insertToUserDetail += "');";

                //create querry for tbl_login
                insertToLogin = "INSERT INTO tbl_login ( userName, passWord, userId, roleId ) VALUES ( ";
                insertToLogin += "'" + UserData._userName + "',";
                insertToLogin += "'" + COMMON.EncodePassword(UserData._userName) + "',";
                insertToLogin += "'" + UserData._userId + "',";
                insertToLogin += "'" + UserData._roleId;
                insertToLogin += "');";

                if(CONN.update(insertToUserDetail))
                {
                    if (CONN.update(insertToLogin))
                    {
                        ret = true;
                    }
                }
            }
            catch(Exception e)
            {
                ret = false;
                throw e;
            }
            return ret;
        }

        public bool updateData_userDetail(ClsUserManageData UserData)
        {
            bool ret = false;

            try
            {
                string updateUserDetail = string.Empty;

                updateUserDetail = "UPDATE tbl_userdetail SET ";
                updateUserDetail += "firstName = '" + UserData._firstName + "',";
                updateUserDetail += "lastName = '" + UserData._lastName + "',";
                updateUserDetail += "dob = '" + UserData._dob + "',";
                updateUserDetail += "NIC = '" + UserData._idNumber + "',";
                updateUserDetail += "address ='" + UserData._address + "',";
                updateUserDetail += "email = '" + UserData._email + "',";
                updateUserDetail += "roleId = '" + UserData._roleId+ "',";
                updateUserDetail += "phoneNo = '" + UserData._phoneNo + "'";
                updateUserDetail += "WHERE userId = '" + UserData._userId + "';";

                ret = CONN.update(updateUserDetail);
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public bool insertData_userRole(int roleId, string role)
        {
            bool ret = false;
            string userRole = string.Empty;

            try
            {
                userRole = "INSERT INTO tbl_userrole (userRoleName, userRoleId) VALUES (";
                userRole += "'" + role + "',";
                userRole += "'" + roleId;
                userRole += "');";

                ret = CONN.update(userRole);
            }
            catch(Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }  

        public bool updateData_userRole(int roleId, string role)
        {
            bool ret = false;
            string userRole = string.Empty;

            try
            {
                userRole = "UPDATE tbl_userrole SET ";
                userRole += "userRoleName = '" + role;
                userRole += "' WHERE userRoleId = '";
                userRole += roleId + "';";

                ret = CONN.update(userRole);
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public DataTable getUserDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_userdetail WHERE deleteFlg != 1;";

                dt = CONN.getDataTable(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getUserRoleDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_userrole;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getFormDetails()
        {
            DataTable dt = new DataTable();
            string querry = string.Empty;

            try
            {
                querry = "SELECT * FROM tbl_userrole, tbl_forms;";

                dt = CONN.getDataTable(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public ClsUserManageData getSingleUserData(int userId)
        {
            ClsUserManageData userData = new ClsUserManageData();

            try
            {
                string querry = "SELECT * FROM tbl_userdetail u LEFT JOIN tbl_userrole r ON u.roleId = r.userRoleId WHERE userId = '" + userId + "'; ";
                
                DataTable dt = new DataTable();

                dt = CONN.getDataTable(querry);

                if (dt.Rows.Count > 0)
                {
                    userData._userId = Convert.ToInt16(dt.Rows[0]["userId"].ToString());
                    userData._userName = dt.Rows[0]["userName"].ToString();
                    userData._firstName = dt.Rows[0]["firstName"].ToString();
                    userData._lastName = dt.Rows[0]["lastName"].ToString();
                    userData._dob = Convert.ToDateTime(dt.Rows[0]["dob"].ToString());
                    userData._idNumber = dt.Rows[0]["NIC"].ToString();
                    userData._address = dt.Rows[0]["address"].ToString();
                    userData._email = dt.Rows[0]["email"].ToString();
                    userData._roleId = Convert.ToInt16(dt.Rows[0]["roleId"].ToString());
                    userData._phoneNo = dt.Rows[0]["phoneNo"].ToString();
                    userData._userRole = dt.Rows[0]["userRoleName"].ToString();
                }
                    
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return userData;
        }

        public clsUserRoleData getSingleRoleData(int roleId)
        {
            clsUserRoleData roleData = new clsUserRoleData();

            try
            {
                string querry = "SELECT * FROM tbl_userrole WHERE userRoleId = '" + roleId + "';";
                                    
                DataTable dt = new DataTable();

                dt = CONN.getDataTable(querry);

                roleData._roleId = Convert.ToInt16(dt.Rows[0]["userRoleId"]);
                roleData._roleName = dt.Rows[0]["userRoleName"].ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return roleData;
        }

        public bool deleteUser(int userId)
        {
            bool ret = false;
            string q = string.Empty;
            string qq = string.Empty;

            try
            {
                q = "UPDATE tbl_userdetail SET deleteFlg = '1' WHERE userId = '" + userId + "';";
                ret = CONN.update(q);

                qq = "UPDATE tbl_login SET deleteFlg = '1' WHERE userId = '" + userId + "';";
                ret = CONN.update(qq);
            }
            catch(Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public bool resetPassword(int userId, string userName)
        {
            bool ret = false;
            string querry = string.Empty;
            string password = string.Empty;

            try
            {
                password = COM_METHODS.EncodePassword(userName);

                querry = "UPDATE tbl_login SET passWord = '" + password + "' ";
                querry += "WHERE userId = '" + userId + "';";
                ret = CONN.update(querry);                
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }        

        public DataTable getUserRole_bySearch(string text)
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_userrole, tbl_forms WHERE userRoleName LIKE '" + text + "%';";

                dt = CONN.getDataTable(querry);                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getCurrentPermission()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_userpermission";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public bool insert_userPermission(List<clsUserPermission> list)
        {
            bool isOK = false;

            try
            {
                string delete = "DELETE FROM tbl_userpermission;";
                CONN.update(delete);

                foreach (clsUserPermission singleRow in list)
                {
                    string querry = string.Empty;
                    querry = "INSERT INTO tbl_userpermission (formId, userRoleId, viewPermission, actionPermission) VALUES (";
                    querry += "'" + singleRow._formId + "',";
                    querry += "'" + singleRow._roleId + "',";
                    querry += "'" + singleRow._view + "',";
                    querry += "'" + singleRow._action + "'";
                    querry += ");";

                    isOK = CONN.update(querry);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isOK;
        }
        
        public List<string> getUserNameList()
        {
            List<string> userList = new List<string>();

            try
            {
                string querry = "SELECT userName FROM tbl_userdetail;";

                if (CONN.openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONN.CONNECTION);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    int i = 0;
                    while (reader.Read())
                    {
                        userList.Add(reader["userName"].ToString());
                        i++;
                    }

                    CONN.closeConnection();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userList;
        }
        
    }
}
