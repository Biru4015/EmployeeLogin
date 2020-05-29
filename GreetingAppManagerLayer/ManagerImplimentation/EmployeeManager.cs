namespace GreetingAppManagerLayer.ManagerImplimentation
{
    using GreetingAppCommonLayer;
    using GreetingAppRepositoryLayer.IReposistory;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using GreetingAppManagerLayer.IManager;

    /// <summary>
    /// This class contains the code for EmployeeManager.
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// This method is instance for IRepo.
        /// </summary>
        private readonly IEmployeeRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="repository">The repository</param>
        public EmployeeManager(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adding the employee details for specified employee.
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns></returns>
        public Task<int> AddEmployee(GreetingModel employee)
        {
            return this.repository.AddEmployee(employee);
        }

        /// <summary>
        /// Getting the details for specified employee.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public GreetingModel GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        /// <summary>
        /// Updating the details of employee.
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(GreetingModel employeeChanges)
        {
            return this.repository.UpdateEmployee(employeeChanges);
        }

        /// <summary>
        /// This method is for deleting the employee id.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public GreetingModel DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        /// <summary>
        /// This method is for getting employee details.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }
    }
}