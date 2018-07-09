using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Update : main_class
    {
        public override void Customer_Record_Update(TextBox customerid, DataGridView dgv)
        {
           string[] abc = File.ReadAllLines("Customer.txt");
           int count = 0;
           int i;
           for ( i = 0; i < abc.Length; i += 15)
               
           {
               
               if (abc[i] == customerid.Text)
               {
                   count++; 
                   break;

               }
              
               
           }
           if (count > 0)
           {
               dgv.Rows.Add(abc[i], abc[i + 1], abc[i + 2], abc[i + 3], abc[i + 4], abc[i + 5], abc[i + 6], abc[i + 7], abc[i + 8], abc[i + 9], abc[i + 10], abc[i + 11], abc[i + 12], abc[i + 13], abc[i + 14]);
                   
           }
           else
           {
               MessageBox.Show("Your Account is Not Exist","Not Exists",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           
           
        }
        public override void Log(TextBox id, TextBox pincode, ComboBox cbox)
        {
            throw new NotImplementedException();
        }
        public override void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp)
        {
            base.addcustomer(customerid, name, faname, dob, sex, pincode, cellnum, cntry, cit, adress, stret, em, zip, depo, dtp);
        }
        public override void changePinCode(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            throw new NotImplementedException();
        }
        public override void deposit(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            base.deposit(customerid, addamount, prebal, newbal);
        }
        public override void withdrawl(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            base.withdrawl(customerid, addamount, prebal, newbal);
        }
        public override void Account_Detailed(TextBox accountid, TextBox cusname, TextBox faname, TextBox currentbal, TextBox contactnum)
        {
            throw new NotImplementedException();
        }
        public override void ChangePinAP(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            throw new NotImplementedException();
        }
        public override void DeleteAcc(TextBox customerid)
        {
            throw new NotImplementedException();
        }
        public override void Transfer(TextBox accountid, TextBox transferAccountId, TextBox balance)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
