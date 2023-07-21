using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineeringmanagement2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(textUser.Text == "sammy" && textPass.Text == "usee")
            {
                MDIParent1 mDIParent = new MDIParent1();
                mDIParent.Show();
            }
            else
            {
                MessageBox.Show("Wrong password!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
