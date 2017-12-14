using System;

namespace SampleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var q = new Quiz();

            var list = q.GetRandomQuestionsFromBank("A");

            foreach(var x in list)
            {
                Console.WriteLine($"{x.Question} ");
            }
        }
    }
}
