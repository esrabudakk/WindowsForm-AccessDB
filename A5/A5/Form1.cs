using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace A5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Esra\\Desktop\\Quizes.accdb");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            con.Open();

            //String queryString = "select UserName , Password from Student where UserName ='" + txtUserName.Text + "' AND Password ='" + txtPassword.Text+"';";
            string queryString = $"select UserName , Password from Student where UserName ='{txtUserName.Text}'AND Password ='{txtPassword.Text}';";

            OleDbCommand cmd = new OleDbCommand(queryString, con);

            OleDbDataReader LectorDatos;
            
            LectorDatos = cmd.ExecuteReader();

            Boolean ExistenciaRegistros = LectorDatos.HasRows;

            if(ExistenciaRegistros)
            {
              MessageBox.Show("Welcome " + txtUserName.Text, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form = new Form2();

                form.Show();
                this.Hide();
                con.Close();

            }
            else
            {
                MessageBox.Show("Unseccussful " + txtUserName.Text, "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                con.Close();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkboxShowHide_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkboxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkboxShowHide.Text = "Show password";
            }
        }

        
        
    }
}
