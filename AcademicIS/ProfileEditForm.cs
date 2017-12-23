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
        DbHelper db;

        Academician ac;

        /// <summary>
        /// This constructor will populate form fields with given academician's
        /// data. Use empty constructor when adding new academician.
        /// </summary>
        /// <param name="id">Id of the academician to load</param>
        public ProfileEditForm(Academician _ac) {
            InitializeComponent();
            rtfTools.Renderer = new CustomRenderer(); //for styling purposes
            alertBox.BringToFront();

            db = new DbHelper();
            list = db.GetFacultyAndDepartments();

            foreach (FacDep fac in list.Keys) {
                facultyCB.Items.Add(fac);
            }

            this.ac = _ac;

            if(ac != null) {
                // we will populate form with given academician data
                deleteButton.Visible = true;

                nameTB.Text = ac.Name;
                mailTB.Text = ac.Mail;
                phoneTB.Text = ac.Phone;
                websiteTB.Text = ac.Website;

                //select faculty from faculty list with LINQ
                FacDep fac = list.Keys.Single(f => f.id == ac.Faculty_id);
                facultyCB.SelectedIndex = facultyCB.Items.IndexOf(fac);

                //select department from department list with LINQ
                FacDep dep = list[fac].Single(d => d.id == ac.Deparment_id);
                departmentCB.SelectedIndex = departmentCB.Items.IndexOf(dep);

                if (ac.Detail_RTF.StartsWith(@"{\rtf"))
                    detailRichTB.Rtf = ac.Detail_RTF;
            }
        }

        /// <summary>
        /// This constructor is used when adding new academician
        /// </summary>
        public ProfileEditForm() : this(null) { }

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

        private void saveButton_Click(object sender, EventArgs e) {
            if (nameTB.Text.Length < 3) {
                ShowError("Ad soyad en az 3 karakter olmalı.");
                return;
            }

            if (!mailTB.Text.Contains("@") || !mailTB.Text.Contains(".")
                || mailTB.Text.Length < 5) {
                ShowError("Geçersiz eposta adresi");
                return;
            }

            if(System.Text.RegularExpressions.Regex.IsMatch(phoneTB.Text, @"[a-zA-Z]") ||
                System.Text.RegularExpressions.Regex.IsMatch(phoneTB.Text, @"[^\w+-]") ||
                (phoneTB.Text.Length > 1 && phoneTB.Text.Length < 7)) {
                ShowError("Geçersiz telefon numarası");
                return;
            }

            if(facultyCB.SelectedIndex == -1) {
                ShowError("Bir fakülte seçmediniz.");
                return;
            }

            if (departmentCB.SelectedIndex == -1) {
                ShowError("Bir bölüm seçmediniz.");
                return;
            }

            FacDep fac = (FacDep)facultyCB.SelectedItem;
            FacDep dep = (FacDep)departmentCB.SelectedItem;

            if (ac == null) {
                //Its new academician, lets create it and insert it to db
                ac = new Academician(-1, nameTB.Text, fac.id, fac.name,
                    dep.id, dep.name, mailTB.Text, phoneTB.Text, websiteTB.Text,
                    detailRichTB.Rtf);

                int insertedId = db.InsertAcademician(ac);

                if (insertedId != -1) {
                    //inserted to db successfully, redirect to profile page
                    ((MainForm)MdiParent).ShowProfileForm(insertedId);
                }
                else
                    ShowError("Yeni kayıt eklenirken bir hata oluştu.");
            }
            else {
                //create new academician with updated fields
                Academician _ac = new Academician(ac.Id, nameTB.Text, fac.id, fac.name,
                    dep.id, dep.name, mailTB.Text, phoneTB.Text, websiteTB.Text,
                    detailRichTB.Rtf);
               
                bool successful = db.UpdateAcademician(_ac);
                if (successful)
                    ((MainForm)MdiParent).ShowProfileForm(_ac.Id);
                else
                    ShowError("Kayıt güncellenirken bir hata oluştu.");
            }
        }

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

        private void cancelButton_Click(object sender, EventArgs e) {
            if(ac == null)
                ((MainForm)MdiParent).menuSearch_Click(sender, e);
            else
                ((MainForm)MdiParent).ShowProfileForm(ac.Id);
        }

        private void ShowError(string message) {
            alertBox.Text = message;
            alertBox.Visible = true;
        }


        private void phoneTB_TextChanged(object sender, EventArgs e) {
            char pressed = phoneTB.Text[phoneTB.Text.Length - 1];
            string revert;
            if (phoneTB.Text.Length > 0)
                revert = phoneTB.Text.Substring(0, phoneTB.Text.Length - 1);
            else
                revert = "";

            if (!char.IsDigit(pressed) && (pressed != '+' || pressed != '-'))
                phoneTB.Text = revert;

            if((pressed == '+' || pressed == '-') && phoneTB.Text.Length > 0)
                phoneTB.Text = revert;

        }

        private void deleteButton_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show("Bu akademisyeni silmek istediğinize emin misiniz?",
                "Silme İşlemini Onayla", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) {
                db.DeleteAcademician(ac.Id);
                ((MainForm)MdiParent).menuSearch_Click(sender, e);
            }
        }
    }
}
