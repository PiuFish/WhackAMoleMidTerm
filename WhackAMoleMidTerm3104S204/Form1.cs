using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMoleMidTerm3104S204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddScore(int score)
        {
            int currentScore = int.Parse(lblScore.Text);
            currentScore = currentScore + score;
            lblScore.Text = currentScore.ToString();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)Bitmap.FromFile("ttt.png");
            this.Cursor = new Cursor(bitmap.GetHicon());

            this.BackgroundImage = Image.FromFile("Background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Size = new Size(1024, 768);


            Gopher gopher1 = new Gopher(new Point(185, 158), new Size(125, 140), 1, this);
            Gopher gopher2 = new Gopher(new Point(418, 157), new Size(125, 140), 2, this);
            Gopher gopher3 = new Gopher(new Point(666, 165), new Size(125, 140), 3, this);
            Gopher gopher4 = new Gopher(new Point(144, 299), new Size(125, 140), 4, this);
            Gopher gopher5 = new Gopher(new Point(421, 301), new Size(125, 140), 5, this);
            Gopher gopher6 = new Gopher(new Point(667, 294), new Size(125, 140), 6, this);
            Gopher gopher7 = new Gopher(new Point(135, 444), new Size(125, 140), 7, this);
            Gopher gopher8 = new Gopher(new Point(417, 453), new Size(125, 140), 8, this);
            Gopher gopher9 = new Gopher(new Point(696, 453), new Size(125, 140), 9, this);
        }


    }
}
