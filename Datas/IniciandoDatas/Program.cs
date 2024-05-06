using System;

namespace IniciandoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataTIme é um struct, ou seja um tipo de dado. Ele inicializa como 1/1/0001 12:00:00 AM

            Console.Clear();
            // var data = new DateTime(); // Instanciando valores do tipo de dado
            var data = DateTime.Now; // Data do dia de hoje: 24/03/2024 18:44:32
            Console.WriteLine(data);
        }
    }
}