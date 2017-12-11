using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AcademicIS {
    public partial class MainForm : Form {

        #region fix for draggable window variables
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion

        SearchForm searchForm;
        bool isLoading;

        public MainForm() {
            InitializeComponent();
            menu.Renderer = new CustomRenderer(); // appyle custom styles to menu
            spinner.Image = AcademicIS.Properties.Resources.spinner2;
            isLoading = true;
            searchForm = new SearchForm();
            ActivateChildForm(searchForm);
            delay.Start();
                                    
        }

        #region fix for draggable window functions
        private void MainForm_MouseDown(object sender, MouseEventArgs e) {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e) {
            dragging = false;
        }
        #endregion

        #region menu styling classes
        private class CustomRenderer : ToolStripProfessionalRenderer {
            public CustomRenderer() : base(new CustomColorTable()) { }
        }

        private class CustomColorTable : ProfessionalColorTable {
            public override Color MenuItemSelectedGradientBegin {
                get { return Color.FromArgb(39, 174, 96); }
            }
            public override Color MenuItemSelectedGradientEnd {
                get { return Color.FromArgb(30, 150, 78); }
            }
            public override Color MenuItemBorder {
                get { return Color.Transparent; }
            }
        }
        #endregion
        
        private void FadeOutLoading() {
            if (isLoading) {
                spinner.Hide();
                spinner.SendToBack();
                loadingText.Hide();
                loadingText.SendToBack();
                loading.FadeOut(false);
                isLoading = false;
            }
            
        }

        private void ShowLoading() {
            if (!isLoading) {
                loadingText.Show();
                loading.SetVisible(true);
                spinner.Show();
                spinner.BringToFront();
                loadingText.BringToFront();
                isLoading = true;
            }

        }

        private void ActivateChildForm(Form _newChildForm) {
            foreach (Form frm in this.MdiChildren) {
                if (frm.Text != _newChildForm.Text) {
                    frm.Close();
                    frm.Dispose();
                }
            }
            _newChildForm.MdiParent = this;
            _newChildForm.StartPosition = FormStartPosition.Manual;
            _newChildForm.Location = new Point(0, 70); //offset for custom header
            _newChildForm.Show();
            _newChildForm.Activate();
        }

        private void menuSearch_Click(object sender, EventArgs e) {
            if (searchForm == null || searchForm.IsDisposed) {
                //search form is not initialized yet or its closed
                searchForm = new SearchForm();
            }
            ActivateChildForm(searchForm);
            FadeOutLoading();
        }

        private void menuLogin_Click(object sender, EventArgs e) {
            ShowLoading();
        }

        private void delay_Tick(object sender, EventArgs e) {
            FadeOutLoading();
            delay.Stop();
        }
    }
}
