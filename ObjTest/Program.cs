namespace ObjTest;

internal class Program
{
    static void Main(string[] args)
    {
        Guy joe = new Guy() { Cash = 50, Name = "Joe" };
        Guy bob = new Guy() { Cash = 100, Name = "Bob" };

        if (0.1F + 0.2F == 0.3F) Console.WriteLine("They're equal");
        else Console.WriteLine("They aren't equal");

        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

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
        }
    }
}
