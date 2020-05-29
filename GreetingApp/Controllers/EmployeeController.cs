namespace GreetingApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using GreetingAppCommonLayer;
    using GreetingAppManagerLayer.IManager;
    using GreetingAppManagerLayer.ManagerImplimentation;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Serilog;

    /// <summary>
    /// This class contains the code for EmployeeController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(EmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        ///  Adding the details of employee
        /// </summary>
        /// <param name="employee">The model class employee</param>
        /// <returns>The async result</returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(GreetingAppCommonLayer.GreetingModel employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                Log.Error("Employee was't added");
                return this.BadRequest();
            }
        }

        /// <summary>
        ///  Getting the details of employee
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The employee id</returns>
        [Route("{id}")]
        [HttpGet]
        public GreetingModel GetEmployee(int id)
        {
            Log.Information("Employee with given id is available");
            return this.manager.GetEmployee(id);
        }

        /// <summary>
        /// Updating the of employee
        /// </summary>
        /// <param name="employeeChanges">The model class employeeChanges</param>
        /// <returns>Th async result</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(GreetingModel employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                Log.Information("Employee Updated");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deleting details of a particular employee details
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The id</returns>
        [HttpDelete]
        [Route("{id}")]
        public GreetingModel DeleteEmployee(int id)
        {
            Log.Information("Employee with given id is Deleted");
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets all the employees details
        /// </summary>
        /// <returns>List of employee </returns>
        [HttpGet]
        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            Log.Information("All added in list");
            return this.manager.GetAllEmployees();
        }
    }
}