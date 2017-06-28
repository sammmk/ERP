using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CommonControls.Classes
{
    public class dbConnection
    {
        public MySqlConnection CONNECTION;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        private ClsMessages MESSAGE;

        public dbConnection()
        {
            MESSAGE = new ClsMessages();
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "UserControl";
            uid = "root";
            password = "root";
            port = "3306";
            string connectionString = string.Empty;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "PORT=" + port + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            CONNECTION = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                CONNECTION.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MESSAGE.errorMessage("Cannot Connect Server", "Error");
                        break;
                    case 1045:
                        MESSAGE.errorMessage("DataBase UserName and Password are incorrect", "Error");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// check userName and passwd while login
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pass"></param>
        /// <returns>bool </returns>
        public bool matchString(string userName, string pass)
        {
            try
            {
                if (openConnection())
                {
                    string query = "select userName from tbl_login where userName = '" + userName + "' AND password = '" + pass + "' AND deleteFlag != 1;";
                    MySqlCommand cmd = new MySqlCommand(query, CONNECTION);
                    string getVal = Convert.ToString(cmd.ExecuteScalar());

                    closeConnection();

                    //return true if user exist
                    if (getVal != String.Empty)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MESSAGE.errorMessage(ex.Message, "Error");
                return false;
            }
        }

        /// <summary>
        /// close the db connection
        /// </summary>
        /// <returns></returns>
        public bool closeConnection()
        {
            try
            {
                CONNECTION.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool changePassword(string userName, string password)
        {
            bool isSuccess = false;
            string querry = "UPDATE tbl_login SET passWord = '";
            querry += password + "'";
            querry += "WHERE userName = '";
            querry += userName + "';";

            try
            {
                if(openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                    closeConnection();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isSuccess;
        }

        public DataTable getformPermissionPerUser(int roleId)
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_forms f LEFT JOIN tbl_userpermission u ON f.formId = u.formId WHERE u.userRoleId = '";
                querry += roleId.ToString() + "' AND f.isCommonForm = '0';";

                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry,CONNECTION);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    closeConnection();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public int getUserRoleId(string userName)
        {
            int roleId = 0;

            try
            {
                string querry = "SELECT roleId FROM tbl_userdetail WHERE userName = '";
                querry += userName + "';";

                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);

                    roleId = (cmd.ExecuteScalar() != DBNull.Value) ? Convert.ToInt32(cmd.ExecuteScalar()) : 0;

                    closeConnection();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return roleId;
        }

        public int getMaxId(string querry)
        {
            int ret = 0;
            int temp = ret;

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);
                    
                    temp = (cmd.ExecuteScalar() != DBNull.Value) ? Convert.ToInt32(cmd.ExecuteScalar()) : 0;

                    closeConnection();

                    if (temp <= 1)
                    {
                        ret = 1;
                    }
                    else
                    {
                        ret = temp + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public long getMaxId_long(string querry)
        {
            long ret = 0;
            long temp = ret;

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);

                    temp = (cmd.ExecuteScalar() != DBNull.Value) ? Convert.ToInt64(cmd.ExecuteScalar()) : 0;

                    closeConnection();

                    if (temp <= 1)
                    {
                        ret = 1;
                    }
                    else
                    {
                        ret = temp + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public int getPrefix(string querry)
        {
            int ret = 0;

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);

                    ret = (cmd.ExecuteScalar() != DBNull.Value) ? Convert.ToInt32(cmd.ExecuteScalar()) : 0;

                    closeConnection();                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public bool update(string querry)
        {
            bool ret = false;

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);
                    cmd.ExecuteNonQuery();

                    closeConnection();
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public DataTable getDataTable(string querry)
        {
            DataTable dt = new DataTable();

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    closeConnection();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public double getSumOfColumn(string querry)
        {
            double sum = 0;

            try
            {
                if (openConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(querry, CONNECTION);

                    sum = (cmd.ExecuteScalar() != DBNull.Value) ? Convert.ToDouble(cmd.ExecuteScalar()) : 0;

                    closeConnection();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return sum;
        }
    }    
}
