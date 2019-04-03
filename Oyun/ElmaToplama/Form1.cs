using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElmaToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lblSayac.Text = sayac.ToString();
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right)
            {
                x += 5;
                
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= 5;
                
            }
            if (e.KeyCode == Keys.Down)
            {
                y += 5;
               
            }
            if (e.KeyCode==Keys.Left)
            {
                x -= 5;
            }
            pictureBox1.Location = new Point(x, y);
            if (pictureBox1.Bounds.IntersectsWith(pctElma.Bounds)==true)
            {
                sayac++;
                elmaX = rnd.Next(50, 600);
                elmaY = rnd.Next(40, 350);
                pctElma.Location = new Point(elmaX, elmaY);

            }
        }
        int elmaX, elmaY;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private int counter = 60;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            elmaX = rnd.Next(50, 600);
            elmaY = rnd.Next(40, 350);
            pctElma.Location = new Point(elmaX, elmaY);
            int counter = 60;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; 
            timer1.Start();
            lblSure.Text = counter.ToString();
            btnBasla.Enabled = false;
            btnCik.Enabled = false;
            
        }

        private void btnCik_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)                
            timer1.Stop();
            lblSure.Text = counter.ToString();
            if (lblSure.Text == "0")
            {
                MessageBox.Show("Oyun Süreniz bitmiştir!!");
                btnCik.Enabled = true;
                btnBasla.Enabled = true;
            }


        }
    }
}
