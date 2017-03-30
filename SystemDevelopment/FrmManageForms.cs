using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelopment
{
    public partial class FrmManageForms : Form
    {
        public FrmManageForms()
        {
            InitializeComponent();
        }

        private void FrmManageForms_Load(object sender, EventArgs e)
        {
            //create columns
            //DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            //select.Name = "select";
            //select.HeaderText = "Select";
            //grd_all.Columns.Add(select);

            //DataGridViewColumn formName = new DataGridViewColumn();
            //formName.Name = "formName";
            //formName.HeaderText = "Form Name";
            //grd_all.Columns.Add(formName);

            //DataGridViewColumn project = new DataGridViewColumn();
            //project.Name = "project";
            //project.HeaderText = "Project";
            //grd_all.Columns.Add(project);

            //grd_all.DataSource = GetFormNames();
            
        }

        private DataTable createAllFormDetails()
        {
            DataTable dt = new DataTable();

            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private DataTable GetFormNames()
        {
            DataTable dt = new DataTable();
            DataRow row;
            List<string> projects = new List<string>();

            projects.Add("UserManage");
            projects.Add("SystemDevelopment");
            projects.Add("CommonControls");

            //add table column
            dt.Columns.Add("select", typeof(short));
            dt.Columns.Add("formName", typeof(string));
            dt.Columns.Add("project", typeof(string));

            foreach (string project in projects)
            {
                Assembly pro = Assembly.Load(project);

                foreach (Type t in pro.GetTypes())
                {
                    if (t.BaseType == typeof(Form))
                    {
                        var emptyCtor = t.GetConstructor(Type.EmptyTypes);
                        if (emptyCtor != null)
                        {
                            var f = (Form)emptyCtor.Invoke(new object[] { });
                            // t.FullName will help distinguish the unwanted entries and
                            // possibly later ignore them
                            string formItem = f.Name;   //t.FullName
                            row = dt.NewRow();
                            row["formName"] = f.Name;
                            row["project"] = project;
                            dt.Rows.Add(row);
                        }
                    }
                }
            }
            return dt;
        }
    }
}
