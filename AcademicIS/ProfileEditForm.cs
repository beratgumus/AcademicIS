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

        public ProfileEditForm() {
            InitializeComponent();
        }

        private void makeBold_Click(object sender, EventArgs e) {
            Font selection = detailRichTB.SelectionFont;

            if (selection.Bold)
                detailRichTB.SelectionFont = new Font(selection.Name, selection.Size, FontStyle.Regular);
            else
                detailRichTB.SelectionFont = new Font(selection.Name, selection.Size, FontStyle.Bold);
        }

        private void increaseSize_Click(object sender, EventArgs e) {
            ChangeFontSize(1);
        }

        private void decreaseSize_Click(object sender, EventArgs e) {
            ChangeFontSize(-1);
        }

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
            else
                style = FontStyle.Regular;

            detailRichTB.SelectionFont = new Font(selection.Name, selection.Size + diff, style);
        }
    }
}
