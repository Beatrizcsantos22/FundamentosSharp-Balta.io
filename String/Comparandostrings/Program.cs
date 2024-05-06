using System;

namespace App.Funcionario
{
    class Program()
    {
        static void Main(string[] args)
        {
            var text = "I am student in computer science";
            Console.WriteLine(text.CompareTo("i am student in computer science"));
            //Quando há uma string diferente da outra ele diferencia, no caso apareceu 1.

            // o Contains, ele irá dar verdadeiro ou falso se existe a palavra no text que foi escrita ou não
            Console.WriteLine(text.Contains("am"));
            //Aqui ignora o fato de começar com maiscula ou miniscula, se tiver é true.
            Console.WriteLine(text.Contains("Am", StringComparison.OrdinalIgnoreCase));

        }
    }
}
