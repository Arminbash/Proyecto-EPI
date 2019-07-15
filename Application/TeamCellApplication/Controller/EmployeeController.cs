using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnection;
using  Entities;
using Employee = DataConnection.Employee;

namespace Controller
{
    public class EmployeeController
    {
        public bool SaveEmployee(Entities.Employee _employee)
        {
            try
            {
                using ( PV_TEAMCELLEntities context = new PV_TEAMCELLEntities())
                {
                    DataConnection.Employee emp = new Employee();
                    emp.IdEmployee = _employee.IdEmployee;
                    emp.FirstName = _employee.FirstName;
                    emp.SecondName = _employee.SecondName;
                    emp.FirstSurname = _employee.FirstSurname;
                    emp.SecondSurname = _employee.SecondSurname;
                    emp.IdentificationCard = _employee.IdentificationCard;
                    context.Employee.Add(emp);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
