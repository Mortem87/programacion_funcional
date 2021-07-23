using System;
using System.Collections.Generic;
using System.Linq;

namespace cap_prog_func
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://sodocumentation.net/csharp/topic/46/lambda-expressions
            //https://www.eslomas.com/2008/02/programacion-funcional-en-c/
            //https://ed.team/blog/programacion-funcional-en-c
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/expression-trees/
            //Example_One();
            //Example_Two();
            //Example_Three();
            //Example_Four();
            //Example_Five();
            Example_Six();

        }

        public static void Example_One() 
        {

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            numbers.ForEach(number => Console.Write(number));
            // Output:
            // 123
        }
        public static void Example_Two() 
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            List<int> filteredNumbers = numbers.Where(number => number > 3).ToList();

            filteredNumbers.ForEach(number => Console.WriteLine(number));
            // Output:
            // 4
            // 5
        }
        public static void Example_Three() 
        {
            List<string> words = new List<string>();
            words.Add("Alejandro");
            words.Add("Ingrid");
            words.Add("EDteam");
            words.Add("EXteam");

            string education = words.Find(word => word.Contains("team"));

            Console.Write(education);
            // Output:
            // EDteam
        }
        public static void Example_Four() 
        {
            List<string> words = new List<string>();
            words.Add("Alejandro");
            words.Add("Ingrid");
            words.Add("EDteam");
            words.Add("EXteam");

            bool result_one = words.Exists(word => word.Contains("Ingrid"));

            bool result_two = words.Exists(word => word.Contains("Bolivia"));

            Console.WriteLine(result_one);
            Console.WriteLine(result_two);

            // Output:
            // True
            // False
        }
        public static void Example_Five() 
        {
            
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            
            // Output:
            //4 9 16 25

        }
        public static void Example_Six() 
        {
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x / x;
            Console.WriteLine(e);
            // Output:
            // x => (x * x)
        }
        public static void Example_Seven() 
        {
            int[] numbers = { 2, 3, 4, 5 };

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x / x;


            var squaredNumbers = numbers.Select(x => x * x);



            Console.WriteLine(string.Join(" ", squaredNumbers));
        }
    }
}
