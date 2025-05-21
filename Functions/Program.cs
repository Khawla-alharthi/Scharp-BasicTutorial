namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Functions in C#:

            // 1) Function with no parameters and no return value:
            void PrintHello()
            {
                Console.WriteLine("Hello, World!"); //printing output to console
            }
            PrintHello(); //calling function

            // 2) Function with parameters and no return value:
            void PrintName(string name)
            {
                Console.WriteLine($"Hello, {name}!"); //printing output to console
            }
            PrintName("John"); //calling function
            PrintName("Jane"); //calling function

            // 3) Function with parameters and a return value:
            int Add(int a, int b)
            {
                return a + b; //returning sum of a and b
            }
            int sum = Add(5, 10); //calling function
            Console.WriteLine($"Sum: {sum}"); //printing output to console

            // 4) Function with optional parameters:
            void PrintInfo(string name, int age = 30)
            {
                Console.WriteLine($"Name: {name}, Age: {age}"); //printing output to console
            }
            PrintInfo("John"); //calling function with optional parameter
            PrintInfo("Jane", 25); //calling function with optional parameter

            // 5) Function with named parameters:
            void PrintDetails(string name, int age)
            {
                Console.WriteLine($"Name: {name}, Age: {age}"); //printing output to console
            }
            PrintDetails(age: 25, name: "John"); //calling function with named parameters
            PrintDetails(name: "Jane", age: 30); //calling function with named parameters

            // 6) Function with variable number of parameters:
            void PrintNumbers(params int[] numbers)
            {
                foreach (int number in numbers) //foreach loop
                {
                    Console.WriteLine($"Number: {number}"); //printing output to console
                }
            }
            PrintNumbers(1, 2, 3, 4, 5); //calling function with variable number of parameters
            PrintNumbers(10, 20, 30); //calling function with variable number of parameters

        }
    }
}
