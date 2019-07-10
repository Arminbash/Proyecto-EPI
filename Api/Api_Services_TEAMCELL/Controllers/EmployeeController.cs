using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Services_TEAMCELL.Models;
using Api_Services_TEAMCELL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Services_TEAMCELL.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("getEmployees")]
        public IActionResult getEmployees()
        {
            var result = _employeeService.getEmployeesActive();
            return Ok(result);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult addEmployee([FromBody] Employee employee)
        {
            if (_employeeService.addEmployee(employee))
                return Ok();
            else
                return BadRequest();
        }

        [Route("edit")]
        [HttpPut]
        public IActionResult editEmployee([FromBody] Employee employee)
        {
            if (_employeeService.editEmployee(employee))
                return Ok();
            else
                return BadRequest();
        }

        [Route("delete/{IdEmployee}")]
        public IActionResult deleteEmployee(int IdEmployee) {
            if (_employeeService.deleteEmployee(IdEmployee))
                return Ok();
            else
                return BadRequest();
        }

        [Route("get/{IdEmployee}")]
        public IActionResult getEmployeeXId(int IdEmployee)
        {
            var result = _employeeService.getEmployeeXID(IdEmployee);
            return Ok(result);
        }

    }
}