using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exercise 5: Vehicle ===");
        Vehicle car = new Car();
        Vehicle bike = new Motorcycle();
        car.StartEngine();
        car.StopEngine();
        bike.StartEngine();
        bike.StopEngine();

        Console.WriteLine("\n=== Exercise 6: Shape ===");
        Circle c = new Circle { Radius = 4 };
        Rectangle r = new Rectangle { Width = 3, Height = 5 };
        c.Display();
        r.Display();

        Console.WriteLine("\n=== Exercise 7: Appliance ===");
        Appliance[] appliances = { new WashingMachine(), new Refrigerator() };
        foreach (var a in appliances)
        {
            a.Operate();
        }

        Console.WriteLine("\n=== Exercise 8: Account ===");
        SavingsAccount s = new SavingsAccount { AccountNumber = "S100", Balance = 2000 };
        CheckingAccount ch = new CheckingAccount { AccountNumber = "C200", Balance = 1500 };
        s.DisplayAccountInfo();
        Console.WriteLine("Interest: " + s.CalculateInterest());
        ch.DisplayAccountInfo();
        Console.WriteLine("Interest: " + ch.CalculateInterest());

        Console.WriteLine("\n--- End of Lab 3 Output ---");
    }
}
