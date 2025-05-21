namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOP in C#:

            // 1) Class: A blueprint for creating objects, containing properties and methods.
            Console.WriteLine("Class: A blueprint for creating objects, containing properties and methods.");

            // 2) Object: An instance of a class, representing a specific entity with its own state and behavior.
            Console.WriteLine("Object: An instance of a class, representing a specific entity with its own state and behavior.");

            // 3) Encapsulation: The bundling of data (properties) and methods (functions) that operate on the data into a single unit (class).
            Console.WriteLine("Encapsulation: The bundling of data (properties) and methods (functions) that operate on the data into a single unit (class).");
            
            // 4) Inheritance: The mechanism by which one class (child class) can inherit the properties and methods of another class (parent class).
            Console.WriteLine("Inheritance: The mechanism by which one class (child class) can inherit the properties and methods of another class (parent class).");
            
            // 5) Polymorphism: The ability of different classes to be treated as instances of the same class through a common interface.
            Console.WriteLine("Polymorphism: The ability of different classes to be treated as instances of the same class through a common interface.");
            
            // 6) Abstraction: The concept of hiding the complex implementation details and showing only the essential features of the object.
            Console.WriteLine("Abstraction: The concept of hiding the complex implementation details and showing only the essential features of the object.");
            
            // 7) Interface: A contract that defines a set of methods and properties that a class must implement.
            Console.WriteLine("Interface: A contract that defines a set of methods and properties that a class must implement.");
            
            // 8) Abstract class: A class that cannot be instantiated and can contain abstract methods (without implementation) and concrete methods (with implementation).
            Console.WriteLine("Abstract class: A class that cannot be instantiated and can contain abstract methods (without implementation) and concrete methods (with implementation).");
            
            // 9) Constructor: A special method that is called when an object is created, used to initialize the object's properties.
            Console.WriteLine("Constructor: A special method that is called when an object is created, used to initialize the object's properties.");

        }
    }

    // EXAMPLE: Encapsulation => Hiding the internal state of an object and requiring all interaction to be performed through methods.
    public class BankAccount
    {
        private decimal balance; // hidden from outside

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    //----------------------------------------------------
    //EXAMPLE: Inheritance => Allows a class to inherit properties and methods from another class.
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    //----------------------------------------------------
    //EXAMPLE: Polymorphism => Means "many forms". Allows methods to behave differently based on the object that invokes them.
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }

    //----------------------------------------------------
    //EXAMPLE: Abstraction => Hiding complex details and exposing only the necessary parts through abstract classes or interfaces.
    public abstract class Shapes
    {
        public abstract double GetArea();
    }

    public class CircleArea : Shapes
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
}
