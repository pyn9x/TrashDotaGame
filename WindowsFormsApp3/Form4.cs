using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {

        public Bitmap IronBranch = Resource1.Iron_Branch_icon;
        public Bitmap SpearOfMars = Resource1.Spear_of_Mars_icon; 
        Point branchPosition = new Point(200, 200);
        Point _directiom = new Point(10, 10);
        int count = 0;
        int randX, randY;

        public Form4()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPosision = this.PointToClient(Cursor.Position);

            branchPosition.X += _directiom.X * randX;
            branchPosition.Y += _directiom.Y * randY;

            if (branchPosition.X > 730|| branchPosition.X < 50)
            {
                _directiom.X *= -1;
            }
            if( branchPosition.Y > 400 || branchPosition.Y < 50)
            {
                _directiom.Y *= -1;
            }

            Point bet = new Point(localPosision.X - branchPosition.X, localPosision.Y - branchPosition.Y);
            float distance = (float)Math.Sqrt((bet.X * bet.X) + (bet.Y * bet.Y));

            if (distance < 20)
            {
                count++;
                label1.Text = Convert.ToString(count);
            }

            var handle = new Rectangle(localPosision.X - 44, localPosision.Y - 32, 88, 64);
            var targetRect = new Rectangle(branchPosition.X - 44, branchPosition.Y - 32, 88, 64);
            g.DrawImage(IronBranch, targetRect);
            g.DrawImage(SpearOfMars, handle);

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            timer2.Interval = r.Next(100, 2000);
            randX = r.Next(-1, 2);
            randY = r.Next(-1, 2);

        }
    }
}
