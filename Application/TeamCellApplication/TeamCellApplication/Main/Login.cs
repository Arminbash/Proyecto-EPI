using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Controller;
using Entities;
namespace TeamCellApplication.Main
{
    public partial class Login : Form
    {
        private readonly  UserController _userController = new UserController();
        public Login()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Escriba el nombre de usuario");
                return false;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Escriba la contraseña");
                return false;
            }

            return true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                User user = new User();
                user.UserName = txtUser.Text;
                user.Password = txtPassword.Text;
                if (await _userController.tryLogin(user))
                {
                    MessageBox.Show("Usuario Correcto");
                    lblError.Visible = false;
                } 
                else
                {
                    MessageBox.Show("Credenciales no validas");
                    lblError.Visible = true;
                }
                  
            } 
        }
    }
}
