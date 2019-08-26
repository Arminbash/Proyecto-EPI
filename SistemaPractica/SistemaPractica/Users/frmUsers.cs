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

namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private  void Form1_Load(object sender, EventArgs e)
        {
            UserController user =new UserController();
            gridControl1.DataSource = user.GetUsers();


        }


        public void limpiar()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
       

        private  async void btnSave_Click(object sender, EventArgs e)
        {

           
            try
            {
                UserController userController = new UserController();
                Users users = new Users();
                if (!userController.Existe(txtUsername.Text))
                {
                    users.Username = txtUsername.Text;
                    users.Password = Encrypt.GetSHA256(txtPassword.Text);
                    users.IdEmployee = Convert.ToInt32(cbEmployee.Text);

                    if (userController.CreateUsers(users))
                    {

                        MessageBox.Show("Registro Agregado Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al Agregar");

                        limpiar();
                    }

                }
                else
                {
                    MessageBox.Show("El Usuario ya existe por favor ingrese otro Usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    limpiar();
                }

                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
