using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Models;
using Controller;
namespace TeamCell.Usuarios
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            EmployeeController empCont = new EmployeeController();
            grdcList.DataSource = empCont.getEmployees();
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            dtFechaNacimiento.DateTime = DateTime.Now;
            txtCedula.Text = "";
            txtEstado.Text = "";

        }
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
