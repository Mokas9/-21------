using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_очко
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Random rand = new Random();

        public int score;
        public int computer;
        public int mySchet;
        public int compSchet;
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (computer < 21)
            {
                computer += rand.Next(1, 12);
            }
            else
            {
                computer = Convert.ToInt32(label6.Text);
            }

            if (score < 21)
            {
                score += rand.Next(1, 12);
            }
            else
            {
                score = Convert.ToInt32(label1.Text);
            }

            label1.Text = Convert.ToString(score);
            label6.Text = Convert.ToString(computer);

            if (score > 21 && computer > 21)
            {
                MessageBox.Show("Ничья!");
            }

            if (score > 21)
            {
                MessageBox.Show("Вы проиграли!");
                label10.Text = Convert.ToString(compSchet += 1);
            }

            if (score == 21)
            {
                MessageBox.Show("У вас 21! Вы выйграли!");
                label8.Text = Convert.ToString(mySchet += 1);
            }

            if(computer == 21)
            {
                MessageBox.Show("Вы проиграли. У противника 21!");
                label10.Text = Convert.ToString(compSchet += 1);

            }

            if (computer > 21)
            {
                MessageBox.Show("Вы выйграли!");
                label8.Text = Convert.ToString(mySchet += 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = 0;
            computer = 0;
            label1.Text = "0";
            label6.Text = "0";
        }
    }
}
