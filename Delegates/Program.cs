namespace Delegates
{

    public delegate void GreetDelegate(string name);

    public delegate int SquareDelegate(int number);

    public delegate void PrintDelegate(string message);


    internal class Program
    {

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static int Square(int number)
        {
            return number * number;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            // Delegates in C#:
            GreetDelegate greet = SayHello; // Assign method to delegate
            greet("John"); // Invoke delegate (calls SayHello)

            SquareDelegate square = Square; // Assign method to delegate
            int result = square(5); // Invoke delegate (calls Square)

            Console.WriteLine($"Square: {result}"); // Print result
            PrintDelegate print = PrintMessage; // Assign method to delegate
            print("Hello, World!"); // Invoke delegate (calls PrintMessage)


        }
    }

}
