using System;
using System.Windows.Forms;
using System.Threading;
using ClassLibrary1; //draagassemly

namespace MiewPos
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            Thread myThr = new Thread(new ThreadStart(startSplash));
            myThr.Start();
            Thread.Sleep(2500);
            //
            InitializeComponent();
            myThr.Abort(); 
        }

        public void startSplash()
        {
            Application.Run(new SplashScreen());
        }

        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        #region Navbar top
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Draggable.Move(this);
            }
        }

        #endregion

        #region Main Menu Click
        private void picInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new InventoryForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        #endregion
    }
}
