using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace BookShopProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitapplicationbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();//0
        }

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            //database k lye
            try {
            //sql connection 1
            string connstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString; //connection estaablish klye
            //string type ko connstring veriable lygy fr = k bd ye sb likhna ha testdb hmny connfiguration wali ma add kia ta name
            //uper 2 using add krni ha r refrences ma .net ma configuraiton add krrna ha
            SqlConnection conn = new SqlConnection(connstring);
            //sqlconnection type ka conn obj lna har uuper jo veriable lia ta usko idr add krna ha

            //sql command 2
            SqlCommand cmd = new SqlCommand("AddNewData", conn); //storeprocedure ka name likhna ha
            //sqlcommand type ka cmd obj bnana ha jsymy 2 arguments ly gy phla string second jo sqlconnnection bna ha usko

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ClientName",SqlDbType.NVarChar,50).Value = clientnametextBox.Text; 
            
            cmd.Parameters.Add("@ItemName",SqlDbType.NVarChar,50).Value = itemnamecomboBox.Text;
            
            cmd.Parameters.Add("@Quantity",SqlDbType.NVarChar,50).Value = quantitycomboBox.Text;
            
            cmd.Parameters.Add("@Price",SqlDbType.NVarChar,50).Value = clientnametextBox.Text;

            cmd.Parameters.Add("@TotalToPay",SqlDbType.NVarChar,50).Value = totaltopaytextBox.Text;

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

                  //agr connection thq ha tu nchy wala message chlyga wrna jo uper try kia ta wo  nichy catch yni if else wala kam hogaa
                MessageBox.Show("Add Data Successfully !!");

            }//end try
            catch (Exception ex) //if else wala
            {
                MessageBox.Show("Error agya connection thq ni ha" + ex.Message);
            
            }
          /*  clientnametextBox.Clear();//1
            itemnamecomboBox.SelectedIndex=0; //2
            quantitycomboBox.SelectedIndex=0;//3
            pricetextBox.Clear();//4
            totaltopaytextBox.Clear();//5


            clientnametextBox.Focus();//6
           * */
        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {//7

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice() //7,8 r b ho skty ha q k ye ak method bnadia ha 
        {
            if (quantitycomboBox.Text != "" && pricetextBox.Text != "")
            {

                decimal veriable = decimal.Parse(quantitycomboBox.Text) * decimal.Parse(pricetextBox.Text);
                totaltopaytextBox.Text = veriable.ToString();
            }
            else
            {
                totaltopaytextBox.Text = "0";
            }
        }

        private void itemnamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//8

            UpdateTotalPrice();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //9   url dalny ka method ha ye csharp ma phly link label ly k fr uska txt change kr k fr uspy click kr k ye likhdy url k lye
            System.Diagnostics.Process.Start("http://allice9554.000webhostapp.com/");
        }

        private void printprivewbotton_Click(object sender, EventArgs e)
        {
            //10 print document r print preview document ko toolboox sy nkalny k bad ismy ye code likhna ha
            //awe ha ye dabba r jsmy koi programming na ho wo awe hota ha iski programing nichy add ha dabby ma
          
        }

        private void totaltopaytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printprivewbotton_Click_1(object sender, EventArgs e)
        {//11
            DVprintPreviewDialog.Document = DVprintDocument;
            DVprintPreviewDialog.ShowDialog();

        }

        private void DVprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //ispy double click krna ha to ider ajayga  12

            Bitmap bmp=Properties.Resources.Screenshot_11;
            Image newimage=bmp; 
            e.Graphics.DrawImage(newimage , 25,25,newimage.Width,newimage.Height);

            e.Graphics.DrawString("Client Name: "+ clientnametextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Date: "+ DateTime.Now ,new Font("Arial ",12) , Brushes.Black,new Point(25, 295) );//25 left sy r 270 right sy
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 305));
            e.Graphics.DrawString("Item Description: ", new Font("Arial", 12), Brushes.Black, new Point(25, 330));
            e.Graphics.DrawString("Quantity: ", new Font("Arial", 12), Brushes.Black, new Point(500, 330));
            e.Graphics.DrawString("Price: ", new Font("Arial", 12), Brushes.Black, new Point(700, 330));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 340));


            e.Graphics.DrawString(itemnamecomboBox.Text , new Font("Arial", 12), Brushes.Black, new Point(25, 370));
            e.Graphics.DrawString(quantitycomboBox.Text , new Font("Arial", 12), Brushes.Black, new Point(540, 370));
            e.Graphics.DrawString("Rs."+ pricetextBox.Text, new Font("Arial", 12), Brushes.Black, new Point(700, 370));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 440));


            e.Graphics.DrawString("Total Payment= ", new Font("Arial", 12), Brushes.Black, new Point(28, 470));//right wali rkm uper sy nichy ko lati ha
            e.Graphics.DrawString("Rs." + totaltopaytextBox.Text, new Font("Arial", 12), Brushes.Black, new Point(700, 470));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 500));


            

        }

        private void printingbotton_Click(object sender, EventArgs e)
        {//LAST WORK IN THIS
            DVprintDocument.Print();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hsnmalik.blogspot.com/");
        }

      
    }
}
