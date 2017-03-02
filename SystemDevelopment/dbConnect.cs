using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SystemDevelopment
{
    public class dbConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public dbConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "DB_test";
            uid = "Admin";
            password = "admin";
            port = "3306";
            string connectionString = string.Empty;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "PORT=" + port + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot Connect Server");
                        break;
                    case 1045:
                        MessageBox.Show("UserName and Password are incorrect");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        public bool matchString(string userName, string pass)
        {
            try
            {
                //if (openConnection() == true)
                //{
                    if(connection != null)
                        connection.Open();
                    
                    string query = "select userName, password from tbl_login where userName = '" + userName + "' AND password = '" + pass + "' AND deleteFlg != 1;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    string getVal = Convert.ToString(cmd.ExecuteScalar());
                    
                    closeConnection();

                    return true;
                //}
                //else
                //{
                    //return false;
                //}
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
