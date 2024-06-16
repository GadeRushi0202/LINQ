using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKToObjectDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee { Id = 1,Name="Rushi",City="Pune",Salary=45000},
                new Employee { Id = 2,Name="Rajesh",City="Nagar",Salary=55000},
                new Employee { Id = 3,Name="Vishal",City="Nagar",Salary=50000},
                new Employee { Id = 4,Name="Pratiksha",City="Nagar",Salary=46000},
                new Employee { Id = 5,Name="Rutu",City="Latur",Salary=46000},
                new Employee { Id = 6,Name="Shubham",City="Beed",Salary=30000},
                new Employee { Id = 7,Name="Shubham",City="Surat",Salary=25000},
                new Employee { Id = 8,Name="Vedhansh",City="Beed",Salary=15000},
                new Employee { Id = 9,Name="Harsh",City="Beed",Salary=12000},
                new Employee { Id = 10,Name="Dhananjay",City="Pune",Salary=450000},
                new Employee { Id = 11,Name="Sudhir",City="Beed",Salary=75000},
            };
            var result = from e in Employees
                         where e.City == "Pune"
                         select e;
           /* foreach(Employee item in result)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            /*----------------------------------------------*/
            var result1 = from e in Employees
                          where e.Name.StartsWith("P")      
                          select e;
            /*foreach (Employee item in result1)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/
            /*----------------------------------------------*/
            var result2 = from e in Employees
                          where e.Salary>24000 && e.City=="Beed"
                          select e;
           /* foreach (Employee item in result2)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/
            /*----------------------------------------------*/

            var result4 = Employees.Where(x => x.City == "Beed").ToList();
           /* foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }*/
            /*----------------------------------------------*/
            var result5 = Employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result5)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }
        }
    }
}
