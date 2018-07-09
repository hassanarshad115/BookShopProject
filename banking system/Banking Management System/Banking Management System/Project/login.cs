using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    class login : main_class 
    {
        public string read;
        public override void Log(TextBox id, TextBox pincode, ComboBox cbox)
        {
           
           
            if (cbox.SelectedItem.ToString() == "Admin")
            {
                string[] read = File.ReadAllLines("admin login id and pass.txt");
                
                
                for (int i = 0; i < read.Length; i+=1)
                {
                    if (read[i] == id.Text + pincode.Text)
                    {

                        Form2 form2 = new Form2();
                        form2.Show();


                    }
                        
                    else 
                    {
                        MessageBox.Show("Your Account Is Not Exit", "Try Again",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Form1 f1 = new Form1();
                        f1.Show();
                    }

                    

                }


            }
            if (cbox.SelectedItem.ToString() == "Member")
            {
                
               string[] read = File.ReadAllLines(@"Customer.txt");
                int count = 0;
                int i;
                
                
                for (i = 0; i < read.Length; i+=15)
                {
                    if (read[i] == id.Text && read[i + 1] == pincode.Text)
                    {
                        count++;
                        break;
                    }
                }
                if    (count > 0)
                {
                    Form8 form8 = new Form8(id);
                    form8.Show();
                    

                    }

                    else
                    {
                        MessageBox.Show("Your Account Is Not Exit", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
               
                   }


            }

        public override void Customer_Record_Update(TextBox customerid, DataGridView dgv)
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
