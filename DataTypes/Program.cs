using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // data types in C#:

            // primitives (value type):
            // byte: 8 bits, 0 to 255
            byte b = 255; //byte
            // sbyte: 8 bits, -128 to 127
            sbyte sb = -128; //sbyte
            // short: 16 bits, -32,768 to 32,767
            short s = -32768; //short
            // ushort: 16 bits, 0 to 65,535
            ushort us = 65535; //ushort
            // int: 32 bits, -2,147,483,648 to 2,147,483,647
            int i = -2147483648; //int
            // uint: 32 bits, 0 to 4,294,967,295
            uint ui = 4294967295; //uint
            // long: 64 bits, -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long l = -9223372036854775808; //long
            // ulong: 64 bits, 0 to 18,446,744,073,709,551,615
            ulong ul = 18446744073709551615; //ulong
            // float: 32 bits, -3.402823E+38 to 3.402823E+38
            float f = 3.402823E+38f; //float
            // double: 64 bits, -1.79769313486232E+308 to 1.79769313486232E+308
            double d = 1.79769313486232E+308; //double
            // decimal: 128 bits, -79,228,162,514,264,337,593,543,950,335 to 79,228,162,514,264,337,593,543,950,335
            decimal dec = 79_228_162_514_264_337_593_543_950_335m; //decimal
            // char: 16 bits, 0 to 65,535
            char c = 'A'; //char
            // bool: 1 bit, true or false
            bool bl = true; //bool


            // non-primitives (reference type):
            // in C#, there are 3 non-primitive data types:
            string str = "Hello, World!"; //string
            // object: 32 bits, -2,147,483,648 to 2,147,483,647
            object obj = new object(); //object
            // dynamic: 32 bits, -2,147,483,648 to 2,147,483,647
            dynamic dyn = 10; //dynamic


            // Primitives (Value Types) — passed by value
            int age = 25; //int
            string name = "John"; //string
            bool isMarried = false; //bool
            // string interpolation
            Console.WriteLine($"My name is {name} and I am {age} years old. Am I married? {isMarried}"); //string interpolation


            // Reference Types — passed by reference
            // 1) Simple object via a custom class
            // Reference type example - custom object
            var personalInfo = new Person
            {
                Id = 1,
                Name = "Ahmed",
                Age = 27,
                IsMarried = false
            };

            Console.WriteLine($"Person: {personalInfo.Name}, Age: {personalInfo.Age}, Married: {personalInfo.IsMarried}");

            // Arrays
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 89 };
            string[] arr2 = { "usif", "usif", "usif", "usif", "usif" };

            // Array of objects
            Person[] arr3 =
            {
                new Person { Id = 1, Name = "Ahmed", Age = 27, IsMarried = false },
                new Person { Id = 2, Name = "Fatima", Age = 30, IsMarried = true  }
            };
            Console.WriteLine($"First person in array: {arr3[0].Name}");
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
    }

}

