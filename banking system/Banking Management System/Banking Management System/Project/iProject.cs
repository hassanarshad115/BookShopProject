using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    interface iProject
    {
       void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp);
    }
}
