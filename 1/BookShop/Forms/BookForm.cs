using BookShop.com.nimansa.db.configeration;
using BookShop.com.nimansa.validation;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookRegister : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public BookRegister()
        {
            InitializeComponent();
            con = Databaseconnection.getCOnnection(); 
            GenerateBookID();
            this.ActiveControl = txt_sid;
            txt_sid.Focus();

        }
        
        public void setsupId(string id)
        {
            txt_sid.Text = id;
        }
       private void GenerateBookID()
      {
            da = new SqlDataAdapter("select count(book_id) from Book_Ragistor", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newBookNo = "";
            if (newcount.Length == 3)
            {
                newBookNo = "B" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newBookNo = "B0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newBookNo = "B00" + newcount;
            }


            tx_bid.Text = newBookNo;
        }


       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_decs_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void lbl_vprice_Click(object sender, EventArgs e)
        {

        }


        private void Book_Details_Load(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToString();
            if (con.State == ConnectionState.Open)
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
            cmd.CommandText = "select * from Book_Ragistor";
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

        private void txt_tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter numbers only,Don't enter the symbols and letters", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_quantity.Text =="" && e.KeyChar == '0')
            {
                e.Handled = true;
                
            }
            if(e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;

            }
        }
        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("please enter numbers only,Don't enter the symbols and letters", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    e.Handled = true;

                }


            }
        }

        private void txt_title_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;


        }

        private void txt_sid_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;


                MessageBox.Show("Enter the valid supplier id");
            }

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Supplier_tele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_topic_Click(object sender, EventArgs e)
        {

        }

        private void Txt_sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_sid_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  FROM Book_Ragistor where book_id='" + dataGridView1.SelectedCells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dg();
            }
            catch
            {

            }
              
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BookFormValidation BookCreationFormValidation = new BookFormValidation();

            Boolean resultFormValidation = BookCreationFormValidation.validateRegistorForm(txt_sid, txt_bookname, txtbookau, txt_price, txt_quantity);
            if (!resultFormValidation)
            {
                MessageBox.Show("Please fill the fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (Convert.ToInt32(txt_quantity.Text) <= 0)
            {
                MessageBox.Show("quantity cannot be Zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txt_price.Text) <= 0)
            {
                MessageBox.Show("Price cannot be Zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                try
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Book_Ragistor(book_id,book_name,book_price,quantity,book_author_name,date,supplier_id)  values ('" + tx_bid.Text + "', '" + txt_bookname.Text + "', '" + txt_price.Text + "', '" + txt_quantity.Text + "', '" + txtbookau.Text + "', '" + label17.Text + "', '" + txt_sid.Text + "')";
                    cmd.ExecuteNonQuery();

                    tx_bid.Text = "";
                    txt_bookname.Text = "";
                    txt_price.Text = "";
                    txt_quantity.Text = "";
                    txtbookau.Text = "";
                    txt_sid.Text = "";

                    MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dg();
                    GenerateBookID();
                }
                catch
                {

                }
            }
            
        }

        private void Txtserchbkname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Book_Ragistor where book_name like'" + txtserchbkname.Text + "%'";
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

        private void Txt_sid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_bookname.Focus();
            }
        }

        private void Txt_bookname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbookau.Focus();
            }
        }

        private void Txtbookau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_price.Focus();
            }
        }

        private void Txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_quantity.Focus();
            }
        }

        private void Txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void Txt_bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_bookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters and numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txtbookau_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbookau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_sid_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the valid supplier id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_price_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Txt_quantity_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Txtserchbkname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the valid book name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


