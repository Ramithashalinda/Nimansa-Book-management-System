using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BookShop
{
    public partial class SendCode : Form
    {

        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string form, pass, messagebody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            form = "ramithashalinda99@gmail.com";
            pass = "Ramitha@1999";
            messagebody = "Your reset code is" + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(form);
            message.Body = messagebody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(form, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
             if(randomCode==(txtVerCode.Text).ToString())
             {
                 to = txtemail.Text;
                 ResetPassword rp = new ResetPassword(txtemail.Text);
                 this.Hide();
                 rp.Show();
             }
             else
             {
               
                MessageBox.Show("Worng code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SendCode_Load(object sender, EventArgs e)
        {

        }
    }
}
