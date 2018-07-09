using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class Depositt : main_class,iProject

    {
        private double _sub;
        public double sub
        {
            get { return _sub; }
            set { _sub = value; }
        }

        private double _balance;

        public double balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public override void deposit(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            base.deposit(customerid, addamount, prebal, newbal);
            
           }

        public override void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp)
        {
            base.addcustomer(customerid, name, faname, dob, sex, pincode, cellnum, cntry, cit, adress, stret, em, zip, depo, dtp);
        }

        public override void Customer_Record_Update(TextBox customerid, DataGridView dgv)
        {
            throw new NotImplementedException();
        }
        public override void Log(TextBox id, TextBox pincode, ComboBox cbox)
        {
            throw new NotImplementedException();
        }
        public override void changePinCode(TextBox accountid, TextBox prepin, TextBox newpin)
        {
            throw new NotImplementedException();
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
