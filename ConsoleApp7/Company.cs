using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class Company
    {
        private static int _id;
        public int Id { get; set; }

        public Company()
        {
            Id++;
            Id = Id;
        }
        public string Name { get; set; }
        public List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }
        public void RemoveEmployee(int id)
        {
            Employee employee = GetEmployeeById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
        public void GetEmployees()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
        public Employee GetEmployeeById(int id)
        {
            Employee employee = employees.SingleOrDefault(x => x.Id == id);
            if (employee != null)
            {
                return employee;
            }
           
        }

        internal static void AddEmployee(object employee)
        {
            throw new NotImplementedException();
        }
    }
}
