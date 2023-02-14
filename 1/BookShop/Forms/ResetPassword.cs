using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BookShop.com.nimansa.db.configeration;

namespace BookShop
{
    public partial class ResetPassword : Form
    {

        string username = SendCode.to;
        private SqlConnection con;

        public ResetPassword(String emailAdress)
        {
            InitializeComponent();
            textBox1.Text = emailAdress;
            con = Databaseconnection.getCOnnection(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tstResetPass.Text == txtResetPassVeri.Text)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                // SqlConnection con = new SqlConnection("Data Source=DESKTOP-2A05F4R;Initial Catalog=nimansaDB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[User_Registor] SET [password] = '" + txtResetPassVeri.Text + "' WHERE email='" + textBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("The new password do not match so enter same password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login123 lg = new login123();
            this.Hide();
            lg.Show();
        }
    }
}
