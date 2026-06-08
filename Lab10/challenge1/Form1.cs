using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenge1
{
    public partial class Form1 : Form
    {
        int colorIndex = 0;
        List<Color> myColors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % myColors.Count; 
            textBox1.BackColor = myColors[colorIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorIndex = (colorIndex - 1 + myColors.Count) % myColors.Count;
            textBox1.BackColor = myColors[colorIndex];
        }
    }
}
