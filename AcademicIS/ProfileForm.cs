using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS {
    public partial class ProfileForm : Form {

        Academician ac;
        bool editButtonVisibility=false;
        bool deleteButtonVisibility=false;
        /// <summary>
        /// Create profile of academican with given id
        /// </summary>
        /// <param name="id">id number of academican</param>
        public ProfileForm(int id, bool isAdminLoggedIn) {
            InitializeComponent();
            image.Image = AcademicIS.Properties.Resources.profile1;

            if (isAdminLoggedIn)
            {
                editButton.Visible = true;
                editButtonVisibility = true;
                deleteButton.Visible = true;
                deleteButtonVisibility = true;


            } 

            DbHelper db = new DbHelper();
            ac = db.GetAcademician(id);

            nameLabel.Text = ac.Name;
            facultyLabel.Text = ac.Faculty;
            departmentLabel.Text = ac.Department;

            mailLabel.Text = ac.Mail;
            telLabel.Text = ac.Phone;
            webLabel.Text = ac.Website;

            detailsRTB.Rtf = ac.Detail_RTF;

        }

        public bool GetEditButtonVisibility()
        {
            return editButtonVisibility;
        }

        public bool GetDeleteButtonVisibility()
        {
            return deleteButtonVisibility;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).menuSearch_Click(sender, e);
            
        }
    }
}
