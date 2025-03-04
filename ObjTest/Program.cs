using System.Diagnostics;

namespace ObjTest;

internal class Program
{
    static void Main(string[] args)
    {
        VendingMachine vendingMachine = new AnimalFeedVendingMachine();
        //AnimalFeedVendingMachine vendingMachines = new VendingMachine();
        Console.WriteLine(vendingMachine.GetType().Name);
        Console.WriteLine(vendingMachine.Dispense(2.00M));
        /*
         * while (true)
        {
            Bird bird;
            Console.Write("\nPress P for pigeon, O for ostrich: ");
            char key = Char.ToUpper(Console.ReadKey().KeyChar);
            if (key == 'P') bird = new Pigeon();
            else if (key == 'O') bird = new Ostrich();
            else return;
            Console.Write("\nHow many eggs should it lay? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
            Egg[] eggs = bird.LayEggs(numberOfEggs);
            foreach (Egg egg in eggs)
            {
                Console.WriteLine(egg.Description);
            }
        }
        Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
        HiLoGame.Hint();
        while (HiLoGame.GetPot() > 0)
        {
            Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
            Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'h') HiLoGame.Guess(true);
            else if (key == 'l') HiLoGame.Guess(false);
            else if (key == '?') HiLoGame.Hint();
            else return;
        }
        Console.WriteLine("The pot is empty. Bye!");

        Console.WriteLine("How many bullets?");
        int.TryParse(Console.ReadLine(), out int bullets);
        Console.WriteLine("Magazine size?");
        int.TryParse(Console.ReadLine(), out int magazineSize);
        Console.Write($"Loaded [false]: ");
        bool.TryParse(Console.ReadLine(), out bool isLoaded);

        PaintballGun gun = new PaintballGun(bullets, magazineSize, isLoaded);
        while (true)
        {
            Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
            if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo");
            Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
            char key = Console.ReadKey(true).KeyChar;
            if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
            else if (key == 'r') gun.Reload();
            else if (key == '+') gun.Balls += gun.MagazineSize;
            else if (key == 'q') return;
        }
        
        Guy joe = new Guy() { Cash = 50, Name = "Joe" };
        Guy bob = new Guy() { Cash = 100, Name = "Bob" };

        if (0.1F + 0.2F == 0.3F) Console.WriteLine("They're equal");
        else Console.WriteLine("They aren't equal");

        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        Random random = new Random();
        int dieRoll = random.Next(1, 7);
        Console.WriteLine(dieRoll);

        double randomDouble = random.NextDouble();
        Console.WriteLine((float)randomDouble * 100F);
        Console.WriteLine((decimal)randomDouble * 100M);

        var arr = new string[]
        {
            "ab",
            "cd",
            "ef"
        };
        var randomString = random.Next(arr.Length);
        Console.WriteLine(arr[randomString]);
        Debug.WriteLine(arr[randomString]);

        while (true)
        {
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You pressed 1");
                Console.WriteLine("Calling lloyd.WhoAmI()");
                lloyd.WhoAmI();
            }
            else if (input == "2")
            {
                Console.WriteLine("You pressed 2");
                Console.WriteLine("Calling lucinda.WhoAmI()");
                lucinda.WhoAmI();
            }
            else if (input == "3")
            {
                (lucinda, lloyd) = (lloyd, lucinda);
                Console.WriteLine("References have been swapped");
            } else return;
        }*/
    }
}
