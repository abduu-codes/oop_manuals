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

namespace signupsignin
{
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string pass = textBox2.Text;
            string r = textBox3.Text;
            MUser newUser = new MUser(n, pass, r);
            MUserDL.StoreUserInFile(newUser);
            MUserDL.LoadUsersFromFile(); 
            MessageBox.Show("Registration Successful!");
            this.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void signupform_Load(object sender, EventArgs e)
        {

        }
    }
}
