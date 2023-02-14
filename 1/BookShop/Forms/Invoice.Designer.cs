namespace BookShop
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_sgender = new System.Windows.Forms.Label();
            this.txt_ino = new System.Windows.Forms.TextBox();
            this.lbl_ino = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txtbookpr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cusno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sub_tot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Pay_Type = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.DISSS = new System.Windows.Forms.Button();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cno = new System.Windows.Forms.TextBox();
            this.txt_Av_Stock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_paid_Amount = new System.Windows.Forms.TextBox();
            this.txt_G_Total = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_save_print = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Refund = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sgender
            // 
            this.lbl_sgender.AutoSize = true;
            this.lbl_sgender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sgender.ForeColor = System.Drawing.Color.Red;
            this.lbl_sgender.Location = new System.Drawing.Point(304, 318);
            this.lbl_sgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sgender.Name = "lbl_sgender";
            this.lbl_sgender.Size = new System.Drawing.Size(0, 20);
            this.lbl_sgender.TabIndex = 206;
            // 
            // txt_ino
            // 
            this.txt_ino.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ino.Location = new System.Drawing.Point(96, 23);
            this.txt_ino.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ino.Multiline = true;
            this.txt_ino.Name = "txt_ino";
            this.txt_ino.ReadOnly = true;
            this.txt_ino.Size = new System.Drawing.Size(93, 22);
            this.txt_ino.TabIndex = 200;
            this.txt_ino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ino.TextChanged += new System.EventHandler(this.Txt_ino_TextChanged);
            // 
            // lbl_ino
            // 
            this.lbl_ino.AutoSize = true;
            this.lbl_ino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ino.Location = new System.Drawing.Point(7, 29);
            this.lbl_ino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ino.Name = "lbl_ino";
            this.lbl_ino.Size = new System.Drawing.Size(85, 16);
            this.lbl_ino.TabIndex = 199;
            this.lbl_ino.Text = "Invoice-NO";
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.Location = new System.Drawing.Point(783, 12);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(110, 16);
            this.lbldt.TabIndex = 201;
            this.lbldt.Text = "Date and Time";
            this.lbldt.Click += new System.EventHandler(this.Lbldt_Click);
            // 
            // txt_bookname
            // 
            this.txt_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookname.Location = new System.Drawing.Point(759, 44);
            this.txt_bookname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_bookname.MaxLength = 16;
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(151, 20);
            this.txt_bookname.TabIndex = 207;
            this.txt_bookname.TextChanged += new System.EventHandler(this.Txt_bookname_TextChanged);
            this.txt_bookname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_bookname_KeyDown);
            this.txt_bookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_creditno_KeyPress);
            this.txt_bookname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_bookname_KeyUp_1);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(560, 145);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(93, 22);
            this.txt_amount.TabIndex = 211;
            this.txt_amount.TextChanged += new System.EventHandler(this.Txt_amount_TextChanged);
            // 
            // txtbookpr
            // 
            this.txtbookpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookpr.Location = new System.Drawing.Point(560, 44);
            this.txtbookpr.Margin = new System.Windows.Forms.Padding(2);
            this.txtbookpr.Multiline = true;
            this.txtbookpr.Name = "txtbookpr";
            this.txtbookpr.ReadOnly = true;
            this.txtbookpr.Size = new System.Drawing.Size(93, 22);
            this.txtbookpr.TabIndex = 212;
            this.txtbookpr.TextChanged += new System.EventHandler(this.Txtbookpr_TextChanged);
            this.txtbookpr.Enter += new System.EventHandler(this.Txtbookpr_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 214;
            this.label4.Text = "Quantity";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(759, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 212;
            this.listBox1.Visible = false;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 210;
            this.label2.Text = "Book Name";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(561, 249);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 28);
            this.btn_add.TabIndex = 216;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 222;
            this.label9.Text = "Dicsount";
            // 
            // lbl_cusno
            // 
            this.lbl_cusno.AutoSize = true;
            this.lbl_cusno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusno.Location = new System.Drawing.Point(195, 29);
            this.lbl_cusno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cusno.Name = "lbl_cusno";
            this.lbl_cusno.Size = new System.Drawing.Size(92, 16);
            this.lbl_cusno.TabIndex = 197;
            this.lbl_cusno.Text = "Customer ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 221);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 224;
            this.label10.Text = "Sub Totle";
            // 
            // txt_sub_tot
            // 
            this.txt_sub_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_tot.Location = new System.Drawing.Point(560, 215);
            this.txt_sub_tot.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sub_tot.Multiline = true;
            this.txt_sub_tot.Name = "txt_sub_tot";
            this.txt_sub_tot.ReadOnly = true;
            this.txt_sub_tot.Size = new System.Drawing.Size(93, 22);
            this.txt_sub_tot.TabIndex = 225;
            this.txt_sub_tot.TextChanged += new System.EventHandler(this.Txt_sub_tot_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 216;
            this.label6.Text = "Payment Type";
            // 
            // cmb_Pay_Type
            // 
            this.cmb_Pay_Type.FormattingEnabled = true;
            this.cmb_Pay_Type.Items.AddRange(new object[] {
            "CASH",
            "CARD"});
            this.cmb_Pay_Type.Location = new System.Drawing.Point(532, 23);
            this.cmb_Pay_Type.Name = "cmb_Pay_Type";
            this.cmb_Pay_Type.Size = new System.Drawing.Size(121, 21);
            this.cmb_Pay_Type.TabIndex = 217;
            this.cmb_Pay_Type.Enter += new System.EventHandler(this.ComboBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.DISSS);
            this.panel2.Controls.Add(this.txt_bid);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.txt_discount);
            this.panel2.Controls.Add(this.txt_sub_tot);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtbookpr);
            this.panel2.Controls.Add(this.txt_amount);
            this.panel2.Controls.Add(this.txt_bookname);
            this.panel2.Location = new System.Drawing.Point(10, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 299);
            this.panel2.TabIndex = 211;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(426, 238);
            this.dataGridView2.TabIndex = 231;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(462, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 230;
            this.label11.Text = "Book Id";
            // 
            // DISSS
            // 
            this.DISSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISSS.Location = new System.Drawing.Point(17, 19);
            this.DISSS.Name = "DISSS";
            this.DISSS.Size = new System.Drawing.Size(160, 23);
            this.DISSS.TabIndex = 240;
            this.DISSS.Text = "Display Book Details";
            this.DISSS.UseVisualStyleBackColor = true;
            this.DISSS.Click += new System.EventHandler(this.DISSS_Click);
            // 
            // txt_bid
            // 
            this.txt_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bid.Location = new System.Drawing.Point(560, 70);
            this.txt_bid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_bid.Multiline = true;
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.ReadOnly = true;
            this.txt_bid.Size = new System.Drawing.Size(93, 22);
            this.txt_bid.TabIndex = 229;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(560, 109);
            this.txt_qty.Multiline = true;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(93, 22);
            this.txt_qty.TabIndex = 228;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_qty_KeyDown);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_qty_KeyPress);
            this.txt_qty.Leave += new System.EventHandler(this.Txt_qty_Leave);
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(561, 181);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(93, 22);
            this.txt_discount.TabIndex = 226;
            this.txt_discount.TextChanged += new System.EventHandler(this.Txt_discount_TextChanged);
            this.txt_discount.Enter += new System.EventHandler(this.Txt_discount_Enter);
            this.txt_discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_discount_KeyDown);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_discount_KeyPress);
            this.txt_discount.Leave += new System.EventHandler(this.Txt_discount_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 213;
            this.label3.Text = "Book Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_cno);
            this.panel1.Controls.Add(this.txt_Av_Stock);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_Pay_Type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_ino);
            this.panel1.Controls.Add(this.txt_ino);
            this.panel1.Controls.Add(this.lbl_cusno);
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 55);
            this.panel1.TabIndex = 210;
            // 
            // txt_cno
            // 
            this.txt_cno.Location = new System.Drawing.Point(299, 24);
            this.txt_cno.Multiline = true;
            this.txt_cno.Name = "txt_cno";
            this.txt_cno.Size = new System.Drawing.Size(93, 22);
            this.txt_cno.TabIndex = 229;
            this.txt_cno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cno_KeyPress_2);
            // 
            // txt_Av_Stock
            // 
            this.txt_Av_Stock.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Av_Stock.Location = new System.Drawing.Point(804, 15);
            this.txt_Av_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Av_Stock.Multiline = true;
            this.txt_Av_Stock.Name = "txt_Av_Stock";
            this.txt_Av_Stock.ReadOnly = true;
            this.txt_Av_Stock.Size = new System.Drawing.Size(93, 22);
            this.txt_Av_Stock.TabIndex = 238;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(683, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 228;
            this.label8.Text = "Available Stock";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 397);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 255);
            this.listView1.TabIndex = 214;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Totle";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Discount";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sub Totle";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(587, 405);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(156, 32);
            this.btn_Remove.TabIndex = 231;
            this.btn_Remove.Text = "Remove Item";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 227;
            this.label1.Text = "Pay Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(673, 567);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 232;
            this.label7.Text = "Refund";
            // 
            // txt_paid_Amount
            // 
            this.txt_paid_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid_Amount.Location = new System.Drawing.Point(786, 520);
            this.txt_paid_Amount.Multiline = true;
            this.txt_paid_Amount.Name = "txt_paid_Amount";
            this.txt_paid_Amount.Size = new System.Drawing.Size(93, 22);
            this.txt_paid_Amount.TabIndex = 234;
            this.txt_paid_Amount.TextChanged += new System.EventHandler(this.Txt_paid_Amount_TextChanged);
            this.txt_paid_Amount.Enter += new System.EventHandler(this.Txt_paid_Amount_Enter);
            this.txt_paid_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_paid_Amount_KeyPress);
            // 
            // txt_G_Total
            // 
            this.txt_G_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_G_Total.Location = new System.Drawing.Point(786, 480);
            this.txt_G_Total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_G_Total.Multiline = true;
            this.txt_G_Total.Name = "txt_G_Total";
            this.txt_G_Total.ReadOnly = true;
            this.txt_G_Total.Size = new System.Drawing.Size(93, 22);
            this.txt_G_Total.TabIndex = 227;
            this.txt_G_Total.Text = "0";
            this.txt_G_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_G_Total.TextChanged += new System.EventHandler(this.Lbl_G_Total_TextChanged);
            this.txt_G_Total.Leave += new System.EventHandler(this.Txt_G_Total_Leave);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(679, 603);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 32);
            this.button4.TabIndex = 236;
            this.button4.Text = "Print Bill";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // btn_save_print
            // 
            this.btn_save_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_print.Location = new System.Drawing.Point(764, 405);
            this.btn_save_print.Name = "btn_save_print";
            this.btn_save_print.Size = new System.Drawing.Size(156, 32);
            this.btn_save_print.TabIndex = 237;
            this.btn_save_print.Text = "Save ";
            this.btn_save_print.UseVisualStyleBackColor = true;
            this.btn_save_print.Click += new System.EventHandler(this.Btn_save_print_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(673, 486);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 239;
            this.label12.Text = "Grand Total";
            // 
            // txt_Refund
            // 
            this.txt_Refund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Refund.Location = new System.Drawing.Point(786, 561);
            this.txt_Refund.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Refund.Multiline = true;
            this.txt_Refund.Name = "txt_Refund";
            this.txt_Refund.ReadOnly = true;
            this.txt_Refund.Size = new System.Drawing.Size(93, 22);
            this.txt_Refund.TabIndex = 229;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.txt_Refund);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_save_print);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_G_Total);
            this.Controls.Add(this.txt_paid_Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_sgender);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_sgender;
        private System.Windows.Forms.TextBox txt_ino;
        private System.Windows.Forms.Label lbl_ino;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txtbookpr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cusno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sub_tot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Pay_Type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_paid_Amount;
        private System.Windows.Forms.TextBox txt_G_Total;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save_print;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_Av_Stock;
        private System.Windows.Forms.TextBox txt_Refund;
        private System.Windows.Forms.TextBox txt_cno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.Button DISSS;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}