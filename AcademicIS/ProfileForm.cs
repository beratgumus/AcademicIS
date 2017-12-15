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

        /// <summary>
        /// Create profile of academican with given id
        /// </summary>
        /// <param name="id">id number of academican</param>
        public ProfileForm(int id) {
            InitializeComponent();
            image.Image = AcademicIS.Properties.Resources.profile1;

            DbHelper db = new DbHelper();
            DataRow academician = db.GetAcademician(id);
        }

    }
}
