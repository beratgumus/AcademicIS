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
        LoginForm loginForm;
        SearchForm searchForm;
        ProfileEditForm editForm;
        public static bool isAdminLoggedIn=false;
        bool isLoading;

        public MainForm() {
            InitializeComponent();
            menu.Renderer = new CustomRenderer(); // appyle custom styles to menu
            spinner.Image = AcademicIS.Properties.Resources.spinner2;
            isLoading = true;
            searchForm = new SearchForm();
            ActivateChildForm(searchForm);
            //ActivateChildForm(new ProfileForm());
            //ActivateChildForm(new ProfileEditForm());
            FadeOutLoading();

            if (!isAdminLoggedIn)
            {
                editAcademcian.Visible = false;
            }
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


        /// <summary>
        /// Fadeout loading screen with default delay (timeout) 
        /// </summary>
        private void FadeOutLoading() {
            FadeOutLoading(200);
        }

        /// <summary>
        /// Fadeout loading screen with custom delay
        /// </summary>
        /// <param name="msDelay">timeout in miliseconds to start fading out</param>
        private void FadeOutLoading(int msDelay) {
            if (isLoading) {
                delay.Interval = msDelay;
                delay.Start();
            }
        }

        /// <summary>
        /// Fade outs loading screen. Intented to use with delay.
        /// Do not use this directly. It may cause visual glitchs.
        /// </summary>
        private void StartFadeOut() {
            spinner.Hide();
            spinner.SendToBack();
            loadingText.Hide();
            loadingText.SendToBack();
            loading.FadeOut(false);
            isLoading = false;
        }

        /// <summary>
        /// Instantly shows loading page.
        /// </summary>
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

        /// <summary>
        /// Activates child form and closes other forms.
        /// </summary>
        /// <param name="_newChildForm"></param>
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
            if (!isAdminLoggedIn)
            {
                loginForm = new LoginForm(this);
                ActivateChildForm(loginForm);
                FadeOutLoading();
            }
        }

        private void delay_Tick(object sender, EventArgs e) {
            StartFadeOut();
            delay.Stop();
        }

        private void editAcademcian_Click(object sender, EventArgs e)
        {
            editForm = new ProfileEditForm();
            ActivateChildForm(editForm);
            FadeOutLoading();
        }
        public void hideLoginForm()
        {
            menuLogin.Visible = false;
            editAcademcian.Visible = true;
            editForm = new ProfileEditForm();
            ActivateChildForm(editForm);
            FadeOutLoading();
        }
    }
}
