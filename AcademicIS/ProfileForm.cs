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
        public ProfileForm() {
            InitializeComponent();
            image.Image = AcademicIS.Properties.Resources.profile1;

            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { containerPanel.VerticalScroll.Value = vScrollBar1.Value; };
            //containerPanel.Controls.Add(vScrollBar1);
        }
    }
}
