using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "It text is a test";

            //Equals - Igual, faz comparação do texto todo .
            // Utilizado na parte de interface também.

            Console.WriteLine(text.Equals("It text is a test"));

            Console.WriteLine(text.Equals("it text is a test", StringComparison.OrdinalIgnoreCase));
            // ficará true, pois converte para igual automático.
        }
    }
}
