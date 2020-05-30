namespace GreetingAppManagerLayer.IManager
{
    using GreetingAppCommonLayer;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is an interface for EmployeeManager
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adding the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns>The employee</returns>
        Task<int> AddEmployee(GreetingModel employee);

        /// <summary>
        /// Getting the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The employee id</returns>
        GreetingModel GetEmployee(int id);

        /// <summary>
        /// Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns>The employee</returns>
        Task<int> UpdateEmployee(GreetingModel employeeChanges);

        /// <summary>
        /// This is for deleted specified id employee.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The employee id</returns>
        GreetingModel DeleteEmployee(int id);

        /// <summary>
        ///  This is for getting all the employee details
        /// </summary>
        /// <returns>List of all employees</returns>
        IEnumerable<GreetingModel> GetAllEmployees();

        /// <summary>
        /// This is for login functionality of employee
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>true/false</returns>
        bool LoginEmployee(string email, string password);
    }
}