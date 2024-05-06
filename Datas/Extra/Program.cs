using System;

namespace ExtraRevisao
{
    class Program 
    {
        static void Main(string[]args)
        {      
               Console.WriteLine(IsWekeed(DateTime.Now.DayOfWeek));
               Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // Se agora está em horário de verão

        }

        static bool IsWekeed(DayOfWeek today) // DayOfWeek -  Dias da semana, ele possui uma Lista com todos os dias da semana.
        {
            // se é sabado ou se é domingo
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
