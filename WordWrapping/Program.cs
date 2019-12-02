using System;
using WordWrapping;

namespace WordWrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapping wrap = new Wrapping();

            string result = wrap.Wrap("Hello there, how are you today?", 10);

            Console.WriteLine(result);
            Console.ReadLine();
           
        }
    }
}
