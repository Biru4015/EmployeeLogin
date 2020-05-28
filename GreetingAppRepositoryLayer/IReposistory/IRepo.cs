using GreetingAppCommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoryLayer.IReposistory
{
    public interface IRepo
    {
        GreetingModel AddEmployee(GreetingModel employee);
        GreetingModel DeleteEmployee(int id);
        IEnumerable<GreetingModel> GetAllEmployee();
        GreetingModel UpdateEmployee(GreetingModel employee);
    }
}
