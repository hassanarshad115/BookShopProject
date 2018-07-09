using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Transfer_Balance : main_class
    {
        public double a;
        public double bal;
        
        public override void Transfer(TextBox accountid, TextBox transferAccountId, TextBox balance)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < abc.Length; i+=15)
            {
                if (abc[i] == accountid.Text)
                {
                    bal = Convert.ToDouble(balance.Text);
                    a = Convert.ToDouble(abc[i + 13]) - bal;
                    abc[i + 13] = a.ToString();
                   
                    break;

                }
            }
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < abc.Length; i++)
            {

                wr.WriteLine(abc[i], true);

            }
            wr.Close();

            for (int i = 0; i < abc.Length; i += 15)
            {
                if (abc[i] == transferAccountId.Text)
                {
                    bal = Convert.ToDouble(balance.Text);
                    a = Convert.ToDouble(abc[i + 13]) + bal;
                    abc[i + 13] = a.ToString();
                    MessageBox.Show("Your Balance is Transfer","Transfer",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    break;

                }
            }
            StreamWriter wr1 = new StreamWriter("Customer.txt");
            for (int i = 0; i < abc.Length; i++)
            {

                wr1.WriteLine(abc[i], true);

            }
            wr1.Close();

        }
        public override void Account_Detailed(TextBox accountid, TextBox cusname, TextBox faname, TextBox currentbal, TextBox contactnum)
        {
            throw new NotImplementedException();
        }
        public override void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp)
        {
            base.addcustomer(customerid, name, faname, dob, sex, pincode, cellnum, cntry, cit, adress, stret, em, zip, depo, dtp);
        }
        public override void ChangePinAP(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            throw new NotImplementedException();
        }
        public override void changePinCode(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            throw new NotImplementedException();
        }
        public override void Customer_Record_Update(TextBox customerid, DataGridView dgv)
        {
            throw new NotImplementedException();
        }
        public override void DeleteAcc(TextBox customerid)
        {
            throw new NotImplementedException();
        }
        public override void deposit(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            base.deposit(customerid, addamount, prebal, newbal);
        }
        public override void Log(TextBox id, TextBox pincode, ComboBox cbox)
        {
            throw new NotImplementedException();
        }
        public override void withdrawl(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            base.withdrawl(customerid, addamount, prebal, newbal);
        }
    }
}
        

 
        
    

