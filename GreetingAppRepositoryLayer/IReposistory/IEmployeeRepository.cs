﻿namespace GreetingAppRepositoryLayer.IReposistory
{
    using GreetingAppCommonLayer;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is interface for EmployeeRepository.
    /// </summary>
    public interface IRepo
    {
        /// <summary>
        ///  Adds the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns>employee id</returns>
        Task<int> AddEmployee(GreetingModel employee);

        /// <summary>
        ///  Getss the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>employee id</returns>
        GreetingModel GetEmployee(int id);

        /// <summary>
        ///  Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns>updated employee</returns>
        Task<int> UpdateEmployee(GreetingModel employeeChanges);

        /// <summary>
        ///  Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>employee id</returns>
        GreetingModel DeleteEmployee(int id);

        /// <summary>
        ///  Gets all employees
        /// </summary>
        /// <returns>list of all employees</returns>
        IEnumerable<GreetingModel> GetAllEmployees();
    }
}