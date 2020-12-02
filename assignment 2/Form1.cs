using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                double volume = (length * width * height);
                label4.Text = "volume=" + volume;
            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {//reading from each textbox
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                //doing the calculation
                double volume = (length * width * height);
                //shows the answer in the volume textbox
                label4.Text = "volume=" + volume;

            }
            catch
            {
                MessageBox.Show("Error on input");
            }
            try
            {//reading from the textbox
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                //doing the calculation
                double surfacearea = 2.0 * (length * height + length * width + width * height);
                //shows the answer for surface area
                label5.Text = "SA=" + surfacearea;

            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox4.Text);
                double surfacearea = 4.0 * Math.PI * (radius * radius);
                label6.Text = "surface area=" + surfacearea;
            }


            catch
            {
                MessageBox.Show("Error on input");

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Radius = double.Parse(textBox4.Text);
            double Volume = 4.0 / 3.0 * (Math.PI * (Radius * Radius * Radius));
            label7.Text = "Volume" + Volume;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double Radius = double.Parse(textBox5.Text);
            double height = double.Parse(textBox6.Text);
            double Surfacearea = Math.PI * Radius * (Radius + Math.Sqrt((height * height) + (Radius * Radius)));
            label9.Text = "surface area" + Surfacearea;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double Radius = double.Parse(textBox5.Text);
            double Height = double.Parse(textBox6.Text);
            double Volume = 1.0 / 3.0 * Math.PI * (Radius * Radius) * Height;
            label10.Text = "|Volume=" + Volume;
        }
    }
       
}
 
