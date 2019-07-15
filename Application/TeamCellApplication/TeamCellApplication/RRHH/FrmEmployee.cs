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
using DevExpress.Utils.Drawing;

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
            newEmployee.BirthDay = deBirths.DateTime;
            if (empController.SaveEmployee(newEmployee))
            {
                MessageBox.Show("Se guardo correctamente.");
                clear();
            }
            else
                MessageBox.Show("Ocurrio un error al guardar.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
         clear();
        }

        private void clear()
        {
            seIdEmpleado.Value = 0;
            txtFirstname.Text = "";
            txtSecondName.Text = "";
            txtFirstSurname.Text = "";
            txtSecondName.Text = "";
            deBirths.DateTime = DateTime.Now.Date;
            txtCardIndentificador.Text = "";
            cbCity.SelectedIndex = -1;
            cbCity.Text = "";
        }

        private void seIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            if (seIdEmpleado.Value > 0)
            {
                Employee emp = empController.getEmployeeXId((int)seIdEmpleado.Value);
                txtFirstname.Text = emp.FirstName;
                txtSecondName.Text = emp.SecondName;
                txtFirstSurname.Text = emp.FirstSurname;
                txtSecondSurname.Text = emp.SecondSurname;
                deBirths.DateTime = emp.BirthDay.Value;
                txtCardIndentificador.Text = emp.IdentificationCard;
            }
        }
    }
}
