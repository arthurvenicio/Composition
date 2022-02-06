using System;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department department = new Department(departName);
            Worker w = new Worker(name, level, salary, department);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dt = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(dt, value, duration);
                w.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string date = Console.ReadLine();
            string[] monthYear = date.Split('/');

            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);

            Console.WriteLine($"Name: {w.Name}");
            Console.WriteLine($"Department: {w.Department.Name}");
            Console.WriteLine($"Income for {date}: {w.Income(month, year).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
