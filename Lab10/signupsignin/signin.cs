using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace signupsignin
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string p = textBox2.Text;

            MUser user = MUserDL.CheckUser(n, p);
            if (user != null)
            {
                MessageBox.Show("Welcome " + user.Name + "! Your role is " + user.Role);
            }
            else
            {
                MessageBox.Show("Invalid User. Please register first.");
            }
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }
    }
}
