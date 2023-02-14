using BookShop.com.nimansa.db.configeration;
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


namespace BookShop
{
    public partial class login123 : Form
    {
        private SqlConnection con;

        public login123()
        {
            InitializeComponent();
           

        }
        
  

        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            con = Databaseconnection.getCOnnection();
            

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string query = "select *   from User_Registor where email = '" + txtMail.Text + "' and password = '" + txt_pass.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
               
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        if (myreader.GetString(4) != null)
                        {


                            if (myreader.GetString(4) == "Assistant")
                            {

                                Assistant_Dashboard2 obj = new Assistant_Dashboard2();
                                obj.Show();
                            }
                            else
                            {
                                Manager_Dashboard1 obj = new Manager_Dashboard1();
                                obj.Show();
                            }

                        }
                        else
                        {

                            MessageBox.Show("User Name or Password Incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("User Name or Password Incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
  
            }
            catch (Exception ex)

            {
                

            }
            con.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMail_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }*/
        }

        private void Txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
            }
        }

        private void LinklblForgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            if(txtMail.Text== "Enter Your Email")
            {
                txtMail.Text = "";

                txtMail.ForeColor = Color.Black;
            }
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Enter Your Email";

                txtMail.ForeColor = Color.Silver;
            }
        }

        private void Txt_pass_Enter(object sender, EventArgs e)
        {
           
        }

        private void Txt_pass_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
