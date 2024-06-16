using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINKToObjectDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
    }
    public class Program1 {
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=999,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=599,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=54799,CompanyName="HP"},
                new Product{Id=4,Name="Laptop",Price=35799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=48799,CompanyName="Dell"},
                new Product{Id=6,Name="Keyboard",Price=699,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=1000,CompanyName="HP"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
        };
            /*Using LINQ query*/

            /*1.Display all products using LINQ query*/
            Console.WriteLine("------------------------------1-----------------------------------");
            var result1 = from p in products
                          select p;
            foreach (Product item in result1)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }

            Console.WriteLine("------------------------------2-----------------------------------");
            /*2.Display products whose price is greater than 1500*/
            var result2= from p in products
                         where p.Price >1500
                         select p;
            foreach (Product item in result2)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*3.Display products whose price is in between 10000 to 40000*/
            Console.WriteLine("------------------------------3-----------------------------------");
            var result3 = from p in products
                          where p.Price >10000 || p.Price>40000
                          select p;
            foreach (Product item in result3)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*4.Display products of Dell company*/
            Console.WriteLine("------------------------------4-----------------------------------");

            var result4 = from p in products
                          where p.CompanyName == "Dell"
                          select p ;
            foreach (Product item in result4)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*5.Display all company laptops*/
            Console.WriteLine("------------------------------5-----------------------------------");

            var result5 = from p in products
                          where p.Name == "Laptop"
                          select p;
            foreach (Product item in result5)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*6.Display products whose company name start with ‘M’*/
            Console.WriteLine("------------------------------6-----------------------------------");

            var result6 = from p in products
                          where p.CompanyName.StartsWith("M")
                          select p;
            foreach (Product item in result6)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*7.Display all company mouse whose price is less than 1000*/
            Console.WriteLine("------------------------------7-----------------------------------");
            var result7 = from p in products
                          where p.Name=="Mouse" 
                          select p;
            foreach (Product item in result7)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }

            /*8.Display all products descending order by their price*/
            Console.WriteLine("------------------------------8-----------------------------------");
            var result8 = from p in products
                          orderby  p.Price descending
                          select p;
            foreach (Product item in result8)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }

            /*9.Display all products accessing order by their company name*/
            Console.WriteLine("------------------------------9-----------------------------------");
            var result9 = from p in products
                          orderby p.CompanyName ascending
                          select p;
            foreach (Product item in result9)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }

            /*10.Display all keyboards accessing order by their price*/

            Console.WriteLine("------------------------------10-----------------------------------");
            var result10 = from p in products
                           where p.Name == "Keyboard"
                           orderby p.Price ascending
                           select p;
            foreach (Product item in result10)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            Console.WriteLine("*********************************************************************************************************");
            /*Using Lambda Expressions*/
            /*1.Display all products descending order by their price*/
            Console.WriteLine("------------------------------1-----------------------------------");

            var result11 = products.OrderBy (x => x.Price).ToList();
            foreach (Product item in result11)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*2.Display product whose Id is 5*/
            Console.WriteLine("------------------------------2-----------------------------------");
            var result= products.Where(x => x.Id==5).ToList();
            foreach (Product item in result)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*3.Display all products whose price less than 5000*/
            Console.WriteLine("------------------------------3-----------------------------------");
            var result22 = products.Where(x => x.Price<5000).ToList();
            foreach (Product item in result22)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Price},{item.CompanyName}");
            }
            /*4.Display 3 products which have maximum price*/
            Console.WriteLine("------------------------------3-----------------------------------");
            var result13 = products.OrderByDescending(p => p.Price).Take(3).ToList();
            foreach (Product item in result13)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            /*5.Display 5 products which have minimum price*/
            Console.WriteLine("------------------------------3-----------------------------------");
            var result14 = products.OrderBy(p => p.Price).Take(5).ToList();
            foreach (Product item in result14)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


        }
    }

}
