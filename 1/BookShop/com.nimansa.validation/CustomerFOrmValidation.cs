using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.com.nimansa.validation
{
    class CustomerFormValidation
    {
        public Boolean validateRegistorForm(TextBox txt_fname, TextBox txt_lname, TextBox txt_address, TextBox txt_tp, TextBox txt_email)
        {

            if (String.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_tp.Text) || string.IsNullOrWhiteSpace(txt_email.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean validateupRegistorForm(TextBox txt_fnameup, TextBox txt_lnameup, TextBox txt_addressup,TextBox txt_tpup, TextBox txt_emailup)
        {

            if (String.IsNullOrWhiteSpace(txt_fnameup.Text) || string.IsNullOrWhiteSpace(txt_lnameup.Text) || string.IsNullOrWhiteSpace(txt_addressup.Text)|| string.IsNullOrWhiteSpace(txt_tpup.Text) || string.IsNullOrWhiteSpace(txt_emailup.Text))
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

