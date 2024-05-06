using System;

namespace AlterandoValores 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var arr =  new int[5];
            var arrb = arr; // Não criou array novo, só está apontando o mesmo endereco da memoria
            

            arr[0] = 23;
            Console.WriteLine(arrb[0]); //Aponta pro mesmo endereço de memoria, mesmo valor do indice
            
            

        }
    }
     public struct Funcionario{
        public int Id { get; set; } 

        public string Name { get; set; }
    }
}
