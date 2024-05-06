/*Foreach ele percorre todos os items do array, sem especificar muito como por 
exemplo a quantidade de tamanho do array, a contagem ...*/







using System;

namespace App
{
    class Program 
    {
        static void Main(string[] args)
        {
          Console.Clear();

          var funcionarios = new Funcionario[5];
          funcionarios [0] = new Funcionario() {Id =2579, Name = "André"};
          // Colocar () para indicar uma inicialização de um objeto.


           
        // percorra var i no meuarray
          foreach (var func in funcionarios)
          {
             Console.WriteLine(func.Id);  
             Console.WriteLine(func.Name);
          }  
        }

    }
    public struct Funcionario{
        public int Id { get; set; } 

        public string Name { get; set; }
    }
}