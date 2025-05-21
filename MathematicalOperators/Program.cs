namespace MathematicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mathematical operators in C#:

            // 1) basic arithmetic operators:
            int a = 10; //int
            int b = 20; //int
            int sum = a + b; //addition
            int difference = a - b; //subtraction
            int product = a * b; //multiplication
            int quotient = a / b; //division
            int remainder = a % b; //modulus
            Console.WriteLine($"Sum: {sum}"); //printing sum
            Console.WriteLine($"Difference: {difference}"); //printing difference
            Console.WriteLine($"Product: {product}"); //printing product
            Console.WriteLine($"Quotient: {quotient}"); //printing quotient
            Console.WriteLine($"Remainder: {remainder}"); //printing remainder
            Console.ReadKey(); //waiting for key press

            // 2) increment and decrement operators:
            int x = 10; //int
            Console.WriteLine($"x: {x}"); //printing x
            x++; //increment
            Console.WriteLine($"x after increment: {x}"); //printing x after increment
            x--; //decrement
            Console.WriteLine($"x after decrement: {x}"); //printing x after decrement
            Console.ReadKey(); //waiting for key press

            // 3) unary operators:
            int y = 10; //int
            Console.WriteLine($"y: {y}"); //printing y
            Console.WriteLine($"y after unary plus: {+y}"); //printing y after unary plus
            Console.WriteLine($"y after unary minus: {-y}"); //printing y after unary minus
            Console.ReadKey(); //waiting for key press

            // 4) compound assignment operators:
            int z = 10; //int
            Console.WriteLine($"z: {z}"); //printing z
            z += 5; //addition assignment
            Console.WriteLine($"z after addition assignment: {z}"); //printing z after addition assignment
            z -= 5; //subtraction assignment
            Console.WriteLine($"z after subtraction assignment: {z}"); //printing z after subtraction assignment
            z *= 5; //multiplication assignment
            Console.WriteLine($"z after multiplication assignment: {z}"); //printing z after multiplication assignment
            z /= 5; //division assignment
            Console.WriteLine($"z after division assignment: {z}"); //printing z after division assignment
            Console.WriteLine($"z after modulus assignment: {z %= 5}"); //printing z after modulus assignment
            Console.ReadKey(); //waiting for key press

            // 5) comparison operators:
            int p = 10; //int
            int q = 20; //int
            Console.WriteLine($"p: {p}"); //printing p
            Console.WriteLine($"p == q: {p == q}"); //printing p == q
            Console.WriteLine($"p != q: {p != q}"); //printing p != q
            Console.WriteLine($"p > q: {p > q}"); //printing p > q
            Console.WriteLine($"p < q: {p < q}"); //printing p < q
            Console.WriteLine($"p >= q: {p >= q}"); //printing p >= q
            Console.WriteLine($"p <= q: {p <= q}"); //printing p <= q
            Console.ReadKey(); //waiting for key press


            // 6) logical operators:
            bool isTrue = true; //bool
            bool isFalse = false; //bool
            Console.WriteLine($"isTrue: {isTrue}"); //printing isTrue
            Console.WriteLine($"isFalse: {isFalse}"); //printing isFalse
            Console.WriteLine($"isTrue && isFalse: {isTrue && isFalse}"); //printing isTrue && isFalse
            Console.WriteLine($"isTrue || isFalse: {isTrue || isFalse}"); //printing isTrue || isFalse
            Console.WriteLine($"!isTrue: {!isTrue}"); //printing !isTrue
            Console.WriteLine($"!isFalse: {!isFalse}"); //printing !isFalse
            Console.ReadKey(); //waiting for key press

        }
    }
}
