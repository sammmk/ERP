using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SystemDevelopment
{
    public partial class frm_MainSolution : Form
    {
        private dbConnect conn;

        public frm_MainSolution()
        {
            InitializeComponent();
            conn = new dbConnect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(isValidUser() == true)
            {
                MessageBox.Show("Valid User");
            }
            else
            {
                MessageBox.Show("Invalid userName or Password");
            }
        }

        private bool isValidUser()
        {
            try 
            { 
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string encriptPass = EncodePassword(password);

                if (conn.matchString(userName, encriptPass))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
    }
}
