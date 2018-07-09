using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public abstract class main_class
    {
        public abstract void Log(TextBox id, TextBox pincode, ComboBox cbox);
        public abstract void Customer_Record_Update(TextBox customerid, DataGridView dgv);
        public virtual void addcustomer(TextBox customerid, TextBox name, TextBox faname, TextBox dob, ComboBox sex, TextBox pincode, TextBox cellnum, TextBox cntry, TextBox cit, TextBox adress, TextBox stret, TextBox em, TextBox zip, TextBox depo, DateTimePicker dtp)
        {
            string[] abc = File.ReadAllLines("Customer.txt");
            int count = 0;
            int i;
            for (i = 0; i < abc.Length; i++)
            {
                if (abc[i] == customerid.Text)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                MessageBox.Show("Your Account No is Already Exists \n Plz Change Your Account No","Already Exists",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                StreamWriter sw = new StreamWriter("Customer.txt", true);
                MessageBox.Show("Registration Confirmed");
                sw.WriteLine(customerid.Text);
                sw.WriteLine(pincode.Text);
                sw.WriteLine(name.Text);
                sw.WriteLine(faname.Text);
                sw.WriteLine(dob.Text);
                sw.WriteLine(sex.Text);
                sw.WriteLine(cellnum.Text);
                sw.WriteLine(cntry.Text);
                sw.WriteLine(cit.Text);
                sw.WriteLine(adress.Text);
                sw.WriteLine(stret.Text);
                sw.WriteLine(em.Text);
                sw.WriteLine(zip.Text);
                sw.WriteLine(depo.Text);
                sw.WriteLine(dtp.Text);
                sw.Close();


            }

        }
        
        public virtual void deposit(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            string[] xyz = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < xyz.Length; i += 15)
            {
                if (xyz[i] == customerid.Text)
                {
                    double add = Convert.ToDouble(addamount.Text);
                    double a = add + Convert.ToDouble(xyz[i + 13]);
                    prebal.Text = xyz[i + 13].ToString();
                    newbal.Text = a.ToString();
                    xyz[i + 13] = a.ToString();
                    MessageBox.Show("Your Deposit Process is Successfull","Sucessfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                }
            }
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < xyz.Length; i++)
            {

                wr.WriteLine(xyz[i], true);

            }
            wr.Close();
        }
        public virtual void withdrawl(TextBox customerid, TextBox addamount, TextBox prebal, TextBox newbal)
        {
            string[] xyz = File.ReadAllLines("Customer.txt");
            for (int i = 0; i < xyz.Length; i += 15)
            {
                if (xyz[i] == customerid.Text)
                {
                    double sub = Convert.ToDouble(addamount.Text);
                    double a = Convert.ToDouble(xyz[i + 13]) - sub;
                    prebal.Text = xyz[i + 13].ToString();
                    newbal.Text = a.ToString();
                    xyz[i + 13] = a.ToString();
                    MessageBox.Show("Your Withdrawl Process is Successfull","Sucessfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                }
            }
            StreamWriter wr = new StreamWriter("Customer.txt");
            for (int i = 0; i < xyz.Length; i++)
            {

                wr.WriteLine(xyz[i], true);

            }
            wr.Close();

        }
        public abstract void changePinCode(TextBox accountid, TextBox prepin, TextBox newpin);
        public abstract void ChangePinAP(TextBox accountid, TextBox prepin, TextBox newpin);
        public abstract void Account_Detailed(TextBox accountid, TextBox cusname, TextBox faname, TextBox currentbal, TextBox contactnum);
        public abstract void DeleteAcc(TextBox customerid);
        public abstract void Transfer(TextBox accountid, TextBox transferAccountId, TextBox balance);
    
        }
    }
