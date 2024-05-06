/* globalização e localização : Usamos esse recurso para saber onde o usuario está,
 ou para formatar valores e datas de acordo com a localidade dele.*/

using System;

namespace CultureInfo
{
    class Program 
    {
        static void Main(string[]args)
        {
             Console.Clear();
             
             var pt = new System.Globalization.CultureInfo("pt-BR"); // Data Brasil
             var enUs = new System.Globalization.CultureInfo("en-US"); // Data EUA
             var de = new System.Globalization.CultureInfo("de-DE"); // Data Dinarmarca
           
             var atual = System.Globalization.CultureInfo.CurrentCulture;   // Data da máquina
           
            

             // exibir
             Console.WriteLine(DateTime.Now.ToString("d",de));
              Console.WriteLine(DateTime.Now.ToString("d",pt));

        }
    }
}