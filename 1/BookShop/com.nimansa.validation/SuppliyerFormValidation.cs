using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.com.nimansa.val
{
    class SuppliyerFormValidation
    {
        public Boolean validateRegistorForm(TextBox txt_sid, TextBox txt_supname, TextBox txt_add, TextBox txt_tp, TextBox txt_email)
        {

            if (String.IsNullOrWhiteSpace(txt_sid.Text) || String.IsNullOrWhiteSpace(txt_supname.Text) || string.IsNullOrWhiteSpace(txt_add.Text) || string.IsNullOrWhiteSpace(txt_tp.Text) || string.IsNullOrWhiteSpace(txt_email.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean validateupRegistorForm(TextBox txt_snamup, TextBox txt_addup, TextBox txt_tpup, TextBox txt_emailup)
        {

            if (String.IsNullOrWhiteSpace(txt_snamup.Text) || string.IsNullOrWhiteSpace(txt_addup.Text) || string.IsNullOrWhiteSpace(txt_tpup.Text) || string.IsNullOrWhiteSpace(txt_emailup.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
            return false;
        }

    }
}
