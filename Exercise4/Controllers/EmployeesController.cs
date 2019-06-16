using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Exercise4.Database;

namespace Exercise4.Controllers
{
    /// <summary>
    /// Provides Employee details
    /// </summary>
    public class EmployeesController : ApiController
    {
        MyEntities entities = new MyEntities();

        /// <summary>
        /// Returns all employee details
        /// </summary>
        /// api/employees/getallemployees
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAllEmployees")]
        public List<Employee> GetEmployees()
        {
            return entities.Employees.ToList();
        }

        /// <summary>
        /// Returns employee details based on the employee id
        /// </summary>
        /// <param name="id">employee id</param>
        /// api/employees/getemployee/1
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            Employee employee = new Employee();

            GET_EMPLOYEEDETAILS_Result result = entities.GET_EMPLOYEEDETAILS(id).FirstOrDefault();
            employee.EMP_ID = result.EMP_ID;
            employee.EMP_NAME = result.EMP_NAME;
            employee.EMP_AGE = result.EMP_AGE;
            employee.EMP_DOB = result.EMP_DOB;
            employee.EMP_DOJ = result.EMP_DOJ;

            return employee;
        }
    }
}
