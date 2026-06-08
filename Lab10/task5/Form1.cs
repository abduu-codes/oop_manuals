using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "You selected: ";
            if (checkBox1.Checked) 
            { 
                result += "Option 1 ";
            }
            if (checkBox2.Checked) 
            {
                result += "Option 2"; 
            }

            MessageBox.Show(result);
        }
    }
}
