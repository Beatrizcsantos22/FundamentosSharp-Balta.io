using System;
using System.Globalization;

namespace FormatandoMoedas
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Clear();
             
        
            decimal valor = 10.25m;
            Console.WriteLine("Inglaterra:");
            Console.Write(valor.ToString(CultureInfo.CreateSpecificCulture("en-UK")));

            Console.WriteLine("");
            Console.WriteLine("Brasil:");
            Console.Write(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR")));

            // temos o G que fica com a virgula apenas, o C que formata de maneira completa e o F que não separa caso seja numero grande porem de uma virgula. O p deixa em porcentagem.
        }
    }
}