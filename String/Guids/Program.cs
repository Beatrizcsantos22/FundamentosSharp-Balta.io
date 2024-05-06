using System;
using System.Runtime.Versioning;

namespace Guids.App
{
   class Program
   {
      //Guid = Indentificador único, ele gera codigos para indentificar algo na sua aplicação, como por exemplo produtos em um estoque.
      static void Main(string[] args)
      {
         //Guid = Indentificador Global único

         //gerando o Guids
         var id = Guid.NewGuid();
         id.ToString(); // Transforma em string

         //Gerando um que já existe
         id = new Guid("d939ff10-dd01-40e2-90e8-f539a317b096");

         //  id = new Guid(); , resultado somenete zero
         //Pega somente os 8 primeiros caracteres.
         Console.WriteLine(id.ToString().Substring(0, 8));

         Console.WriteLine(id);



      }
   }
}