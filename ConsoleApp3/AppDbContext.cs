using ConsoleApp3;

namespace ConsoleApp2
{
    public class AppDbContext
    {
        public List<Employee> Employees = new List<Employee>()
        {
            new Employee
            {
                FullName = "Ali Aliyev",
                Age = 25,
                Email = "ali@gmail.com",
                Salary = 1500,
                Address = "Baku"
            },

            new Employee
            {
                FullName = "Veli Veliyev",
                Age = 30,
                Email = "veli@gmail.com",
                Salary = 2000,
                Address = "Ganja"
            },

            new Employee
            {
                FullName = "Aysel Memmedova",
                Age = 22,
                Email = "aysel@gmail.com",
                Salary = 1200,
                Address = "Sumqayit"
            },

            new Employee
            {
                FullName = "Murad Hasanov",
                Age = 35,
                Email = "murad@gmail.com",
                Salary = 3000,
                Address = "Baku"
            }
        };

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}