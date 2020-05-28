namespace GreetingAppManagerLayer.ManagerImplimentation
{
    using GreetingAppCommonLayer;
    using GreetingAppRepositoryLayer.IReposistory;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using GreetingAppManagerLayer.IManager;
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IRepo repository;

        public EmployeeManager(IRepo repository)
        {
            this.repository = repository;
        }

        public Task<int> AddEmployee(GreetingModel employee)
        {
            return this.repository.AddEmployee(employee);
        }

        public GreetingModel GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(GreetingModel employeeChanges)
        {
            return this.repository.UpdateEmployee(employeeChanges);
        }

        public GreetingModel DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }
    }
}