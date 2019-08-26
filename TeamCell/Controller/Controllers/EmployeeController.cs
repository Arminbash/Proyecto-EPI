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
       public List<Employee> getEmployees()
       {
           try
           {
               using( TeamCellContext _DBContext = new TeamCellContext())
               {
                   var result = _DBContext.Employee.ToList();
                   return result;
               }
           }
           catch
           {
               return new List<Employee>();
           }
       }
    }
}
