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
                if (openConnection() == true)
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
    }    
}
