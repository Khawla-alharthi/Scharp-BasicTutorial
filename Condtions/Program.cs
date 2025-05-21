namespace Condtions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditions in C#:
            // 1) if statement: If you're checking different expressions or conditions, use if.
            int a = 10; //int
            int b = 20;
            int c = 30;
            if (a > b) //if statement
            {
                Console.WriteLine("a is greater than b"); //printing output to console
            }
            else if (a < b) //else if statement
            {
                Console.WriteLine("a is less than b"); //printing output to console
            }
            else //else statement
            {
                Console.WriteLine("a is equal to b"); //printing output to console
            }

            // 2) switch statement: If you're checking one variable against fixed values, use switch.
            int day = 3; //int
            int month = 4;
            int year = 5;
            switch (day) //switch statement
            {
                case 1: //case 1
                    Console.WriteLine("Monday"); //printing output to console
                    break; //break statement
                case 2: //case 2
                    Console.WriteLine("Tuesday"); //printing output to console
                    break; //break statement
                case 3: //case 3
                    Console.WriteLine("Wednesday"); //printing output to console
                    break; //break statement
                default: //default case
                    Console.WriteLine("Invalid day"); //printing output to console
                    break; //break statement
            }

            // 3) ternary operator:
            int x = 10; //int
            int y = 20; //int
            int max = (x > y) ? x : y; //ternary operator
            Console.WriteLine($"Max: {max}"); //printing output to console

            // 4) null-coalescing operator:
            string str = null; //string
            string result = str ?? "Default value"; //null-coalescing operator
            Console.WriteLine($"Result: {result}"); //printing output to console

            // 5) null-conditional operator:
            string name = null; //string
            int? length = name?.Length; //null-conditional operator
            Console.WriteLine($"Length: {length}"); //printing output to console
            

        }
    }
}
