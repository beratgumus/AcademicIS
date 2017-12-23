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
        ProfileForm profileForm;
        ProfileEditForm addForm;
        CourseScheduleForm scheduleForm;
        bool isAdminLoggedIn;

        bool isLoading;
        private int _fadeDelay;
        public int fadeDelay {
            // we can adjust this variable whenever we need custom fadeDelay
            // in child forms. Default delay is 200 ms
            get {
                return _fadeDelay;
            }
            set {
                if (value >= 5000)
                    _fadeDelay = 5000;
                else if (value < 200)
                    _fadeDelay = 200;
                else
                    _fadeDelay = value;
            }
        }

        System.Windows.Forms.Timer colorChanger;
        int r, g, b;

        public MainForm() {
            InitializeComponent();
            menu.Renderer = new CustomRenderer(); // appyle custom styles to menu
            spinner.Image = AcademicIS.Properties.Resources.spinner2;
            isLoading = true;
            isAdminLoggedIn = false;
            _fadeDelay = 200;
            r = 0;
            g = 255;
            b = 0;
            colorChanger = new System.Windows.Forms.Timer();
            colorChanger.Interval = 250;
            colorChanger.Tick += ChangeColor;
            colorChanger.Start();
            colorChanger.Enabled = true;

            //loadingText.Hide();   //enable this block if you want to see asynchronus loading
            //loading.SetVisible(false);
            //spinner.Hide();
            //spinner.SendToBack();
            //loadingText.SendToBack();
            //isLoading = false;

            ShowLoading();
            searchForm = new SearchForm();
            ActivateChildForm(searchForm, false);
            //ActivateChildForm(new ProfileEditForm(), false);
            //ActivateChildForm(new ProfileForm());
            //ActivateChildForm(new ProfileEditForm());
            //FadeOutLoading(1000);
            //HideLoginButton();

            //search form will call FadeOutLoading when its completely loaded.

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
                get { return Color.FromArgb(38, 174, 114); }
            }
            public override Color MenuItemSelectedGradientEnd {
                get { return Color.FromArgb(26, 140, 70); }
            }
            public override Color MenuItemBorder {
                get { return Color.Transparent; }
            }
        }
        #endregion


        /// <summary>
        /// Fadeout loading screen
        /// </summary>
        public async void FadeOutLoading() {

            if (isLoading) {
                //every
                await AsyncTimeOut(_fadeDelay);

                // if any childform changed delay time, lets reset it after
                // delaying requested time. So we wont delay that custom time
                // everytime.
                if (_fadeDelay != 200)
                    _fadeDelay = 200;
                
                spinner.Hide();
                spinner.SendToBack();
                loadingText.Hide();
                loadingText.SendToBack();
                loading.FadeOut(false);
                isLoading = false;
            }
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
        /// <param name="dispose">true if we want to dispose other child forms</param>
        private void ActivateChildForm(Form _newChildForm, bool dispose) {
            foreach (Form frm in this.MdiChildren) {
                if (frm.Text != _newChildForm.Text) {
                    if (dispose) {
                        frm.Close();
                        frm.Dispose();
                    }
                    else {
                        frm.Hide();
                    }
                }
            }
            _newChildForm.MdiParent = this;
            _newChildForm.StartPosition = FormStartPosition.Manual;
            _newChildForm.Location = new Point(0, 70); //offset for custom header
            _newChildForm.Show();
            _newChildForm.Activate();
        }

        public void menuSearch_Click(object sender, EventArgs e) {
            ShowLoading();

            if (searchForm == null || searchForm.IsDisposed || isAdminLoggedIn) {
                //search form is not initialized yet or its closed
                // or admin logged in: lets refresh it to show new academicians
                searchForm = new SearchForm();
                ActivateChildForm(searchForm, true);
                //search form will call FadeOutLoading when its completely loaded.
            }
            else {
                ActivateChildForm(searchForm, true);

                //search form wont call FadeOutLoading because its allready loaded!
                //so lets call it manually.
                FadeOutLoading();
            }
            
        }

        /// <summary>
        /// This function is used when we need to wait some time asynchornusly.
        /// It does nothing. Sometimes we will use it to hide loading flickers,
        /// sometimes we really need it to delay database transactions.
        /// Also this won't freeze UI thread.
        /// </summary>
        /// <param name="msDelay">Timeout in miliseconds</param>
        /// <returns>always true</returns>
        public Task<bool> AsyncTimeOut(int msDelay) {
            return Task.Run(() => {
                System.Threading.Thread.Sleep(msDelay);
                return true;
            });
        }

        private void menuLogin_Click(object sender, EventArgs e) {

            if (!isAdminLoggedIn)
            {
                ShowLoading();
                loginForm = new LoginForm();
                ActivateChildForm(loginForm, false);
                FadeOutLoading();
            }
        }

        //private void delay_Tick(object sender, EventArgs e) {
        //    StartFadeOut();
        //    delay.Stop();
        //}

        private void addAcademcian_Click(object sender, EventArgs e)
        {
            ShowLoading();
            addForm = new ProfileEditForm();
            ActivateChildForm(addForm, false); //other forms wont be disposed
            FadeOutLoading();
        }

        /// <summary>
        /// This function will be called from LoginForm after admin
        /// succesfully logged in.
        /// </summary>
        public void HideLoginButton()
        {
            ShowLoading();
            isAdminLoggedIn = true;
            menuLogin.Visible = false;
            menuLogin.Enabled = false;
            menuLogin.Dispose();
            addAcademcian.Visible = true;
            addForm = new ProfileEditForm();

            ActivateChildForm(addForm, false); 

            FadeOutLoading();
        }

        /// <summary>
        /// Opens academician profile with given academician id
        /// </summary>
        /// <param name="id">identifier of academician</param>
        public ProfileForm ShowProfileForm(int id) {
            ShowLoading();
            profileForm = new ProfileForm(id, isAdminLoggedIn);

            //search form wont be disposed. because we want to keep last search
            ActivateChildForm(profileForm, false); 

            FadeOutLoading();
            return profileForm;
        }

        public void ShowScheduleForm(int id){
            ShowLoading();
            scheduleForm = new CourseScheduleForm(id,isAdminLoggedIn);

            ActivateChildForm(scheduleForm, false);
            FadeOutLoading();
        }

        /// <summary>
        /// Shows profile edit form. Populates form with academician info
        /// </summary>
        /// <param name="id"></param>
        public void ShowProfileEditForm(Academician ac) {
            ShowLoading();
            addForm = new ProfileEditForm(ac);
            ActivateChildForm(addForm, false);
            FadeOutLoading();
        }

        public void ActivateSearchForm()
        {
            ShowLoading();
            ActivateChildForm(searchForm, true);
            FadeOutLoading();

        }

        public bool GetIsAdminLoggedIn()
        {
            return isAdminLoggedIn;
        }

        public void SetIsAdminLoggedIn(bool _isAdminLoggedIn)
        {
            this.isAdminLoggedIn =_isAdminLoggedIn;
        }

        private void ChangeColor(object sender, EventArgs e) {
            if (r > 0 && b == 0) {
                r--;
                g++;
            }
            if (g > 0 && r == 0) {
                g--;
                b++;
            }
            if (b > 0 && g == 0) {
                r++;
                b--;
            }
            Color c = Color.FromArgb(r, g, b);
            borderLeft.BackColor = borderBottom.BackColor = borderRight.BackColor = c;

        }

    }
}
