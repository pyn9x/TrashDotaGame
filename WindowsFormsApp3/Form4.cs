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
        Point _directiom = new Point(13, 13);
        int count = 0;

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

            //Random r = new Random();
            //Point rand = new Point(r.Next(1, 3), r.Next(1, 3));
            branchPosition.X += _directiom.X;//* rand.X;
            branchPosition.Y += _directiom.Y;//* rand.Y;

            if (branchPosition.X > 725 || branchPosition.X < 0)
            {
                _directiom.X *= -1;
            }
            if( branchPosition.Y > 400 || branchPosition.Y < 0)
            {
                _directiom.Y *= -1;
            }
            var handle = new Rectangle(localPosision.X - 32, localPosision.Y - 32, 88, 64);
            var targetRect = new Rectangle(branchPosition.X - 22, branchPosition.Y - 16, 88, 64);
            g.DrawImage(IronBranch, targetRect);
            g.DrawImage(SpearOfMars, handle);

            if (handle == targetRect)
                count++;
            label1.Text = Convert.ToString(count);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*Random r = new Random();
            timer2.Interval = r.Next(100, 200);
            _directiom.X = r.Next(2, 4);
            _directiom.Y = r.Next(2, 4);*/

        }
    }
}
