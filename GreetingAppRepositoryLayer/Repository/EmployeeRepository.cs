namespace GreetingAppRepositoryLayer.Repository
{
    using GreetingAppCommonLayer;
    using GreetingAppRepositoryLayer.Context;
    using GreetingAppRepositoryLayer.IReposistory;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is contains the code for EmployeeRepository class
    /// </summary>
    public class EmployeeRepository:IEmployeeRepository
    {
        /// <summary>
        /// The userDbContext object
        /// </summary>
        private readonly UserDatabaseContext userDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="userDbContext">The userDbContext</param>
        public EmployeeRepository(UserDatabaseContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        /// <summary>
        /// Adding the specified employee details
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns></returns>
        public Task<int> AddEmployee(GreetingModel employee)
        {
            userDbContext.Employee.Add(employee);
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Gets the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>id</returns>
        public GreetingModel GetEmployee(int id)
        {
            return userDbContext.Employee.Find(id);
        }

        /// <summary>
        /// Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns>Updated id</returns>
        public Task<int> UpdateEmployee(GreetingModel employeeChanges)
        {
            var employee = userDbContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Deleted Employee</returns>
        public GreetingModel DeleteEmployee(int id)
        {
            GreetingModel employee = userDbContext.Employee.Find(id);
            if (employee != null)
            {
                userDbContext.Employee.Remove(employee);
                userDbContext.SaveChanges();
            }
            return employee;
        }

        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>Details of employees</returns>
        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            return userDbContext.Employee;
        }
    }
}