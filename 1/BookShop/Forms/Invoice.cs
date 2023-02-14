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
using BookShop.com.nimansa.db.configeration;

namespace BookShop
{
    public partial class Invoice : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;
        

        private int tot;
        DataTable dt = new DataTable();

        public Invoice()
        {
            InitializeComponent();
            con = Databaseconnection.getCOnnection();
            GenerateInvoiceID();
            this.ActiveControl = txt_cno;
            txt_cno.Focus();
        }

        public void setId(string bookid, string cusid, float totamount)
        {
            txt_cno.Text = cusid;
       
        }
        public void clear()
        {
            txt_bookname.Text = "";
            txt_bid.Text = "";
            txtbookpr.Text = "";
            txt_qty.Text = "";
            txt_amount.Text = "";
            txt_discount.Text = "";
            txt_sub_tot.Text = "";
        }
        public void display_data()
        {
            try
            {
                SqlCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "select * from Book_Ragistor";
                cmd7.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd7);
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        private void GenerateInvoiceID()
        {
            da = new SqlDataAdapter("select count(Invoice_No) from Invoice1", con);
            dt = new DataTable();

            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            string newcount = Convert.ToString(count + 1);
            string newInvNo = "";
            if (newcount.Length == 3)
            {
                newInvNo = "I" + newcount;
            }
            else if (newcount.Length == 2)
            {
                newInvNo = "I0" + newcount;
            }
            else if (newcount.Length == 1)
            {
                newInvNo = "I00" + newcount;
            }


            txt_ino.Text = newInvNo;
        }

   
    
        private void txt_cno_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void txt_tot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tot_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_creditno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter the letters and numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            string[] arr = new string[6];
            arr[0] = txt_bookname.Text;
            arr[1] = txtbookpr.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_amount.Text;
            arr[4] = txt_discount.Text;
            arr[5] = txt_sub_tot.Text;

            ListViewItem listitem = new ListViewItem(arr);
            listView1.Items.Add(listitem);


            lbldt.Text = DateTime.Now.ToString();
          LordThem();//buttunthem



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


        }//button them


        private void txt_bid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_cno_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_cno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_bid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txt_ino_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rb_cash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_bookname_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Txt_bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_bookname_KeyUp_1(object sender, KeyEventArgs e)
        {

            listBox1.Visible = true;
            listBox1.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Book_Ragistor where book_name like('" + txt_bookname.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["book_name"].ToString());
            }

        }

