using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Windows.Forms;

namespace BookShop.com.nimansa.validation
{
    class UserFormValidation
    {
        public  Boolean validateRegistorForm(TextBox txt_userid, TextBox txt_fname, TextBox txt_lname, TextBox txt_address, TextBox txt_tp, TextBox txt_email, ComboBox comboBox1, TextBox txt_createpw,TextBox txt_conformpw)

        {
            if (String.IsNullOrWhiteSpace(txt_userid.Text) || string.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_email.Text)|| string.IsNullOrWhiteSpace(comboBox1.Text)|| string.IsNullOrWhiteSpace(txt_createpw.Text) || string.IsNullOrWhiteSpace(txt_conformpw.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
