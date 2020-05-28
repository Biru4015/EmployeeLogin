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

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(EmployeeManager manager)
        {
            this.manager = manager;
        }

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
                return this.BadRequest();
            }
        }

        [Route("GetEmployee")]
        [HttpGet]
        public GreetingModel GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }

        [Route("UpdateEmployee")]
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
                return this.BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public GreetingModel DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
    }
}