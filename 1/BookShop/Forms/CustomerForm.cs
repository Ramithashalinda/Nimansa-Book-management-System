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
    public partial class Customer_Registration : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public Customer_Registration()
        {

            InitializeComponent();
            con = Databaseconnection.getCOnnection();
            GenerateCusNo();
            this.ActiveControl = txt_fname;
            txt_fname.Focus();

        }

        private void GenerateCusNo()
        {
            da = new SqlDataAdapter("select count(customer_id) from Customer", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newCusNo = "";
            if (newcount.Length == 3)
            {
                newCusNo = "C" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newCusNo = "C0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newCusNo = "C00" + newcount;
            }
           

            txt_cno.Text = newCusNo;
        }

       

        private void Customer_Registration_Load(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToString();
            label16.Text = DateTime.Now.ToString();
            label17.Text = DateTime.Now.ToString();
            label16.Text = DateTime.Now.ToString();
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dg();
            LordThem();
        }
        public void dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer"; 
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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



        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_add1_TextChanged(object sender, EventArgs e)
        {

        }


  
        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

       

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }



        private void Lbl_fname_Click(object sender, EventArgs e)
        {

        }

        private void Txt_address_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_mobile_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_fname_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_lname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_cusno_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cno_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_fname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_lname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_address_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public Boolean emailValidation(TextBox txt_email,Label lblemailerror)
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
        private void Txt_email_TextChanged(object sender, EventArgs e)
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



        public Boolean mobileNumberValidation(TextBox txt_tp,Label lbltperror)
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
        
        private void Txt_tp_TextChanged(object sender, EventArgs e)
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

   

        private void Button1_Click_1(object sender, EventArgs e)
        {

            CustomerFormValidation customerCreationFormValidation = new CustomerFormValidation();
            Boolean mobileNoValidation = mobileNumberValidation(txt_tp, lbltperror);
            Boolean emailValidation1 = emailValidation(txt_email, lblemailerror);
            Boolean resultFormValidation = customerCreationFormValidation.validateRegistorForm(  txt_fname,  txt_lname,  txt_address,  txt_tp,  txt_email);
            if (!resultFormValidation||!mobileNoValidation ||!emailValidation1)
            {
                MessageBox.Show("Please correctness of the fiels", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
            else
            {
               try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Customer(customer_id,first_name,last_name,address,register_date,telephone,email)  values ('" + txt_cno.Text + "', '" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + txt_address.Text + "', '" + label17.Text + "', '" + txt_tp.Text + "', '" + txt_email.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_cno.Text = "";
                    txt_fname.Text = "";
                    txt_lname.Text = "";
                    txt_address.Text = "";
                    txt_tp.Text = "";
                    txt_email.Text = "";

                    dg();
                    GenerateCusNo();
                    MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }

            }

        }

        private void BtnDS_Click(object sender, EventArgs e)
        {
           try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete  from Customer where customer_id='" + dataGridView1.SelectedCells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                dg();
            }
            catch
            {

            }

        }

        private void Btn_us_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
    
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customer_id customerid, first_name firstName,last_name lastName,address Address,register_date Updatedate,telephone Telephone,email Email from Customer where customer_id='" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt .Rows)
            {
                txt_fnameup.Text = dr["firstName"].ToString();
                txt_lnameup.Text = dr["lastName"].ToString();
                txt_addressup.Text = dr["Address"].ToString();
                label16.Text = dr["Updatedate"].ToString();
                txt_tpup.Text = dr["Telephone"].ToString();
                txt_emailup.Text = dr["Email"].ToString();
                txtID.Text = dr["customerid"].ToString();

            }
        }
        public Boolean mobileupNumberValidation(TextBox txt_tpup, Label lbluptperor)
        {
            string no = txt_tpup.Text;
            Regex regex = new Regex(@"^(?:0|94|\+94|0094)?(?:(11|21|23|24|25|26|27|31|32|33|34|35|36|37|38|41|45|47|51|52|54|55|57|63|65|66|67|81|91)(0|2|3|4|5|7|9)|7(0|1|2|5|6|7|8)\d)\d{6}$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                return true;
            }

            return false;
        }


        private void Txt_tpup_TextChanged(object sender, EventArgs e)
        {

            Boolean mobileupNoValidation = mobileupNumberValidation(txt_tp, lbluptperor);

            if (mobileupNoValidation)
            {
                lbluptperor.ForeColor = Color.Green;
                lbluptperor.Text = "Phone number is corret";
            }
            else
            {
                lbluptperor.ForeColor = Color.Red;
                lbluptperor.Text = "Phone number is incorret";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            CustomerFormValidation customerupCreationFormValidation = new CustomerFormValidation();
            Boolean upemailValidation1 = upemailValidation(txt_emailup, lblupemail);
            Boolean mobileupNoValidation1 = mobileupNumberValidation(txt_tpup, lbluptperor);
            Boolean resultFormValidation = customerupCreationFormValidation.validateupRegistorForm(txt_fnameup, txt_lnameup, txt_addressup, txt_tpup, txt_emailup );
            if (!resultFormValidation|| !upemailValidation1||!mobileupNoValidation1) 
            {
               
                MessageBox.Show("Please correctness of the fiels", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else
            {

                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Customer set first_name='" + txt_fnameup.Text + "', last_name='" + txt_lnameup.Text + "', address='" + txt_addressup.Text + "',register_date='" + label16.Text + "',telephone='" + txt_tpup.Text + "',email='" + txt_emailup.Text + "' where customer_id='" + txtID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    panel2.Visible = false;
                    dg();
                }
                catch
                {

                }
               
            }
        }
        public Boolean upemailValidation(TextBox txt_emailup , Label lblupemail)
        {
            string email = txt_emailup.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }

            return false;


        }

        private void Txt_emailup_TextChanged(object sender, EventArgs e)
        {
            Boolean upemailValidation1 = upemailValidation(txt_emailup, lblupemail);
            if (upemailValidation1)
            {
                lblupemail.ForeColor = Color.Green;
                lblupemail.Text = "Email is corret";
            }
            else
            {
                lblupemail.ForeColor = Color.Red;
                lblupemail.Text = "Email is incorret";
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer where telephone like'" + textBox2.Text + "%'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
           
        }

       
        private void Label12_Click(object sender, EventArgs e)
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
                button1.Focus();
            }
        }

        private void Txt_fname_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_lname_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_fnameup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_lnameup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("please enter numbers only,Don't enter the symbols and letters", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void Txt_tpup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("please enter numbers only,Don't enter the symbols and letters", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("please enter numbers only,Don't enter the symbols and letters", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void Btn_sendmail_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ramithashalinda99@gmail.com");
            mail.To.Add(txt_email.Text);
            mail.Subject = "Wellcome to the Nimansa Publisher Customer Registration ";
            mail.Body = "Your ID  is" + txt_cno.Text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ramithashalinda99@gmail.com", "Ramitha@1999");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Send Email Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



        
    


