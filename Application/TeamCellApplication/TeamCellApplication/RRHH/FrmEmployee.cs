using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Entities;
using  Controller;
namespace TeamCellApplication.RRHH
{
    public partial class frmEmployee : Form
    {
        EmployeeController empController = new EmployeeController();
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employee();
            newEmployee.IdEmployee = 0;
            newEmployee.FirstName = txtFirstname.Text;newEmployee.SecondName = txtSecondName.Text;
            newEmployee.FirstSurname = txtFirstSurname.Text;
            newEmployee.SecondSurname = txtSecondName.Text;
            newEmployee.IdentificationCard = txtCardIndentificador.Text;

            if (empController.SaveEmployee(newEmployee))
                MessageBox.Show("Se guardo correctamente.");
            else
                MessageBox.Show("Ocurrio un error al guardar.");
        }
    }
}
