namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Iterations in C#:

            // 1) for loop: Repeats a block of code a set number of times using a counter (i).
            for (int i = 0; i < 5; i++) //for loop
            {
                Console.WriteLine($"Iteration {i}"); //printing output to console
            }

            // 2) while loop: Repeats a block of code a set number of times using a counter (i).
            int j = 0; //int
            while (j < 5) //while loop
            {
                Console.WriteLine($"Iteration {j}"); //printing output to console
                j++; //incrementing j
            }

            // 3) do while loop: Runs the code block at least once, then repeats it while the condition remains true.
            int k = 0; //int
            do //do while loop
            {
                Console.WriteLine($"Iteration {k}"); //printing output to console
                k++; //incrementing k
            } while (k < 5); //while condition

            // 4) foreach loop: Loops through an array using an index to access and display each item.
            string[] names = { "John", "Jane", "Doe" }; //string array
            foreach (string name in names) //foreach loop
            {
                Console.WriteLine($"Name: {name}"); //printing output to console
            }

            // 5) for each loop with index: Stops the loop immediately when a specific condition is met (when m == 3).
            for (int l = 0; l < names.Length; l++) //for each loop with index
            {
                Console.WriteLine($"Name: {names[l]}"); //printing output to console
            }

            // 6) for loop with break: Skips the current iteration (when n == 3) and continues with the next one.
            for (int m = 0; m < 5; m++) //for loop with break
            {
                if (m == 3) //if condition
                {
                    break; //break statement
                }
                Console.WriteLine($"Iteration {m}"); //printing output to console
            }

            // 7) for loop with continue:
            for (int n = 0; n < 5; n++) //for loop with continue
            {
                if (n == 3) //if condition
                {
                    continue; //continue statement
                }
                Console.WriteLine($"Iteration {n}"); //printing output to console
            }

        }
    }
}
