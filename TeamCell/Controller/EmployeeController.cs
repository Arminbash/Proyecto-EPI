using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Models;
namespace Controller
{
   public class EmployeeController
    {
       TeamCellContext _DBContext = new TeamCellContext();
       public List<Employee> getEmployees()
       {
           try
           {
               var result = _DBContext.Employee.ToList();
               return result;
           }
           catch
           {
               return new List<Employee>();
           }
       }
    }
}
