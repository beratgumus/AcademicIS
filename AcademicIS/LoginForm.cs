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

        public LoginForm()
        {
            InitializeComponent();
            background.Image = AcademicIS.Properties.Resources.login;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (XmlHelper.isAdmin(usernameTB.Text, passwordTB.Text))
            {
                ((MainForm)MdiParent).HideLoginButton();
            }
            else
            {
                alertBox.Visible = true;
                alertBox.Show();
            }
            
        }
    }
}
