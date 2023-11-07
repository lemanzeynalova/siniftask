namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose from below options:");
                Console.WriteLine("1.Create employee.");
                Console.WriteLine("2.Get employee details by id ");
                Console.WriteLine("3.Get all employees ");
                Console.WriteLine("4.Update employee details ");
                Console.WriteLine("5. Delete employee records by id");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                switch (userAnswer)
                {
                    case 1:
                        Console.WriteLine("Enter name: ");
                        employee.Name = Console.ReadLine();
                        Company.AddEmployee(employee);
                        break;




                }

            }

            Company company1 = new Company { Id = 1, Name = "Company A" };
            Company company2 = new Company { Id = 2, Name = "Company B" };

            Employee employee1 = new Employee { Id = 1, Name = "deniz ajdkh", CompanyId = 1 };
            Employee employee2 = new Employee { Id = 2, Name = "Jale bgdewhh", CompanyId = 2 };


            EmployeeDatabase.Companies.Add(company1);
            EmployeeDatabase.Companies.Add(company2);

            EmployeeService.AddEmployee(employee1);
            EmployeeService.AddEmployee(employee2);


            List<Employee> allEmployees = EmployeeService.GetEmployees();
            Console.WriteLine("butun isciler:");
            foreach (Employee employee in allEmployees)
            {
                Console.WriteLine($"ID: {employee.Id}, Ad: {employee.Name}, Şirket ID: {employee.CompanyId}");
            }
        }
    }

}
       