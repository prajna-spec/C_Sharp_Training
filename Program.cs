using System;

namespace ConsoleApp
{
    class Program
    {
        // Move variable declarations to class level
        string a = "Mercedes Benz";
        string b = "Prajna";
        int year = 2001;

        static void Main(string[] args)
        {
            // Learn the variables section first
            string one = "one";
            bool flag = true;
            int a = 5;

            string[] strs = { "one", "two", "three" };

            // Declare implicit variables
            var b = 10; // Rename this variable to avoid conflict
            var c = "prajna";
            int x = 10, y = 10;
            Console.WriteLine(x + y);

            // This is used to print the statements
            Console.WriteLine("one: {0}, flag: {1}, a: {2}, strs[0]: {3}, strs[1]: {4}, strs[2]: {5}, b: {6}, c: {7}", one, flag, a, strs[0], strs[1], strs[2], b, c);

            // Wait for user input to keep the console window open
            Console.ReadLine();
            
            // ?? operator
            string str = null;
            // If the string is not null, it will print "Unknown Value", else it will print the value of the string.
            Console.WriteLine(str ?? "Unknown Value");
            // Assign a value depending if a string is null or not.
           

            string Inputstr = "";
            while (Inputstr != "exit")
            {
                Console.WriteLine("Enter a number:");
                Inputstr = Console.ReadLine();
            }

            // Strings section in c#.
            string str_1 = "prajna";
            string year="2001";
            Console.WriteLine($"{str_1} is amazing!");

            // How to write xml embedded comments.
            // Use three comment lines
            // How to format these strings
            Console.WriteLine($"{c} is a wonderful girl. She is born in {year}");
            // What are string builders and why are they important?
            // function definition in c#

            float test_function(float miles)
            {
                float result=miles*1.6f;
                return result;
            }
            
            
            Console.WriteLine($"The number of miles to km is {test_function(10)}");
        }
    }
}
