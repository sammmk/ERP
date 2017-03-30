using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CommonControls.Classes
{
    public class ClsCommonMethods
    {
        private dbConnection CONN;

        public ClsCommonMethods()
        {
            CONN = new dbConnection();
        }

        public string EncodePassword(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(originalPassword));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();

        }

        public void clearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllText(c);
            }
        }

        public bool checkActPermission(string formName, string userName)
        {
            bool hasPermission = false;

            try
            {
                int userRoleId;
                DataTable dt = new DataTable();

                //get userId
                userRoleId = CONN.getUserRoleId(userName);

                //get permission for user Role
                dt = CONN.getformPermissionPerUser(userRoleId);

                foreach (DataRow row in dt.Rows)
                {
                    if(string.Equals(formName, row["formName"].ToString()))
                    {
                        if(Convert.ToInt16(row["actionPermission"]) == 1)
                        {
                            hasPermission = true;
                        }
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return hasPermission;
        }
    }
}
