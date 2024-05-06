using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
   public class Viewer
   {
      public static void Show(string text)
      {
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.White; // Fundo Branco
         Console.BackgroundColor = ConsoleColor.Black; // Letra Preta

         Console.Clear();
         Console.WriteLine("MODO DE VISUALIZAÇÂO");
         Console.WriteLine("------------");
         Replace(text); // Se a string repetir ficará azul aqui
         Console.WriteLine("------------");
         Console.ReadKey();
         Menu.Show();

      }

      public static void Replace(string text) // Função para repetir usando regex e is match
      {
         // Expressão regular
         var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
         var words = text.Split(' '); // Pega o que ta na string words e convert para o text separando(deixando sem espaço caso tiver)
         for (var i = 0; i < words.Length; i++)
         {
            if (strong.IsMatch(words[i])) // Irá veificar se a string pertence a expressão regular
            {
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.Write(
                   words[i].Substring(
                       words[i].IndexOf('>') + 1, // Pega a > e mais um caracter
                       ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')) // o ultimo(antes) de < da palavras escritas e o 
                   )
               );
               Console.Write(" ");
            }
         }
      }
   }
}