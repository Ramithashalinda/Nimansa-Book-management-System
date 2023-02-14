namespace BookShop
{
    partial class Purshase_Order
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
            this.btn_email = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_book = new System.Windows.Forms.ComboBox();
            this.cmb_supname = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_email
            // 
            this.btn_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.Location = new System.Drawing.Point(250, 189);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(141, 29);
            this.btn_email.TabIndex = 200;
            this.btn_email.Text = "Send Order to Supplier";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.Btn_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(8, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(211, 20);
            this.txt_email.TabIndex = 199;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 198;
            this.label5.Text = "Supplier Email";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(609, 183);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 35);
            this.btn_delete.TabIndex = 197;
            this.btn_delete.Text = "Remove Item";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(174, 52);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.ReadOnly = true;
            this.txt_sid.Size = new System.Drawing.Size(57, 20);
            this.txt_sid.TabIndex = 196;
            this.txt_sid.TextChanged += new System.EventHandler(this.Txt_sid_TextChanged_1);
            // 
            // txt_bid
            // 
            this.txt_bid.Location = new System.Drawing.Point(568, 52);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.ReadOnly = true;
            this.txt_bid.Size = new System.Drawing.Size(57, 20);
            this.txt_bid.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 192;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 191;
            this.label3.Text = "Book_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 190;
            this.label2.Text = "Publisher ID";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 189;
            this.label1.Text = "Purchase order no";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(568, 96);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(57, 20);
            this.txt_qty.TabIndex = 188;
            this.txt_qty.TextChanged += new System.EventHandler(this.Txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_qty_KeyPress_1);
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(182, 12);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(57, 20);
            this.txt_pno.TabIndex = 187;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(456, 183);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(124, 35);
            this.btn_add.TabIndex = 184;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // cmb_book
            // 
            this.cmb_book.FormattingEnabled = true;
            this.cmb_book.Location = new System.Drawing.Point(568, 10);
            this.cmb_book.Name = "cmb_book";
            this.cmb_book.Size = new System.Drawing.Size(131, 21);
            this.cmb_book.TabIndex = 183;
            this.cmb_book.SelectedIndexChanged += new System.EventHandler(this.Cmb_book_SelectedIndexChanged);
            // 
            // cmb_supname
            // 
            this.cmb_supname.FormattingEnabled = true;
            this.cmb_supname.Location = new System.Drawing.Point(174, 14);
            this.cmb_supname.Name = "cmb_supname";
            this.cmb_supname.Size = new System.Drawing.Size(182, 21);
            this.cmb_supname.TabIndex = 182;
            this.cmb_supname.SelectedIndexChanged += new System.EventHandler(this.Cmb_supname_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbldt);
            this.panel1.Controls.Add(this.txt_pno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 37);
            this.panel1.TabIndex = 204;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(157, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 18);
            this.label16.TabIndex = 217;
            this.label16.Text = ":-";
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Location = new System.Drawing.Point(727, 15);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(71, 13);
            this.lbldt.TabIndex = 206;
            this.lbldt.Text = "date and time";
            this.lbldt.Click += new System.EventHandler(this.Lbldt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 207;
            this.label6.Text = "Publisher Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_adress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_sid);
            this.panel2.Controls.Add(this.cmb_book);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_email);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_supname);
            this.panel2.Controls.Add(this.txt_bid);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Location = new System.Drawing.Point(10, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 230);
            this.panel2.TabIndex = 205;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(534, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 18);
            this.label15.TabIndex = 216;
            this.label15.Text = ":-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(534, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 18);
            this.label14.TabIndex = 215;
            this.label14.Text = ":-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(534, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 18);
            this.label13.TabIndex = 214;
            this.label13.Text = ":-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 18);
            this.label12.TabIndex = 213;
            this.label12.Text = ":-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(143, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 18);
            this.label11.TabIndex = 212;
            this.label11.Text = ":-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(143, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 18);
            this.label10.TabIndex = 211;
            this.label10.Text = ":-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 18);
            this.label9.TabIndex = 207;
            this.label9.Text = ":-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 210;
            this.label8.Text = "Publisher Address";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(174, 89);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.ReadOnly = true;
            this.txt_adress.Size = new System.Drawing.Size(182, 71);
            this.txt_adress.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 208;
            this.label7.Text = "Book Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 322);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(742, 283);
            this.listView1.TabIndex = 206;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "P_Order NO";
            this.columnHeader0.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Name";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publisher Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Publisher Address";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Send Date";
            this.columnHeader5.Width = 100;
            // 
            // Purshase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 487);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Purshase_Order";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.Purshase_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_book;
        private System.Windows.Forms.ComboBox cmb_supname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}