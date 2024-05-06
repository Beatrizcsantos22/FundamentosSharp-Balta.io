using System;
using Microsoft.VisualBasic;

namespace DataTimeSpam
{
    class Program
    {
        static void Main(string[]args)
        {
             Console.Clear();
                  
                 
             var timeSpan = new TimeSpan();  // Unidade de medida em horas, pega fração de horas 
             Console.WriteLine(timeSpan);

             var timeSpanNanoSegundos = new TimeSpan(1);
             Console.WriteLine(timeSpanNanoSegundos); // 00:00:00.0000001

             var timeSpanHoraMinutoSegundo = new TimeSpan(5,12,8); // Inserindo uma hora, criando 05:12:08
              Console.WriteLine(timeSpanHoraMinutoSegundo);
              
              // são usados para calcular o tipo data
              
              Console.WriteLine("");
              Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanNanoSegundos);
              Console.WriteLine(timeSpanHoraMinutoSegundo.Days);
              
            

        }
    }
}