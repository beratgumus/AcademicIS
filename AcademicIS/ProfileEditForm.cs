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
    public partial class ProfileEditForm : Form {

        Dictionary<FacDep, List<FacDep>> list;

        public ProfileEditForm() {
            InitializeComponent();
            rtfTools.Renderer = new CustomRenderer(); //for styling purposes

            DbHelper db = new DbHelper();
            list = db.GetFacultyAndDepartments();

            foreach (FacDep fac in list.Keys) {
                facultyCB.Items.Add(fac);
            }

        }

        private void saveButton_Click(object sender, EventArgs e) {
            var a = detailRichTB.Rtf;
        }

        #region RichTextBox tool menu styling classes
        private class CustomRenderer : ToolStripProfessionalRenderer {
            public CustomRenderer() : base(new CustomColorTable()) { }
        }

        private class CustomColorTable : ProfessionalColorTable {
            public override Color MenuStripGradientBegin {
                get { return Color.FromArgb(38, 174, 114); }
            }
            public override Color MenuStripGradientEnd {
                get { return Color.FromArgb(26, 140, 70); }
            }
            public override Color MenuItemSelectedGradientBegin {
                get { return Color.FromArgb(38, 174, 114); }
            }
            public override Color MenuItemSelectedGradientEnd {
                get { return Color.FromArgb(26, 140, 70); }
            }
            public override Color MenuItemBorder {
                get { return Color.Transparent; }
            }
            public override Color OverflowButtonGradientBegin {
                get { return Color.Transparent; }
            }
            public override Color OverflowButtonGradientEnd {
                get { return Color.Transparent; }
            }
            public override Color OverflowButtonGradientMiddle {
                get { return Color.Transparent; }
            }
            public override Color ToolStripBorder {
                get { return Color.Transparent; }
            }
            public override Color MenuBorder {
                get { return Color.Transparent; }
            }

        }
        #endregion

        #region RichTextBox Tool menu functions
        private void makeBold_Click(object sender, EventArgs e) {
            Font selection = detailRichTB.SelectionFont;

            FontStyle style;
            if (selection.Bold)
                style = FontStyle.Regular;
            else
                style = FontStyle.Bold;

            detailRichTB.SelectionFont = new Font(selection.Name, selection.Size, style);
            
        }

        private void increaseSize_Click(object sender, EventArgs e) {
            ChangeFontSize(1);
        }

        private void decreaseSize_Click(object sender, EventArgs e) {
            ChangeFontSize(-1);
        }

        /// <summary>
        /// Adds given value to font size. for positive values, font size
        /// will be increased.
        /// </summary>
        /// <param name="diff">positive or negative difference</param>
        private void ChangeFontSize(float diff) {
            Font selection = detailRichTB.SelectionFont;

            if (diff < 0) {
                if (selection.Size <= 10F) //we dont want too small fonts too
                    return;
            } else {
                if (selection.Size >= 16F) //we dont want too big fonts
                    return;
            }

            FontStyle style;
            if (selection.Bold)
                style = FontStyle.Bold;
            else if (selection.Underline)
                style = FontStyle.Underline;
            else
                style = FontStyle.Regular;

            detailRichTB.SelectionFont = new Font(selection.Name, selection.Size + diff, style);
        }

        private void insertBullet_Click(object sender, EventArgs e) {
            //detailRichTB.
            detailRichTB.SelectionBullet = !detailRichTB.SelectionBullet;
        }

        private void underline_Click(object sender, EventArgs e) {
            Font selection = detailRichTB.SelectionFont;

            FontStyle style;
            if (selection.Underline)
                style = FontStyle.Regular;
            else
                style = FontStyle.Underline;
            
            detailRichTB.SelectionFont =  new Font(selection.Name, selection.Size, style);
        }
        #endregion

        private void facultyCB_SelectedIndexChanged(object sender, EventArgs e) {
            if (!departmentCB.Enabled)
                departmentCB.Enabled = true;
            else
                departmentCB.Items.Clear();

            var depList = list[(FacDep)facultyCB.SelectedItem];

            foreach (FacDep dep in depList) {
                departmentCB.Items.Add(dep);
            }

        }

        private void departmentCB_SelectedIndexChanged(object sender, EventArgs e) {
            var selected = facultyCB.SelectedItem;
            var sel2 = departmentCB.SelectedItem;
        }
    }
}
