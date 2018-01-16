using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote2
{
    public partial class 
        App : MetroFramework.Forms.MetroForm
    {
        Y2KeyboardHook _keyboardHook;
        public App()
        {
            InitializeComponent();
            bool ctrldown = false;

            _keyboardHook = new Y2KeyboardHook();
            _keyboardHook.Install();


            _keyboardHook.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.LControlKey)///
                {
                    ctrldown = true;
                }

                if (e.KeyCode == Keys.T && ctrldown)//
                {
                    TakeNote takenote = new TakeNote();
                    takenote.Show();
                }
            };
            _keyboardHook.KeyUp += (sender, e) =>
            {

                if (e.KeyCode == Keys.LControlKey)
                {
                    ctrldown = false;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = "Easy to take note";
            notifyIcon.Text = "Take note";
            //notifyIcon.ShowBalloonTip(1000);
            
            CreateContextMenu();
        }

        public void CreateContextMenu()
        {
            //Items 
            ContextMenu CM = new ContextMenu();
            MenuItem MI1 = new MenuItem("Exit");
            MenuItem MI2 = new MenuItem("View notes");
            MenuItem MI3 = new MenuItem("View statistics");

            //Exit
            MI1.Click += new EventHandler(MI_Click);
            MI1.Name = "Exit";
            CM.MenuItems.Add(MI1);


            //View notes
            MI2.Click += new EventHandler(MI_Click);
            MI2.Name = "View notes";
            CM.MenuItems.Add(MI2);

            //View statistics
            MI3.Click += new EventHandler(MI_Click);
            MI3.Name = "View statistics";
            CM.MenuItems.Add(MI3);

            notifyIcon.ContextMenu = CM;
        }

        void MI_Click(object sender, EventArgs e)
        {
            MenuItem MI = (MenuItem)sender;
            if (MI.Name == "Exit")
            {
                Application.Exit();
            }
            if (MI.Name == "View notes")
            {
                ViewNote NoteWin = new ViewNote();
                NoteWin.Show();
            }
            if (MI.Name == "View statistics")
            {
                Statistics StatisticsWin = new Statistics();
                StatisticsWin.Show();
                //TakeNote Tk = new TakeNote();
                //Tk.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistics S1 = new Statistics();
            S1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewNote Note1 = new ViewNote();
            Note1.Show();
        }
        
        private void HideHandle(object sender, EventArgs e)
        {
            //base.OnResize(e);
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void Show(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon.Visible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ViewNote NoteWin = new ViewNote();
            NoteWin.Show();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void App_KeyDown1(object sender, KeyEventArgs e)
        {
            TakeNote takenote = new TakeNote();
            takenote.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            FindNote find = new FindNote();
            find.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
