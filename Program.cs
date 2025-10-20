using System;

namespace Lab1_AdvancedProgramming
{
    // Car class
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }

        // constructor sets values
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            MakeYear = year;
        }

        public void ShowCar()
        {
            Console.WriteLine("Car Details: " + Brand + " " + Model + " (" + MakeYear + ")");
        }

        public void TurnOn()
        {
            Console.WriteLine("The car is on.");
        }
    }

    // Book class
    class Book
    {
        public string Title { get; set; } = "Unknown";
        public string Author { get; set; } = "Unknown";
        public int Pages { get; set; }

        public void Read()
        {
            Console.WriteLine("Reading: " + Title + " written by " + Author);
        }
    }

    // Person class
    class Person
    {
        public string Name { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public int Age { get; set; } = 30;

        public void DisplayPerson()
        {
            Console.WriteLine("Person Info: " + Name + " " + LastName + " from Age " + Age);
        }
    }

    // Calculator
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    // Static counter
    class ClickCounter
    {
        private static int totalClicks = 0;

        public void Click()
        {
            totalClicks++;
        }

        public static int GetClicks()
        {
            return totalClicks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Car
            Car testCar = new Car("Bentley", "Spyder", 2025);
            testCar.ShowCar();
            testCar.TurnOn();

            Console.WriteLine();

            // Book
            Book favBook = new Book { Title = "Spiderman", Author = "Stan Lee", Pages = 75 };
            favBook.Read();

            Console.WriteLine();

            // Person
            Person testPerson = new Person();
            testPerson.DisplayPerson();

            Console.WriteLine();

            // Calculator
            Calculator calculator = new Calculator();
            Console.WriteLine("Add two ints: " + calculator.Add(4, 5));
            Console.WriteLine("Add three ints: " + calculator.Add(1, 2, 3));
            Console.WriteLine("Add four ints: " + calculator.Add(10, 20, 30, 40));

            Console.WriteLine();

            // Static counter
            ClickCounter c1 = new ClickCounter();
            ClickCounter c2 = new ClickCounter();
            c1.Click();
            c2.Click();
            Console.WriteLine("Total Clicks: " + ClickCounter.GetClicks());

            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }
    }
}
