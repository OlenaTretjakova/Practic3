using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practic3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1(50,55);

            int result = task1.MultDiapason();
            Console.WriteLine($"The multiply of the range numbers :{result}");

            bool isPrime = Task2.IsPrime(17);

            Console.WriteLine($"Number 17 is prime: {isPrime}");

            int[] Arr = { 1, 14, 26, 3, 8, 55, 91 };

            Console.WriteLine("Array : ");

            Task3.PrintArr( Arr );

            Task3.SortArr( Arr );

            Console.WriteLine("Array was sort : ");

            Task3.PrintArr(Arr);

            City city = new City();

            City london = new City("London");

            City rome = new City("Rome", "Italy");

            City berlin = new City("Berlin", "Germany", 3748000, new string[] { "Mitte", "Friedrichshain", "Kreuzberg", "Charlottenburg-Wilmersdorf" });

            City vienna = new City("Vienna", "Austria", 1888776);

            city.ShowInformCity();

            london.ShowInformCity();

            rome.ShowInformCity();

            vienna.ShowInformCity();  

            berlin.ShowInformCity();

            Plan plan1 = new Plan("Boeing", "Boeing Company", "Passenger", new DateTime(2020, 1, 1));

            plan1.ShowPlan();

            Plan plan2 = new Plan("Airbus", "Airbus Company", "Cargo", new DateTime(2018, 5, 10), "John Smith", 12345);

            plan2.ShowPlan("John Smith", 12345);

            int[,] arr = new int[3, 3] { { 1, 2, 2 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Matrix matrix = new Matrix(arr);

            matrix.ShowMatrix();

            matrix.ShowMaxValue();



            Console.ReadLine();

        }


    }
}
