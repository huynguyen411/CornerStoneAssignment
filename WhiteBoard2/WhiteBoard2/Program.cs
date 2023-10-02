namespace WhiteBoard2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Emily Johnson",
                    Salary = 900,
                    Department = "DU1"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Liam Anderson",
                    Salary = 1300,
                    Department = "DU2"
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Sophia Martinez",
                    Salary = 1120,
                    Department = "DU3"
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Noah Wilson",
                    Salary = 700,
                    Department = "DU4"
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Olivia Davis",
                    Salary = 1200,
                    Department = "DU5"
                },
                new Employee()
                {
                    Id = 6,
                    Name = "Ethan Thompson",
                    Salary = 1050,
                    Department = "DU6"
                }
            };
            List<string> output = GetEmployeesWithHighSalary(employees, 1000);
            foreach(string employee in output)
            {
                Console.WriteLine(employee);
            }
        }
        static List<string> GetEmployeesWithHighSalary(List<Employee> employees, int threshold) 
        {
            List<Employee> filteredEmployees = employees.Where(x => x.Salary > threshold).OrderBy(x => x.Name).ToList();
            List<string> returnedEmployees = filteredEmployees.Select(x => $"{x.Name} ({x.Department})").ToList();

            return returnedEmployees;
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
