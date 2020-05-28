using GreetingAppCommonLayer;
using GreetingAppRepositoryLayer.Context;
using GreetingAppRepositoryLayer.IReposistory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppRepositoryLayer.Repository
{
    public class EmployeeRepository:IRepo
    {
        private readonly UserDatabaseContext userDbContext;

        public EmployeeRepository(UserDatabaseContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public Task<int> AddEmployee(GreetingModel employee)
        {
            userDbContext.Employee.Add(employee);
            var result = userDbContext.SaveChangesAsync();
            return result;
        }
        public GreetingModel GetEmployee(int id)
        {
            return userDbContext.Employee.Find(id);
        }

        public Task<int> UpdateEmployee(GreetingModel employeeChanges)
        {
            var employee = userDbContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

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

        public IEnumerable<GreetingModel> GetAllEmployees()
        {
            return userDbContext.Employee;
        }
    }
}