        private void Txt_bookname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void ListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    txt_bookname.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    txtbookpr.Focus();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Txtbookpr_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select top 1 * from Book_Ragistor where book_name='" + txt_bookname.Text + "'  ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtbookpr.Text = dr["book_price"].ToString();

                }
                foreach (DataRow dr in dt.Rows)
                {
                    txt_Av_Stock.Text = dr["quantity"].ToString();

                }
                foreach (DataRow dr in dt.Rows)
                {
                    txt_bid.Text = dr["book_id"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (txt_qty.Text == "" || txt_bookname.Text =="" )
            {

                MessageBox.Show("please fill the all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Convert.ToInt32(txt_qty.Text) <= 0)
            {
                MessageBox.Show("quantity cannot be Zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {

                    int Totle = 0;
                    int Book_Ragistor = 0;

                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from Book_Ragistor where book_name='" + txt_bookname.Text + "'";
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Book_Ragistor = Convert.ToInt32(dr1["quantity"].ToString());
                    }
                    if (Convert.ToInt32(txt_qty.Text) > Book_Ragistor)
                    {
                        
                        MessageBox.Show("This much of quantity is not available in stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string[] arr = new string[6];
                        arr[0] = txt_bookname.Text;
                        arr[1] = txtbookpr.Text;
                        arr[2] = txt_qty.Text;
                        arr[3] = txt_amount.Text;
                        arr[4] = txt_discount.Text;
                        arr[5] = txt_sub_tot.Text;

                        ListViewItem listitem = new ListViewItem(arr);
                        listView1.Items.Add(listitem);
                        txt_G_Total.Text = Convert.ToString(Convert.ToInt32(txt_sub_tot.Text) + Convert.ToInt32(txt_G_Total.Text));
                    }

                }
                catch (Exception ex)
                {

                }
            }
           clear();

        }

        private void TextBox1_Leave_1(object sender, EventArgs e)
        {
           
        }

        private void Txt_bid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbookpr_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_discount_Enter(object sender, EventArgs e)
        {
          
        }

        private void Txt_discount_Leave(object sender, EventArgs e)
        {
            try
            {
                txt_sub_tot.Text = (Convert.ToString(Convert.ToInt32(txt_amount.Text) - (Convert.ToInt32(txt_amount.Text) * Convert.ToInt32(txt_discount.Text)/100)));
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("courier new", 14);
            float fontHeight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 30;
            float lefmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELLCOME TO NIMANSA BOOK", new Font("courier new", 20), new SolidBrush(Color.Black), startx, starty);
            string top="DATE" + lbldt.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("--------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            graphics.DrawString("BOOK NAME\t PRICE QTY\tDISCOUNT TOTAL ", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 30;
            for (int x = 0; x < listView1.Items.Count; x++)
            {
                graphics.DrawString(listView1.Items[x].SubItems[0].Text + "\t\t" + listView1.Items[x].SubItems[1].Text + "\t" + listView1.Items[x].SubItems[2].Text + "\t" + listView1.Items[x].SubItems[3].Text + "\t" + listView1.Items[x].SubItems[4].Text + "\t" + listView1.Items[x].SubItems[5].Text + "\t", new Font("courier new", 20), new SolidBrush(Color.Black), startx, starty + offset);
                offset = offset + 20;
            }
            offset = offset + (int)FontHeight+5;
            graphics.DrawString("--------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 15;

            
            graphics.DrawString("GRAND TOTAL_RS."+ txt_G_Total.Text+".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("PAID AMOUNT_RS." + txt_paid_Amount.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("REFUND_RS." + txt_Refund.Text + ".00", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 20;

            graphics.DrawString("Thanks for your visit", font, new SolidBrush(Color.Black), startx, starty + offset);

            
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listView1.SelectedItems.Count;)
            {
                {
                    if (listView1.SelectedItems[i].Selected)
                    txt_G_Total.Text = (Convert.ToInt32(txt_G_Total.Text) - Convert.ToInt32(listView1.SelectedItems[i].SubItems[5].Text)).ToString();
                    listView1.SelectedItems[i].Remove();
                    MessageBox.Show("Data Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Txt_avqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_paid_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 if (txt_G_Total.Text.Length > 0)
                {
                    txt_Refund.Text = (Convert.ToInt32(txt_paid_Amount.Text) - Convert.ToInt32(txt_G_Total.Text)).ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Refund.Text = "";

            }

        }

        private void Lbl_G_Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbldt_Click(object sender, EventArgs e)
        {

        }

        private void Btn_save_print_Click(object sender, EventArgs e)
        {

           
            {
                try
                {
                    if (txt_qty.Text == "" || txt_bookname.Text == ""||  cmb_Pay_Type.Text == "")
                    {

                        MessageBox.Show("please fill the all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   else if (Convert.ToInt32(txt_qty.Text) <= 0)
                    {
                        MessageBox.Show("quantity cannot be Zero", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {

                        String insertQueryWithCustomerOrnot = "";
                        if (string.IsNullOrWhiteSpace(txt_cno.Text))
                        {
                            insertQueryWithCustomerOrnot = "####";
                        }
                        else
                        {
                            insertQueryWithCustomerOrnot = txt_cno.Text; ;
                        }

                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "Insert into Invoice1(Invoice_No,Date,bill_type,customer_id,book_id,book_name,price,Amount,qty,discount)  values ( '" + txt_ino.Text + "','" + lbldt.Text + "', '" + cmb_Pay_Type.GetItemText(cmb_Pay_Type.SelectedItem) + "','" + insertQueryWithCustomerOrnot + "','" + txt_bid.Text + "','" + txt_bookname.Text + "','" + txtbookpr.Text + "','" + txt_amount.Text + "' ,'" + txt_qty.Text + "','" + txt_discount.Text + "')";
                        cmd1.ExecuteNonQuery();
                        DataTable dt1 = new DataTable();

                        SqlCommand cmd6 = con.CreateCommand();
                        cmd6.CommandType = CommandType.Text;
                        cmd6.CommandText = "update Book_Ragistor set quantity= quantity - " + txt_qty.Text + " where book_name='" + txt_bookname.Text + "'";
                        cmd6.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);




                        //clear();
                        dt.Clear();
                    }
                }


                catch (Exception)
                {
                    MessageBox.Show("Record Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void Txt_discount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_sub_tot_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_qty_Leave(object sender, EventArgs e)
        {
            try
            {

                txt_amount.Text = Convert.ToString(Convert.ToInt32(txtbookpr.Text) * Convert.ToInt32(txt_qty.Text));
                txt_sub_tot.Text = Convert.ToString(Convert.ToInt32(txtbookpr.Text) * Convert.ToInt32(txt_qty.Text));

            }
            catch (Exception ex)
            {

            }
        }

        private void Txt_paid_Amount_Enter(object sender, EventArgs e)
        {
          
        }

        private void Txt_G_Total_Leave(object sender, EventArgs e)
        {
        }

        private void DISSS_Click(object sender, EventArgs e)
        {
            display_data();
        }


        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_discount.Focus();
            }
        }

        private void Txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }

        }

        private void Txtcustp_TextChanged(object sender, EventArgs e)
        {
            
           /* string query = "select * from Customer where telephone like('" + txt_cno.Text + "%')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string s_id = myreader.GetString(5);
                    txt_cno.Text = s_id;

                   
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            con.Close();*/
        }

        private void Txt_qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_discount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_paid_Amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_cno_KeyPress_2(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the valid Customer id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

