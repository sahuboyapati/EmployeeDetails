using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt for employee details
            Console.WriteLine("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F): ");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (DD/MM/YYYY): ");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            // Calculate tax based on salary
            double taxRate = salary > 90000 ? 0.30 : 0.15;
            double taxAmount = salary * taxRate;

            // Display employee details
            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary:C}\t\t{doj:dd/MM/yyyy}");
            Console.WriteLine();

            // Display the total output message
            Console.WriteLine("You have to pay: --------------");
            Console.ReadKey(); 
            }
        }

    }