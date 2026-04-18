using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isCredentialsValid())
            {              
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private bool isCredentialsValid()
        {
            DataTable dt = getCredentials();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            if (dt.Rows[0]["pass"].ToString() == txtPass.Text.Trim())
            {
                return true;
            }
            return false;
            
        }

        private DataTable getCredentials()
        {
            DataSet ds = new DataSet();
            string[] tbl = { "users" };
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@username", SqlDbType.VarChar);
            objParam[0].Value = txtUsername.Text.Trim();
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.getCredentials, ds, tbl, objParam);
            return ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

    }
}
