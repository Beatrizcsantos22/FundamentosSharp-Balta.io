using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "it text is a test";

            //StartWith -> Começa como maisculo/minusculo
            // é booleano false and true.

            Console.WriteLine(text.StartsWith("It"));
            Console.WriteLine(text.StartsWith("it"));
            Console.WriteLine(text.StartsWith("text"));


            Console.WriteLine(text.EndsWith("test"));
            Console.WriteLine(text.EndsWith("Test"));
            Console.WriteLine(text.EndsWith("xpro"));

        }
    }
}
