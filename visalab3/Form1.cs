using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace visalab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double r = double.Parse(textBox4.Text);
            double ee = double.Parse(textBox5.Text);


            Body obj;
            obj = new Parallelepiped(a, b, c);

            richTextBox1.Text += "\tПараллелепипед: \n";

            richTextBox1.Text += "Объём: \n";
            richTextBox1.Text += obj.mVolume() + "\n";
            richTextBox1.Text += "Площадь полной поверхности: \n";
            richTextBox1.Text += obj.mAreaSurface() + "\n";

            richTextBox1.Text += "\tШар: \n";
            obj = new Ball(r);

            richTextBox1.Text += "Объём: \n";
            richTextBox1.Text += obj.mVolume() + "\n";
            richTextBox1.Text += "Площадь полной поверхности: \n";
            richTextBox1.Text += obj.mAreaSurface() + "\n";

            richTextBox1.Text += "\tТруба: \n";
            obj = new Pipe(a,b,c,ee);

            richTextBox1.Text += "Объём: \n";
            richTextBox1.Text += obj.mVolume() + "\n";
        }
    }
}
