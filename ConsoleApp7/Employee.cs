using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee:Person
    {

        public decimal Salary { get; set; }
        public string Position { get; set; }
        public GenderEnum Gender { get; set; }
    }

    public class EmployeeNotFound : Exception
    {
        public EmployeeNotFound(int id) : base($"Employee with ID {id} not found.") { }
    }
    public static class EmployeeDatabase
    {
        public static List<Company> Companies { get; } = new List<Company>();
        public static List<Employee> Employees { get; } = new List<Employee>();
    }
    public static class EmployeeService
    {
        public static void AddEmployee(Employee employee)
        {
            EmployeeDatabase.Employees.Add(employee);
        }

        public static Employee GetEmployeeById(int id)
        {
            return EmployeeDatabase.Employees.FirstOrDefault(e => e.Id == id);
        }

        public static void UpdateEmployee(Employee employee)
        {
            Employee existingEmployee = EmployeeDatabase.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                
            }
        }

        public static void RemoveEmployee(int id)
        {
            Employee employeeToRemove = EmployeeDatabase.Employees.FirstOrDefault(e => e.Id == id);
            if (employeeToRemove != null)
            {
                EmployeeDatabase.Employees.Remove(employeeToRemove);
            }
        }

        public static List<Employee> GetEmployees()
        {
            return EmployeeDatabase.Employees;
        }



    }


}




    
