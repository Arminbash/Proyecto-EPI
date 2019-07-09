using Api_Services_TEAMCELL.DataConnection;
using Api_Services_TEAMCELL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Api_Services_TEAMCELL.Services
{
    public class EmployeeService
    {
        public readonly ApiDBContext _dbContext;
        public EmployeeService(ApiDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public List<Employee> getEmployeesActive()
        {
            try
            {
                var list = _dbContext.Employee.Where(x => x.Status == true).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Employee>();
            }
        }

        public Employee getEmployeeXID( int idEmployee )
        {
            try
            {
                var employee = _dbContext.Employee.FirstOrDefault(x => x.IdEmployee == idEmployee);
                return employee;
            }
            catch (Exception)
            {
                return new Employee();
            }
        }

        public bool addEmployee(Employee employee)
        {
            try
            {
                _dbContext.Employee.Add(employee);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool editEmployee(Employee employee)
        {
            try
            {
                var employeeEdit = _dbContext.Employee.FirstOrDefault(x => x.IdEmployee == employee.IdEmployee);
                employeeEdit.FirstName = employee.FirstName;
                employeeEdit.SecondName = employee.SecondName;
                employeeEdit.FirstSurname = employee.FirstSurname;
                employeeEdit.SecondSurname = employee.SecondSurname;
                employeeEdit.BirthDay = employee.BirthDay;
                employeeEdit.IdentificationCard = employee.IdentificationCard;
                employeeEdit.State = employee.State;
                employeeEdit.Status = employee.Status;

                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteEmployee(int idEmployee)
        {
            try
            {
                var employee = _dbContext.Employee.FirstOrDefault(x => x.IdEmployee == idEmployee);
                employee.Status = false;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
