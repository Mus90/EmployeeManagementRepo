using System;
using System.Linq;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase        
    {
        public MyDbContext _db;

        public EmployeeController(MyDbContext db)
        {
            _db = db;
        }

        public IActionResult GetEmployee()
        {
           var result= _db.Employee.ToList();
            return Ok(result);
        }

        [Route("GetEmpByID/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = _db.Employee.Where(x => x.id==id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult PostEmployee([FromBody]Employee emp)
        {
            _db.Employee.Add(emp);
            _db.SaveChanges();
            return Ok("Successful");
        }
    }
}
