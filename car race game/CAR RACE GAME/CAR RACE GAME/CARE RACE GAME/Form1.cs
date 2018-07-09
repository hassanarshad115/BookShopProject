using System;
using System.Text;
using System.Windows.Forms;

namespace CARE_RACE_GAME
{
    public partial class Form1 : Form
    {
        Random r;//cars move randomly


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Start();


            r = new Random();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          //  bool scor = false;
            


            pictureBox8.Top += 1; //white line
            pictureBox9.Top += 1; //white line
            pictureBox10.Top += 1; //white line

            pictureBox12.Top += 1;
            pictureBox13.Top += 1;
            pictureBox14.Top += 1;
            pictureBox15.Top += 1;
            pictureBox16.Top += 1;//police car
          //  Random random = new Random();

            if (pictureBox8.Top == 400)
            {
                pictureBox8.Top = -46;
            }
            if (pictureBox9.Top == 400)
            {
                pictureBox9.Top = -46;
            }
            if (pictureBox10.Top == 400)
            {
                pictureBox10.Top = -46;
            }/////////////////////////
            //////////////////////////////





            // Putting enemies into PictureBox Array.
            //PictureBox[] oppositecar;
            //oppositecar = new PictureBox[8]; // Array was initilized as Globle Variable.
            //oppositecar[0] = pictureBox12;
            //oppositecar[0] = pictureBox13;
            //oppositecar[0] = pictureBox14;
            //oppositecar[0] = pictureBox15;
            //oppositecar[0] = pictureBox16;


            //for (int i = 0; i < oppositecar.Length; i++)
            //{
            //    if (oppositecar[i].Top > 440) //This is the short code of "Enimies move to top."
            //    {
            //        oppositecar[i].Visible = true;
            //        oppositecar[i].Top = random.Next(-600, -400);
            //        oppositecar[i].Left = random.Next(1, 700);
            //    } //Short code for "Enimies move to top." ends here

            //    for (int j = 0; j < oppositecar.Length; j++) //If collision occurred among Enimies.
            //    {
            //        if (oppositecar[i].Bounds.IntersectsWith(oppositecar[j].Bounds))
            //        {
            //            if (oppositecar[i] != oppositecar[j])
            //            {
            //                oppositecar[j].Top = random.Next(-45, -35);
            //                oppositecar[j].Left = random.Next(1, 200);
            //            }
            //        }
            //    }
            //}


            //cars collision
            if (pictureBox12.Top == 440)
            {
                // pictureBox12.Top = -48;
                Collision(pictureBox12);

            }
            if (pictureBox13.Top == 470)
            {
                // pictureBox13.Top = -50;
                Collision(pictureBox13);
                int Score = Convert.ToInt32(label2.Text);
                Score = Score + 5;
                label2.Text = Score.ToString("00");
              //  scor = tru


            }
            if (pictureBox14.Top == 550)
            {
                // pictureBox14.Top = -55;
                Collision(pictureBox14);
                int Score = Convert.ToInt32(label2.Text);
                Score = Score + 5;
                label2.Text = Score.ToString("00");
             


            }
            if (pictureBox15.Top == 600)
            {
                // pictureBox15.Top = -40;
                Collision(pictureBox15);
                int Score = Convert.ToInt32(label2.Text);
                Score = Score + 5;
                label2.Text = Score.ToString("00");
           

            }
            //police car
            if (pictureBox16.Top == 390)
            {
                pictureBox16.Top = r.Next(-45, -35);
                pictureBox16.Left = r.Next(1, 190);
                int Score = Convert.ToInt32(label2.Text);
                Score = Score + 5;
                label2.Text = Score.ToString("00");
               

            }

            ///////my car code
            if (pictureBox11.Bounds.IntersectsWith(pictureBox12.Bounds)
              || pictureBox11.Bounds.IntersectsWith(pictureBox13.Bounds)
              || pictureBox11.Bounds.IntersectsWith(pictureBox14.Bounds)
              || pictureBox11.Bounds.IntersectsWith(pictureBox15.Bounds)
              || pictureBox11.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                if (pictureBox11.Bounds.IntersectsWith(pictureBox16.Bounds))
                {

                    timer3.Stop();

                    MessageBox.Show("Busted"+" your score is "+label2.Text);

                }

                else
                {
                    timer3.Stop();

                    MessageBox.Show("Game Over yara"+" your score is "+label2.Text);
                }

            }

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            // my car  moves by arrow keys:

            if (e.KeyData == Keys.Right)
            {
                if (pictureBox11.Location.X <= 324)
                {
                    pictureBox11.Left += 5;
                }
            }
            if (e.KeyData == Keys.Right)
            {
                if (pictureBox18.Location.X <= 324)
                {
                    pictureBox18.Left += 5;
                }
            }

            if (e.KeyData == Keys.Left)
            {
                if (pictureBox11.Location.X > 0)
                {
                    pictureBox11.Left -= 5;
                }
            }


        }
        // method cars move randomly 
        public void Collision(PictureBox pic)
        {
            pic.Top = r.Next(-45, -35);
            pic.Left = r.Next(1, 300);


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }





       


    }
}
