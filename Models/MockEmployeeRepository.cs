  using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
 
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {id = 1 , firstName= "Mustafa" , lastName = "Ali", phoneNumber = "0647"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.id == id);
        }
    }
}
