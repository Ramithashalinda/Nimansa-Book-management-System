using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data.SqlTypes;
using BookShop.com.nimansa.db.configeration;
using BookShop.com.nimansa.validation;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BookShop
{
    public partial class UserRegistor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        private string connectionString;

        public UserRegistor()
        {
            InitializeComponent();
            con = Databaseconnection.getCOnnection();
            GenerateUserId();
            this.ActiveControl = txt_fname;
            txt_fname.Focus();
        }
        private void GenerateUserId()
        {
            da = new SqlDataAdapter("select count(user_id) from User_Registor", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newCusId = "";
            if (newcount.Length == 3)
            {
                newCusId = "U" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newCusId = "U0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newCusId = "U00" + newcount;
            }


               txt_userid.Text = newCusId;
        }

       
        private void UserRegistor_Load(object sender, EventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();
            LordThem();


        }
        private void LordThem()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }


        }

        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User_Registor";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserFormValidation userCreationFormValidation = new UserFormValidation();

            Boolean resultFormValidation = userCreationFormValidation.validateRegistorForm(txt_userid, txt_fname, txt_lname, txt_address, txt_tp, txt_email, comboBox1, txt_createpw, txt_conformpw);
            Boolean mobileNoValidation = mobileNumberValidation(txt_tp, lbltperror);
            if (!resultFormValidation ||!mobileNoValidation)
            {
                MessageBox.Show("Please correctness of the fiels", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
           
            else
            {


                if (txt_fname.Text == "" || txt_createpw.Text == "" || txt_email.Text == "")
                    MessageBox.Show("please fill manatory fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                else if (txt_createpw.Text != txt_conformpw.Text)
                    MessageBox.Show("Password do not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                else
                {
                   try
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into User_Registor(user_id,first_name,last_name,address,user_role,password,telephone,email,register_date)  values ('" + txt_userid.Text.Trim() + "', '" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + txt_address.Text + "', '" + comboBox1.GetItemText(comboBox1.SelectedItem) + "','" + txt_createpw.Text.Trim() + "','" + txt_tp.Text + "','" + txt_email.Text + "', '" + lbldt.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        dg();
                        GenerateUserId();
                    }
                    catch
                    {

                    }


                    void clear()
                    {
                        txt_fname.Text = txt_lname.Text = txt_address.Text = comboBox1.Text = txt_createpw.Text = txt_tp.Text = txt_email.Text = txt_conformpw.Text = "";
                    }
                }

            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_conformpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidLable_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_createpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_mobile_Click(object sender, EventArgs e)
        {

        }


        private void Lbl_smname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_fname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_lname_Click(object sender, EventArgs e)
        {

        }

        private void Txt_userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        private void Lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_userno_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_fname_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Lbl_sfname_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDS_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  FROM User_Registor where user_id='" + dataGridView1.SelectedCells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dg();
                
                
            }
            catch
            {

            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString();
        }

        private void Txt_userid_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Txt_fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_lname.Focus();
            }
        }

        private void Txt_lname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();
            }
        }

        private void Txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tp.Focus();
            }
        }

        private void Txt_tp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }
        }

        private void Txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_createpw.Focus();
            }
        }

        private void Txt_createpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_conformpw.Focus();
            }

        }

        private void Txt_conformpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        public Boolean emailValidation(TextBox txt_email, Label lblemailerror)
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }

            return false;


        }
        private void Txt_mail_TextChanged(object sender, EventArgs e)
        {
            Boolean emailValidations = emailValidation(txt_email, lblemailerror);
            if (emailValidations)
            {
                lblemailerror.ForeColor = Color.Green;
                lblemailerror.Text = "Email is corret";
            }
            else
            {
                lblemailerror.ForeColor = Color.Red;
                lblemailerror.Text = "Email is incorret";
            }
        }

        public Boolean mobileNumberValidation(TextBox txt_tp, Label lbltperror)
        {
            string no = txt_tp.Text;
            Regex regex = new Regex(@"^(?:0|94|\+94|0094)?(?:(11|21|23|24|25|26|27|31|32|33|34|35|36|37|38|41|45|47|51|52|54|55|57|63|65|66|67|81|91)(0|2|3|4|5|7|9)|7(0|1|2|5|6|7|8)\d)\d{6}$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                return true;
            }

            return false;
        }
        private void Txt_tp_TextChanged_1(object sender, EventArgs e)
        {

            Boolean mobileNoValidation = mobileNumberValidation(txt_tp, lbltperror);

            if (mobileNoValidation)
            {
                lbltperror.ForeColor = Color.Green;
                lbltperror.Text = "Phone number is corret";
            }
            else
            {
                lbltperror.ForeColor = Color.Red;
                lbltperror.Text = "Phone number is incorret";
            }

        }

        private void Txt_tp_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }

        }

        private void Txt_mail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }

        }

        private void Txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }*/
        }

        private void Btn_sendmail_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ramithashalinda99@gmail.com");
            mail.To.Add(txt_email.Text);
            mail.Subject = "Wellcome to the Nimansa Publisher Registration "; 
            mail.Body = "Your Password  is" + txt_createpw.Text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ramithashalinda99@gmail.com", "Ramitha@1999");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Send Email Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}