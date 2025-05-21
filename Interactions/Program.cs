namespace Interactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interaction in C#:
            // 1) Console.ReadLine() - reads a line of input from the console
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); //reading input from console
            Console.WriteLine($"Hello, {name}!"); //printing output to console

            // 2) Console.ReadKey() - reads a single key press from the console
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); //waiting for key press
            Console.WriteLine("You pressed a key!"); //alert printing output to console
            Console.ReadKey();

            // 3) Console.Read() - reads a single character from the console
            Console.WriteLine("Press any key to continue...");
            int key = Console.Read(); //reading single character from console
            Console.WriteLine($"You pressed the key with ASCII value: {key}"); //printing output to console
            Console.ReadKey();

            // 4) Console.ReadLine() with parsing - reads a line of input from the console and parses it to a specific type
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine(); //reading input from console
            int age;
            Console.ReadKey();
            // parsing input to int
            Console.WriteLine($"Your age is: {(int.TryParse(ageInput, out age) ? age.ToString() : "Invalid input")}"); //printing output to console
            Console.ReadKey();
            Console.WriteLine($"Your age is: {(int.TryParse(ageInput, out age) ? age.ToString() : "Invalid input")}"); //printing output to console
            Console.ReadKey();

            // 5) Console.Write() - writes output to the console without a new line
            Console.Write("Hello, "); //printing output to console
            Console.Write("World!"); //printing output to console
            Console.WriteLine(); //printing new line to console

            // 6) Console.WriteLine() - writes output to the console with a new line
            Console.WriteLine("Hello, World!"); //printing output to console

            // 7) Console.WriteLine() with formatting - writes output to the console with formatting
            Console.WriteLine("Hello, {0}!", name); //printing output to console
            Console.ReadKey();
            Console.WriteLine("Hello, {0}! You are {1} years old.", name, age); //printing output to console
            Console.ReadKey();

            // 8) Console.WriteLine() with string interpolation - writes output to the console with string interpolation
            Console.WriteLine($"Hello, {name}! You are {age} years old."); //printing output to console
            Console.ReadKey();

        }
    }
}
