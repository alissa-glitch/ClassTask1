
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static AppDbContext db = new AppDbContext();

        // 1. Ishcilerin yaslarinin cemi
        static int GetAgeSum()
        {
            return db.GetAllEmployees().Sum(e => e.Age);
        }

        // 2. Ishcilerin sayi
        static int GetEmployeeCount()
        {
            return db.GetAllEmployees().Count();
        }

        // 3. Ishcilerin yash ortalamasi
        static double GetAgeAverage()
        {
            return db.GetAllEmployees().Average(e => e.Age);
        }

        // 4. FullName-e gore axtarish
        static List<Employee> SearchByFullName(string fullName)
        {
            return db.GetAllEmployees()
                .Where(e => e.FullName.ToLower().Contains(fullName.ToLower()))
                .ToList();
        }

        // 5. Age-e gore azdan choxa sort
        static List<Employee> SortByAgeAscending()
        {
            return db.GetAllEmployees()
                .OrderBy(e => e.Age)
                .ToList();
        }

        // Age-e gore choxdan aza sort
        static List<Employee> SortByAgeDescending()
        {
            return db.GetAllEmployees()
                .OrderByDescending(e => e.Age)
                .ToList();
        }

        // 6. Umumi maash ortalamasi
        static decimal GetSalaryAverage()
        {
            return db.GetAllEmployees().Average(e => e.Salary);
        }

        // 7. Verilmish maash araligina gore ishchiler
        static List<Employee> GetEmployeesBySalaryRange(
            decimal minSalary, decimal maxSalary)
        {
            return db.GetAllEmployees()
                .Where(e => e.Salary >= minSalary && e.Salary <= maxSalary)
                .ToList();
        }

        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Yashlarin cemi: " + GetAgeSum());

            // 2
            Console.WriteLine("Ishchilerin sayi: " + GetEmployeeCount());

            // 3
            Console.WriteLine("Yash ortalamasi: " + GetAgeAverage());

            // 4
            Console.WriteLine("\nAda gore axtarish:");
            var searchResult = SearchByFullName("Ali");

            foreach (var employee in searchResult)
            {
                Console.WriteLine(employee.FullName);
            }

            // 5
            Console.WriteLine("\nYasha gore azdan choxa:");

            foreach (var employee in SortByAgeAscending())
            {
                Console.WriteLine(employee.FullName + " - " + employee.Age);
            }

            Console.WriteLine("\nYasha gore choxdan aza:");

            foreach (var employee in SortByAgeDescending())
            {
                Console.WriteLine(employee.FullName + " - " + employee.Age);
            }

            // 6
            Console.WriteLine("\nMaash ortalamasi: " + GetSalaryAverage());

            // 7
            Console.WriteLine("\nMaash araligina gore:");

            var salaryResult = GetEmployeesBySalaryRange(1200, 2000);

            foreach (var employee in salaryResult)
            {
                Console.WriteLine(
                    employee.FullName + " - " + employee.Salary);
            }
        }
    }
}

