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
using BookShop.com.nimansa.db.configeration;

namespace BookShop
{
    public partial class SettingsPanal : Form
    {
        
        public SettingsPanal()
        {
            InitializeComponent();
          
           
        }
        public void setCusNo(string id)
        {
            
        }
   

        private void Customer_Orders_Load(object sender, EventArgs e)
        {
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

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\NIMANSABOOKS_CONFIGURATION_FILES\\DatabseBackUpScript.vbs");
        }
 

       

        private void Label1_Click(object sender, EventArgs e)
        {

        }

     

    }
}
