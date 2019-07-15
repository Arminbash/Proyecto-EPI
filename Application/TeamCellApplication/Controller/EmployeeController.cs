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
                    emp.BirthDay = _employee.BirthDay;
                    emp.State = "";
                    emp.Status = true;
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

        public Entities.Employee getEmployeeXId(int idEmployee)
        {
            try
            {
                using (PV_TEAMCELLEntities context = new PV_TEAMCELLEntities())
                {
                    Entities.Employee emp = new Entities.Employee();
                    DataConnection.Employee getEmp = context.Employee.Where(x => x.IdEmployee == idEmployee).FirstOrDefault();
                    emp.IdEmployee = getEmp.IdEmployee;
                    emp.FirstName = getEmp.FirstName;
                    emp.SecondName = getEmp.SecondName;
                    emp.FirstSurname = getEmp.SecondSurname;
                    emp.SecondSurname = getEmp.SecondSurname;
                    emp.BirthDay = getEmp.BirthDay;
                    emp.IdentificationCard = getEmp.IdentificationCard;
                    emp.State = getEmp.State;
                    emp.Status = getEmp.Status;
                    return emp;
                }
            }
            catch (Exception e)
            {
                return new Entities.Employee();
            }
        }
    }
}
