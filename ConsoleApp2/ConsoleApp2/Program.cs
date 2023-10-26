using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /* 1
        static void Main(string[] args)
        {
            int quantity = 7;

            string itemName = "Widget";

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}={itemName}");
            }
        } */


        /* 2
        static void Main(string[] args)
        {
            Employee emp = new Employee("Robi", "20$");
            Console.WriteLine(emp.DisplayInfo());
        } */


        /* 3
        static void Main(string[] args)
        {
            Fruit apple = new Fruit();
            apple.CalculateTotalPrice(2, 1.5); 

            Electronics phone = new Electronics();
            phone.CalculateTotalPrice(799.99, 1);  
        } */


        /* 4
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            Console.WriteLine($"Sparrow says: {sparrow.MakeSound()}");

            Pigeon pigeon = new Pigeon();
            Console.WriteLine($"Pigeon says: {pigeon.MakeSound()}");
        } */


        /* 5
        static void Main(string[] args)
        {
            MyCollection<string> stringCollection = new MyCollection<string>();

            stringCollection.AddItem("Hello");
            stringCollection.AddItem("World");
            stringCollection.AddItem("Generic");

            Console.WriteLine(stringCollection.GetItem(0)); 
            Console.WriteLine(stringCollection.GetItem(1)); 
            Console.WriteLine(stringCollection.GetItem(2)); 
        } */
    }
}
