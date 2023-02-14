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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using BookShop.com.nimansa.db.configeration;
using System.IO;
using System.Web.UI;

namespace BookShop
{
    public partial class Purshase_Order : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public Purshase_Order()
        {
            InitializeComponent();
            con = Databaseconnection.getCOnnection();
            GeneratePurNO();
            fillsupname();
            fillbookname();

        
        }
        DataTable table = new DataTable();
        int selcetedrow;
        SqlCommand cmd5;
        SqlCommand cmd6;
        SqlCommand cmd7;
        private object graphics;

        private void GeneratePurNO()
        {
            DataTable dt;
            SqlDataAdapter da;
            da = new SqlDataAdapter("select count(Purchase_ON ) from Purchase_Order", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newpurchaseNo = "";
            if (newcount.Length == 3)
            {
                newpurchaseNo = "P" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newpurchaseNo = "P0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newpurchaseNo = "P00" + newcount;
            }


            txt_pno.Text = newpurchaseNo;
        }

        public void fillsupname()
        {
            string query = "Select * from Supplier  ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())

                {
                    string s_name = myreader.GetString(1);
                    cmb_supname.Items.Add(s_name);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }
        public void fillbookname()
        {
            
            string query1 = "Select * from  Book_Ragistor";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader myreader1;

            try
            {
                con.Open();
                myreader1 = cmd1.ExecuteReader();

                while (myreader1.Read())

                {
                    string b_name = myreader1.GetString(1);
                    cmb_book.Items.Add(b_name);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();



        }



      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }



        private void txt_sid_TextChanged(object sender, EventArgs e)
        {

        }

            private void Purshase_Order_Load(object sender, EventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString();


        }

       

        private void txt_bid_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Txt_pid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {


            try


            {

                if (txt_qty.Text == "" || cmb_book.Text == "")
                {

                    MessageBox.Show("please fill the all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txt_qty.Text) <= 0)
                {
                    MessageBox.Show("quantity cannot be Zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Purchase_Order(Purchase_ON,date,supplier_id,address,book_id,Book_name,qty)  values ('" + txt_pno.Text + "', '" + lbldt.Text + "', '" + txt_sid.Text + "', '" + txt_adress.Text + "', '" + txt_bid.Text + "', '" + cmb_book.Text + "', '" + txt_qty.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();


                    string[] arr = new string[6];
                    arr[0] = txt_pno.Text;
                    arr[1] = cmb_book.Text;
                    arr[2] = txt_qty.Text;
                    arr[3] = cmb_supname.Text;
                    arr[4] = txt_adress.Text;
                    arr[5] = lbldt.Text;

                    ListViewItem listitem = new ListViewItem(arr);
                    listView1.Items.Add(listitem);
                    cmb_book.Text = "";
                    txt_qty.Text = "";
                    txt_pno.Text = "";
                    GeneratePurNO();

                    MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Cmb_supname_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "Select * from Supplier where supplier_name  ='" + cmb_supname.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string s_id = myreader.GetString(0);
                    txt_sid.Text = s_id;

                    string s_email = myreader.GetString(4);
                    txt_email.Text = s_email;

                    string s_adress = myreader.GetString(2);
                    txt_adress.Text = s_adress;
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Cmb_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query1 = "Select * from  Book_Ragistor where book_name  ='" + cmb_book.Text + "'  ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader myreader1;

            try
            {
                con.Open();
                myreader1 = cmd1.ExecuteReader();


                while (myreader1.Read())

                {
                    string b_id = myreader1.GetString(0);
                    txt_bid.Text = b_id;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listView1.SelectedItems.Count;)
                {
                    {
                        if (listView1.SelectedItems[i].Selected)
                            listView1.SelectedItems[i].Remove();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_qty_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void Btn_email_Click(object sender, EventArgs e)
        {

             MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ramithashalinda99@gmail.com");
            mail.To.Add(txt_email.Text);
           
        

            string bookOrder = "";
             
            foreach (ListViewItem item in listView1.Items)
            {
                bookOrder += "\n" + " Book Name =  " + item.SubItems[1].Text.ToString() + "  Quantity = " + "(" + item.SubItems[2].Text.ToString() + ")";
              

            }
            mail.Subject = "New book request to adress : "+ "Nimansa Publishers 7 / 17,Adhikaram watta, Halpe, Mirigama.";
            mail.Body = "Dear sir/ Madam,  Please check this order and send to us : " + bookOrder + "Thank you Yours truly  Nimansa Publishers";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ramithashalinda99@gmail.com", "Ramitha@1999");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Send Email Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_stockid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_sid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Lbldt_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_topic_Click(object sender, EventArgs e)
        {

        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_qty_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
