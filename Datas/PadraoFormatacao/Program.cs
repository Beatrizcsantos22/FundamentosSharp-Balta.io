using System;

namespace PadraoFormatacao
{
   class Program
   {
        static void Main(string[]args)
        {
             Console.Clear();
             
             var data = DateTime.Now;

            // var format = String.Format("{0:D}",data); // Exibe a data completa, domingo, 24 de março de 2024.
           // var format = String.Format("{0:f}",data); // Exibe a data completa e a hora, domingo, 24 de março de 2024 22:38
             // var format = String.Format("{0:g}",data); // Exibe a data simples e a hora, 24/03/2024 22:40
             //var format = String.Format("{0:y}", data); //  Exibe o nome do mês e o ano, março de 2024
            // var format = String.Format("{0:r}", data); // Abrevia o nome do mes porém tem tudo,Sun, 24 Mar 2024 22:45:08 GMT
                 
             var format = String.Format("{0:u}", data); // Usado para converter algo para o front end , 2024-03-24T22:47:25
             // temos o u que é padrão universal,2024-03-24 22:48:35Z

             Console.WriteLine(format);

        }
   }
}
