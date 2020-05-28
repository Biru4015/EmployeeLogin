namespace GreetingAppManagerLayer.IManager
{
    using GreetingAppCommonLayer;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    public interface IEmployeeManager
    {
        Task<int> AddEmployee(GreetingModel employee);
        
        GreetingModel GetEmployee(int id);
        
        Task<int> UpdateEmployee(GreetingModel employeeChanges);
        
        GreetingModel DeleteEmployee(int id);
        
        IEnumerable<GreetingModel> GetAllEmployees();
    }
}