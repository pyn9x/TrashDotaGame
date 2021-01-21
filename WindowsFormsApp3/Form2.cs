using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        int gold = 0;
        int countBf = 0;
        SoundPlayer sf = new SoundPlayer(Resource1.Hand_of_Midas_mp3);
        SoundPlayer sf1 = new SoundPlayer(Resource1.Battle_Fury_mp3);
        SoundPlayer sf3 = new SoundPlayer(Resource1.coins);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = null;
            if (gold > 0 && gold - 4500 >= 0)
            {
                sf.Play();
                countBf++;
                gold -= 4500;
            }
            else
            {
                sf1.Play();
                label2.Text = "Добей крипа ";
            }
            label1.Text = Convert.ToString(gold);
            label3.Text = Convert.ToString(countBf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gold += 1500;
            label1.Text = Convert.ToString(gold);
            sf3.Play();
        }
    }
}
