using BookShop.com.nimansa.db.configeration;
using BookShop.com.nimansa.val;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class SupplierForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public SupplierForm()
        {
            InitializeComponent();
            con = Databaseconnection.getCOnnection();
            GenerateSupNo();
            this.ActiveControl = txt_supname;
            txt_supname.Focus();
        }
        private void GenerateSupNo()
        {
            da = new SqlDataAdapter("select count(supplier_id) from Supplier", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newSupNo = "";
            if (newcount.Length == 3)
            {
                newSupNo = "S" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newSupNo = "S0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newSupNo = "S00" + newcount;
            }


            txt_sid.Text = newSupNo;
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            SuppliyerFormValidation SuppliyerCreationFormValidation = new SuppliyerFormValidation();

            Boolean resultFormValidation = SuppliyerCreationFormValidation.validateRegistorForm(txt_sid,txt_supname, txt_add, txt_tp, txt_email);
            Boolean mobileNoValidation = mobileNumberValidation(txt_tp, lbltperror);
            Boolean emailValidation1 = emailValidation(txt_email, lblemailerror);
            if (!resultFormValidation ||!mobileNoValidation ||!emailValidation1)
            {
                MessageBox.Show("Please correctness of the fiels", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
               try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Supplier(supplier_id,supplier_name,address,telephone,email,register_date)  values ('" + txt_sid.Text.Trim() + "', '" + txt_supname.Text + "', '" + txt_add.Text + "', '" + txt_tp.Text + "', '" + txt_email.Text + "', '" + lbldate.Text + "')";
                    cmd.ExecuteNonQuery();

                    txt_sid.Text = "";
                    txt_supname.Text = "";
                    txt_add.Text = "";
                    txt_email.Text = "";
                    txt_tp.Text = "";
                    dg();
                    GenerateSupNo();
                    MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
            lbluptime.Text = DateTime.Now.ToString();
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
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete  from Supplier where supplier_id='" + dataGridView1.SelectedCells[0].Value + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dg();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select supplier_id Suplierid, supplier_name Supliername,address Address,telephone Telephone,email Email,register_date Date from Supplier where supplier_id='" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtupID.Text = dr["Suplierid"].ToString();
                txt_snamup.Text = dr["Supliername"].ToString();
                txt_addup.Text = dr["Address"].ToString();
                txt_tpup.Text = dr["Telephone"].ToString();
                txt_emailup.Text = dr["Email"].ToString();
                lbldate.Text = dr["Date"].ToString();
                

            }
        }

       /* private void Btn_update_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = + "',register_date='" + lbluptime + "' ";
            cmd.ExecuteNonQuery();

            panel2.Visible = false;
            dg();
        }*/

        private void Txt_search_sId_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier where supplier_id like'" + txt_search_sId.Text + "%'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Txt_sid_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Txt_supname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_add.Focus();
            }
         
        }

        private void Txt_add_KeyUp(object sender, KeyEventArgs e)
        {
           
           
        }

        private void Txt_tp_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Txt_add_KeyDown(object sender, KeyEventArgs e)
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
                btn_insert.Focus();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_search_sId_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Supplier where supplier_id like'" + txt_search_sId.Text + "%'";
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

        private void Label8_Click(object sender, EventArgs e)
        {

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
        public Boolean upemailValidation(TextBox txt_emailup, Label lblupemail)
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

        private void Txt_supname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_snamup_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_snamup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Btn_update_Click_1(object sender, EventArgs e)
        {
            SuppliyerFormValidation SuppliyerCreationFormValidation = new SuppliyerFormValidation();
            Boolean upemailValidation1 = upemailValidation(txt_emailup, lblupemail);
            Boolean mobileupNoValidation1 = mobileupNumberValidation(txt_tpup, lbluptperor);
            Boolean resultFormValidation = SuppliyerCreationFormValidation.validateupRegistorForm( txt_snamup,  txt_addup,  txt_tpup,  txt_emailup);
            if (!resultFormValidation || !upemailValidation1 || !mobileupNoValidation1)
            {
                MessageBox.Show("Please correctness of the fiels", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Supplier set supplier_name='" + txt_snamup.Text + "', address='" + txt_addup.Text + "', telephone='" + txt_tpup.Text + "',email='" + txt_emailup.Text + "' where supplier_id='" + txtupID.Text + "' ";
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

        private void Button1_Click(object sender, EventArgs e)
        {

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

        private void Txt_search_sId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the valid supplier id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
