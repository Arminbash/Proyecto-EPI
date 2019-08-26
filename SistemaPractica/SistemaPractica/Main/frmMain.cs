using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Crud;


namespace TeamCellApplication.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if (VerticalMenu.Width == 250)
            {
                VerticalMenu.Width = 70;
            }
            else
            {
                VerticalMenu.Width = 250;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximize.Visible = false;
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TittleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void openFormInPanel(object formChild)
        {
            if(this.Contra.Controls.Count >0)
                this.Contra.Controls.RemoveAt(0);
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.Contra.Controls.Add(fc);
            this.Contra.Tag = fc;fc.Show();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            openFormInPanel(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
