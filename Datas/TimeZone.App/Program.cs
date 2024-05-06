using System;
using System.Data;
using System.Globalization;
using Microsoft.VisualBasic;

namespace TimeZone.App
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.Clear();

            var dateUtc = DateTime.UtcNow; // Universe Time Now - Formato de data Universal

            var dateNow = DateTime.Now; // Data do servidor

            //  Console.WriteLine(dateUtc);
            // Console.WriteLine(dateNow);

            //  Console.WriteLine( dateUtc.ToLocalTime()); //Tipo de data universal, usando localtime para pegar a hora e dia do local do servidor que está 


            //  var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Aucland"); // Usuario saber o fuziohorario na parte pacica da australia
            // ou seja, ele pega por regiões.
            //  Console.WriteLine(timeZoneAustralia);


            //  var horaAustralia = TimeZoneInfo.ConvertTime(dateUtc,timeZoneAustralia);
            //  Console.WriteLine(horaAustralia);


            // Listar todos os TimeZone dispinivel

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id); //Lugar
                Console.WriteLine(timezone); // região
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateUtc, timezone));

            }



        }
    }
}

