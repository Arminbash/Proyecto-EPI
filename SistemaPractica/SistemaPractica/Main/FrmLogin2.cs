using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;
using TeamCellApplication.Main;

namespace Crud
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
                label5.Visible = false;
            }
                
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
                
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                UserController userController = new UserController();
                if (!userController.Login(txtUser.Text, Encrypt.GetSHA256(txtPassword.Text)))
                {
                    label5.Visible = true;
                    

                }
                else
                {
                   
                    frmMain entrar = new frmMain();
                    entrar.Show();
                    this.Hide();
                }


                
            }
            catch (Exception)
            {
                throw;

            }

        }
    }
}
