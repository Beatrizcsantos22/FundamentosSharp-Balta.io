using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Arrays
{
    class Program 
    {
        static void Main(string[] args)
        {
         Console.Clear();

         var meuArray = new Teste [5];  
         meuArray[0] = new Teste();

        Console.WriteLine(meuArray[0].Id);

    }


    struct Teste
    {
        public int Id {get;set;}

    }
}
}
