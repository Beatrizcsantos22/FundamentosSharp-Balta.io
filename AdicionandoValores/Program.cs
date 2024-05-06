using System;

namespace AdicionandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            Console.WriteLine(data);

            // Para acrescentar algo na sua data, seja um ano, dia, mes ...


            Console.WriteLine(data.AddDays(12)); // acrescentou 12 dias a mais
            Console.WriteLine(data.AddMonths(1)); // acrescentou 1 mes a mais
            Console.WriteLine(data.AddYears(1)); // acrescentou um ano a mais

            // Para horas usa- se também o add.

        }
    }
}