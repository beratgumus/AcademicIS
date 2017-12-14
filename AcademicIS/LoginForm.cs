using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AcademicIS
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm(MainForm mF)
        {
            InitializeComponent();
            mainForm = mF;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (XmlHelper.isAdmin(usernameTB.Text, passwordTB.Text))
            {
                MainForm.isAdminLoggedIn = true;
                mainForm.HideLoginButton();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı!");
            }

        }
    }
}
