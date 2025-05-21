using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Access Modifiers in C#:
            // 1) Public: Accessible from anywhere in the program.
            Console.WriteLine("Public: Accessible from anywhere in the program.");

            // 2) Private: Accessible only within the class where it is declared.
            Console.WriteLine("Private: Accessible only within the class where it is declared.");

            // 3) Protected: Accessible within the class and by derived classes.
            Console.WriteLine("Protected: Accessible within the class and by derived classes.");

            // 4) Internal: Accessible only within the same assembly (project).
            Console.WriteLine("Internal: Accessible only within the same assembly (project).");

            // 5) Protected Internal: Accessible within the same assembly and by derived classes.
            Console.WriteLine("Protected Internal: Accessible within the same assembly and by derived classes.");

            // 6) Private Protected: Accessible only within the same class and by derived classes in the same assembly.
            Console.WriteLine("Private Protected: Accessible only within the same class and by derived classes in the same assembly.");

            // 7) Static: Belongs to the class itself rather than to any specific instance.
            Console.WriteLine("Static: Belongs to the class itself rather than to any specific instance.");

            // 8) Readonly: Can only be assigned a value at the time of declaration or in the constructor.
            Console.WriteLine("Readonly: Can only be assigned a value at the time of declaration or in the constructor.");

            // 9) Const: A constant value that cannot be changed after it is declared.
            Console.WriteLine("Const: A constant value that cannot be changed after it is declared.");

           
        }

        // Example of Access Modifiers:
        public int num { get; set; } // Accessible anywhere
        private int num2 { get; set; } // accessible inside the class
        protected int num3 { get; set; } // accessible in derived class
        internal int num4 { get; set; } // Works inside same assembly/project
        protected internal int num5 { get; set; } //Accessible within the same assembly OR from derived classes outside assembly.
        private protected int num6 { get; set; } //Accessible only within the containing class or derived classes inside the same assembly.
        static int num7 { get; set; } // belongs to the class itself


    }
}
