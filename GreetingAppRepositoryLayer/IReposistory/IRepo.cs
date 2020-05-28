using GreetingAppCommonLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppRepositoryLayer.IReposistory
{
    public interface IRepo
    {
        Task<int> AddEmployee(GreetingModel employee);
        
        GreetingModel GetEmployee(int id);

        Task<int> UpdateEmployee(GreetingModel employeeChanges);
        
        GreetingModel DeleteEmployee(int id);
        
        IEnumerable<GreetingModel> GetAllEmployees();
    }
}
