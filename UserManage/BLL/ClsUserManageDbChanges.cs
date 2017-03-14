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
        private ClsUserManageData USERDATA;

        public ClsUserManageDbChanges()
        {
            CONN = new CommonControls.Classes.dbConnection();
            COMMON = new CommonControls.Classes.ClsCommonMethods();
            USERDATA = new ClsUserManageData();
        }

        public bool maxUserID(out int maxId)
        {
            bool ret = false;
            int temp = 0;
            maxId = temp;

            try
            {
                if (CONN.openConnection())
                {                    
                    string querry = "SELECT MAX(userId) from tbl_login;";
                    MySqlCommand cmd = new MySqlCommand(querry, CONN.CONNECTION);
                    temp = Convert.ToInt16(cmd.ExecuteScalar());

                    //temp = Convert.ToInt16(CONNECTION.dbSelection_oneValue(querry));

                    if (temp <= 0)
                    {
                        maxId = 0;
                    }
                    else
                    {
                        maxId = temp;
                    }

                    CONN.closeConnection();
                }             

            }
            catch (Exception e)
            {
                throw e;
                //MESSAGE.exceptionMessage(e.Message);
            }

            return ret;
        }

        public DataTable userRoleList()
        {
            DataTable dt = new DataTable();
            List<string>[] userRole = new List<string>[2];

            userRole[0] = new List<string>();
            userRole[1] = new List<string>();

            try
            {
                if (CONN.openConnection())
                {
                    string querry = "select * from tbl_userrole;";
                    MySqlCommand cmd = new MySqlCommand(querry, CONN.CONNECTION);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    CONN.closeConnection();
                }
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
                insertToUserDetail = "INSERT INTO tbl_userdetail ( userId, userName, firstName, lastName, dob, NIC, address, email, roleId ) VALUES ( ";
                insertToUserDetail += "'" + UserData._userId + "',";
                insertToUserDetail += "'" + UserData._userName + "',";
                insertToUserDetail += "'" + UserData._firstName + "',";
                insertToUserDetail += "'" + UserData._lastName + "',";
                insertToUserDetail += "'" + UserData._dob + "',";
                insertToUserDetail += "'" + UserData._idNumber + "',";
                insertToUserDetail += "'" + UserData._address + "',";
                insertToUserDetail += "'" + UserData._email + "',";
                insertToUserDetail += "'" + UserData._roleId;
                insertToUserDetail += "');";

                //create querry for tbl_login
                insertToLogin = "INSERT INTO tbl_login ( userName, passWord, userId, roleId ) VALUES ( ";
                insertToLogin += "'" + UserData._userName + "',";
                insertToLogin += "'" + COMMON.EncodePassword(UserData._userName) + "',";
                insertToLogin += "'" + UserData._userId + "',";
                insertToLogin += "'" + UserData._userId;
                insertToLogin += "');";

                if (CONN.openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(insertToUserDetail, CONN.CONNECTION);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = insertToLogin;
                    cmd.ExecuteNonQuery();

                    CONN.closeConnection();

                    ret = true;
                }

            }
            catch(Exception e)
            {
                ret = false;
                throw e;
            }
            return ret;
        }

    }
}
