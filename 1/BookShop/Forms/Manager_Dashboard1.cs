using BookShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Manager_Dashboard1 : Form

    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
      

        public Manager_Dashboard1()
        {
            InitializeComponent();
           random = new Random();
           btnCloseChildForm.Visible = false;
          this.Text = string.Empty;
            this.ControlBox = false;//bodermain
             this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
       [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
       private extern static void ReleaseCapture();
       [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                     panelTitleBar.BackColor = color;
                     panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                      ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true; ;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Btnbook_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new BookRegister(), sender);
        }

        private void Btncus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer_Registration(), sender);
        }

        private void Btnsup_Click(object sender, EventArgs e)
        {
              OpenChildForm(new SupplierForm(), sender);
           // OpenChildForm(new Customer_Registration(), sender);
        }

        private void Btnuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserRegistor(), sender);
        }

        private void Btnpo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Purshase_Order(), sender);
        }

        private void Btninvoice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice(), sender);
        }

        private void Btnrepot_Click(object sender, EventArgs e)
        {
            

           OpenChildForm(new Reports(), sender);
            System.Diagnostics.Process.Start("C:\\REPORT_CONFIGURATION_FILES\\bin\\Debug\\Reports.exe");
        }

        private void Btnset_Click(object sender, EventArgs e)
        {
           OpenChildForm(new SettingsPanal(), sender);
        }

        private void Assistant_Dashboard2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void BtnClosechilform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
           
            Reset();
        }

        private  void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;

        }

        private void PanelDesktopPane_Paint(object sender, PaintEventArgs e)
        {
            lbldt.Text = DateTime.Now.ToString();
        }

        private void Lbldt_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            login123 lg = new login123();
            this.Hide();
            lg.Show();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;


        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           /* ReleaseCapture();
            SendMessage(this.Handle,0)*/
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
