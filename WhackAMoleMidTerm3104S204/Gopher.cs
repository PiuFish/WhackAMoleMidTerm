using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMoleMidTerm3104S204
{
    class Gopher
    {
        PictureBox picGopher = null;
        Random rnd = null;
        Random rndSize = null;
        Timer showTimer = null;
        Form1 myMainForm = null;
        int iScore = 1;
        int seedScore = 0;
        Point plocation = new Point(0, 0);

        private bool moleWhacked = false;

        public Gopher(Point location, Size size, int seed, Form1 mainForm)
        {
            myMainForm = mainForm;
            rnd = new Random(seed);
            rndSize = new Random(seed);
            plocation = location;
            picGopher = new PictureBox();
            picGopher.Image = Image.FromFile("mm.png");
            picGopher.SizeMode = PictureBoxSizeMode.StretchImage;
            picGopher.BackColor = Color.Transparent;
            picGopher.Location = location;
            picGopher.Size = size;
            picGopher.Visible = false;
            picGopher.Click += PicGopher_Click;
            mainForm.Controls.Add(picGopher);

            showTimer = new Timer();
            showTimer.Interval = rnd.Next(1500, 3000); //0.5秒到3秒
            showTimer.Tick += ShowTimer_Tick;
            showTimer.Enabled = true;


        }

        private async void PicGopher_Click(object sender, EventArgs e)
        {
            if (!moleWhacked)
            {
                picGopher.Image = Image.FromFile("main_KO.png");
                myMainForm.AddScore(iScore);
                await Task.Delay(150);
                picGopher.Visible = false;
                picGopher.Image = Image.FromFile("mm.png");
            }
        }


        private void ShowTimer_Tick(object sender, EventArgs e)
        {

            seedScore = rndSize.Next(1, 101);


            if (seedScore >= 86 && seedScore <= 100) //加分小型 15%
            {
                picGopher.Image = Image.FromFile("mm.png");
                picGopher.Height = 70;
                picGopher.Width = 62;
                picGopher.Location = new Point(plocation.X + 40, plocation.Y + 65);
                showTimer.Interval = rnd.Next(400, 800);
                iScore = 10;

            }
            else if (seedScore >= 61 && seedScore <= 85) //加分中型 20%
            {
                picGopher.Image = Image.FromFile("mm.png");
                picGopher.Height = 100;
                picGopher.Width = 95;
                picGopher.Location = new Point(plocation.X + 25, plocation.Y + 35);
                showTimer.Interval = rnd.Next(1000, 1500);
                iScore = 5;
            }

            else if (seedScore >= 51 && seedScore <= 60) //扣分大型 10%
            {
                picGopher.Image = Image.FromFile("mm2.png");
                picGopher.Height = 100;
                picGopher.Width = 95;
                picGopher.Location = new Point(plocation.X + 25, plocation.Y +35);
                showTimer.Interval = rnd.Next(1000, 1500);
                iScore = -5;
            }
            else if (seedScore >= 46 && seedScore <= 50) //扣分小型 5%
            {
                picGopher.Image = Image.FromFile("mm2.png");
                picGopher.Height = 70;
                picGopher.Width = 62;
                picGopher.Location = new Point(plocation.X + 31, plocation.Y + 60);
                iScore = -10;

            }
            else if (seedScore >= 36 && seedScore <= 45) //加分特殊型 10%
            {
                picGopher.Image = Image.FromFile("mm3.png");
                picGopher.Height = 70;
                picGopher.Width = 62;
                picGopher.Location = new Point(plocation.X + 40, plocation.Y + 65);
                showTimer.Interval = rnd.Next(400, 800);
                iScore = 20;
            }
            else//加分正常 35%
            {
                picGopher.Image = Image.FromFile("mm.png");
                picGopher.Height = 170;
                picGopher.Width = 150;
                picGopher.Location = new Point(plocation.X - 15, plocation.Y - 30);
                iScore = 1;
            }

            if (picGopher.Visible == true)
            {
                picGopher.Visible = false;
            }
            else
            {
                picGopher.Visible = true;
            }


        }
    }
}
