namespace variables
{
    internal class Program
    {
        //writng comments in C#:
        // this is a single line comment

        /* this is a*
        /* multi line comment
        */
        static void Main(string[] args)
        {
            // 1. Explicit types:
            //declaring variables in C#:
            //int, float, double, ahort, long, decimal, bool, char >> value types, that is sorted as stack
            int a = 10; //integer
            float b = 10.5f; //float
            double c = 10.5; //double
            char d = 'A'; //char

            //string, object, dynamic >> reference types, that is sorted as heap
            string name = "John"; //string
            object obj = new object(); //object
            dynamic dyn = 10; //dynamic

            //declaring constants in C#:
            const int x = 10; //constant

            // 2. Implicit typing with 'var'
            //var is used to declare variables without specifying the type
            var e = 20; //var
            var f = 20.5f; //var
            var g = "Ahmad"; //var

            // 3. Mutable variables: any non-const variable can be reassigned:
            a = 20; //reassigning value to variable
            b = 30.5f; //reassigning value to variable
            c = 40.5; //reassigning value to variable

            // 4. Nullable types:
            //nullable types are used to represent value types that can be null
            int? h = null; //nullable int
            float? i = null; //nullable float
            double? j = null; //nullable double

            // 5. Tuples:
            //tuples are used to group multiple values into a single value
            var tuple = (1, "John", 10.5); //tuple
            Console.WriteLine($"Tuple: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}"); //printing tuple values

            // 6. Arrays:
            //arrays are used to store multiple values of the same type
            int[] arr = new int[5]; //array of integers
            arr[0] = 1; //assigning value to array
            arr[1] = 2; //assigning value to array
            arr[2] = 3; //assigning value to array
            Console.WriteLine(arr[2]);

            // 7. Lists:
            //lists are used to store multiple values of the same type
            List<int> list = new List<int>(); //list of integers
            list.Add(1); //adding value to list
            list.Add(2); //adding value to list
            list.Add(3); //adding value to list

            // 8. Dictionaries:
            //dictionaries are used to store key-value pairs
            Dictionary<int, string> dict = new Dictionary<int, string>(); //dictionary of integers and strings
            dict.Add(1, "John"); //adding key-value pair to dictionary
            dict.Add(2, "Doe"); //adding key-value pair to dictionary
            dict.Add(3, "Smith"); //adding key-value pair to dictionary

            // 9. Strings:
            //strings are used to store text values
            string str = "Hello, World!"; //string
            Console.WriteLine(str); //printing string value

            // 10. String interpolation:
            //string interpolation is used to format strings
            string name1 = "John"; //string
            int age = 30; //integer
            string str1 = $"My name is {name1} and I am {age} years old."; //string interpolation
            Console.WriteLine(str1); //printing string interpolation value

            // 11. String concatenation:
            //string concatenation is used to combine strings
            string str2 = "Hello"; //string
            string str3 = "World"; //string
            string str4 = str2 + " " + str3; //string concatenation
            Console.WriteLine(str4); //printing string concatenation value

            // 12. String formatting:
            //string formatting is used to format strings
            string str5 = "Hello, {0}"; //string formatting
            string str6 = string.Format(str5, "World"); //string formatting
            Console.WriteLine(str6); //printing string formatting value

            // 13. String methods:
            //string methods are used to manipulate strings
            string str7 = "Hello, World!"; //string
            string str8 = str7.ToUpper(); //string method
            Console.WriteLine(str8); //printing string method value

            // 14. String comparison:
            //string comparison is used to compare strings
            string str9 = "Hello"; //string
            string str10 = "Hello"; //string
            bool isEqual = str9 == str10; //string comparison
            Console.WriteLine(isEqual); //printing string comparison value

            // 15. String length:
            //string length is used to get the length of a string
            string str11 = "Hello"; //string
            int length = str11.Length; //string length
            Console.WriteLine(length); //printing string length value

            // 16. String index:
            //string index is used to get the index of a character in a string
            string str12 = "Hello"; //string
            int index = str12.IndexOf('e'); //string index
            Console.WriteLine(index); //printing string index value

            // 17. String substring:
            //string substring is used to get a substring of a string
            string str13 = "Hello, World!"; //string
            string str14 = str13.Substring(0, 5); //string substring
            Console.WriteLine(str14); //printing string substring value

            // 18. String replace:
            //string replace is used to replace a substring in a string
            string str15 = "Hello, World!"; //string
            string str16 = str15.Replace("World", "C#"); //string replace
            Console.WriteLine(str16); //printing string replace value

            // 19. String split:
            //string split is used to split a string into an array of strings
            string str17 = "Hello, World!"; //string
            string[] str18 = str17.Split(','); //string split
            Console.WriteLine(str18[0]); //printing string split value
            Console.WriteLine(str18[1]); //printing string split value

            // 20. String join:
            //string join is used to join an array of strings into a single string
            string[] str19 = { "Hello", "World" }; //array of strings
            string str20 = string.Join(" ", str19); //string join
            Console.WriteLine(str20); //printing string join value
               
        }
    }
}
