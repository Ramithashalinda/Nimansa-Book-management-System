using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.com.nimansa.validation
{
    class BookFormValidation
    {
        public Boolean validateRegistorForm(TextBox txt_sid, TextBox txt_bookname, TextBox txtbookau, TextBox txt_price, TextBox txt_quantity)
        {

            if (String.IsNullOrWhiteSpace(txt_sid.Text) || string.IsNullOrWhiteSpace(txt_bookname.Text) || string.IsNullOrWhiteSpace(txtbookau.Text) || string.IsNullOrWhiteSpace(txt_price.Text) || string.IsNullOrWhiteSpace(txt_quantity.Text))
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
