using GreetingAppCommonLayer;
using GreetingAppRepositoryLayer.Context;
using GreetingAppRepositoryLayer.IReposistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoryLayer.Repository
{
    public class EmployeeRepository:IRepo
    {
        private readonly UserDatabaseContext userDBContext;

        public EmployeeRepository(UserDatabaseContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public GreetingModel AddEmployee(GreetingModel employee)
        {
            userDBContext.Employee.Add(employee);
            userDBContext.SaveChanges();
            return employee;
        }

        public GreetingModel DeleteEmployee(int id)
        {
            GreetingModel employee = userDBContext.Employee.Find(id);
            if (employee != null)
            {
                userDBContext.Employee.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;
        }

        public GreetingModel UpdateEmployee(GreetingModel employeeChanges)
        {

            var employee = userDBContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userDBContext.SaveChanges();
            return employeeChanges;
        }

        public IEnumerable<GreetingModel> GetAllEmployee()
        {
            return userDBContext.Employee;
        }
    }
}