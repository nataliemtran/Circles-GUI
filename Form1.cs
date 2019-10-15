using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number3finalpartA
{
    public partial class Form1 : Form
    {
        private int numberofcircles;
        private Pen drawPen;

        public object Paintcircles { get; private set; }

        public Form1()
        {
            InitializeComponent();
            numberofcircles = 0;
            drawPen = new Pen(Color.Black);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: drawPen = new Pen(Color.Teal); break;
                case 1: drawPen = new Pen(Color.IndianRed); break;
                case 2: drawPen = new Pen(Color.Lavender); break;
                case 3: drawPen = new Pen(Color.Green); break;
                case 4: drawPen = new Pen(Color.Orange); break;
                case 5: drawPen = new Pen(Color.Ivory); break;
            }
        }*/


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: drawPen = new Pen(Color.Black); break;
                case 1: drawPen = new Pen(Color.IndianRed); break;
                case 2: drawPen = new Pen(Color.Lavender); break;
                case 3: drawPen = new Pen(Color.Green); break;
                case 4: drawPen = new Pen(Color.Orange); break;
                case 5: drawPen = new Pen(Color.Ivory); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGraphics().Clear(ActiveForm.BackColor);
            Graphics drawCircs = CreateGraphics();
            int Val = 0;
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Warning! Please enter an integer, text box seems to be empty.");
            }
            else if (!int.TryParse(textBox1.Text, out Val))
            {
                MessageBox.Show("Warning! Enter an integer.");
            }
            else
            {
                numberofcircles = Convert.ToInt32(textBox1.Text);
                PaintCircles(drawCircs);
                
            }
        }

        private void PaintCircles(Graphics circle)
        {
            double theta = 0, pi = 4 * Math.Atan(1); //angle
            int x = (int)(100 + (40 * Math.Cos(theta)));
            int y = (int)(100 + (40 * Math.Sin(theta)));
            int d = 80; //diameter of the circle

            for (int i = 0; i < numberofcircles; i++)
            {
                circle.DrawEllipse(drawPen, x, y, d, d);

                theta += pi / 180 * (360.0 / numberofcircles);

                x = (int)(100 + (40 * Math.Cos(theta)));
                y = (int)(100 + (40 * Math.Sin(theta)));
            }

        }

        /*private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Graphics circle = Color.Green;
        }*/
            
    }
}


