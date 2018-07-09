using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    class DeleteAccount : main_class
    {
        public override void DeleteAcc(TextBox customerid)
        {

            string[] abc = File.ReadAllLines("Customer.txt");
            List<string> ss = File.ReadAllLines("Customer.txt").ToList();
            int count = 0;
            int i;
            for (i = 0; i < abc.Length; i += 15)
            {

                if (abc[i] == customerid.Text)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                ss.RemoveAt(i);
                File.WriteAllLines("Customer.txt", ss.ToArray());
                MessageBox.Show("Account is Delete","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }


            else
            {
                MessageBox.Show("Account is Not Exists","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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
        public override void Transfer(TextBox accountid, TextBox transferAccountId, TextBox balance)
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
