//Indice indica a posição de caracter ou de algum item de uma lista, posição.

using System;

        
namespace Indices
{
    class Program
    {
        static void Main(string[]args)
        {
            var text = "It text is a test";
           
          //O indexOff sempre irá pedir um objeto do mesmo tipo.
          //Conta a posição do caracter selecionado, no caso está no indice 8.
           Console.WriteLine(text.IndexOf("is"));
          Console.WriteLine(text.IndexOf("a"));
           Console.WriteLine("");

           //Ultimo index que ele vai encotrar
           Console.WriteLine(text.LastIndexOf("s"));
              
          //---------------Métodos complementares-------------------
              /*Insert usados nas listas, insere algo no texto */
            Console.WriteLine(text.Insert(8,"HERE"));
            Console.WriteLine(text.Remove(5,5)); // Remove o item que foi add
            Console.WriteLine(text.Length); //Quantidade de caracter que tem na string
            


        }
    }
}
