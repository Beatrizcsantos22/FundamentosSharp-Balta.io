using System;

namespace FormatandoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de formatação

            var data = DateTime.Now;

            // Formatar uma data para string
            //y -> ano , M -> mes, d -> dia, h-> hora, s-> segundo.
            // var format = String.Format("{0:yyyy}",data) ; // Ano : 2024 se colocar um y ele exibirá o mes por extenso e o ano.
            var format = String.Format("{0:d/M/yyyy hh:mm:ff:ss}", data); // Modo padrão do Brasil com dia, mes e ano = 24-3-2024 e com barra 24/3/2024
                                                                          // Temos o z que é o TimeZone -> Lugar que está hora está baseada, no caso aqui no Brasil, seria -3, de horário diferente dos Eua
                                                                          // ff -> minuto fracionário.
            Console.WriteLine(format);
        }
    }
}