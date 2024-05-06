using System;


namespace MathApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Clear();
           
           decimal value = 1678.10m;
          
          // Math Round - tira o que tem depois da virgula(inteiro).
           Console.WriteLine( Math.Round(value) );
           Console.WriteLine( Math.Ceiling(value)); //  Arredonda para cima
           Console.WriteLine( Math.Floor(value)); // Arredonda para baixo
        }
    }
}