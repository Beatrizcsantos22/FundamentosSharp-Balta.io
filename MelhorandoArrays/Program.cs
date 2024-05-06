/*Para copiar um array, basta usar .Clone é o metodo 
que gera outro array e segura o endereço de memoria, ou seja se 
altera em um indice, altera no outro indice o valor referente de outro array.
 Temos tbm para copiar valores de um array basta colocar o .Copyto.
 . . . . . . . . . .
Temos  o metodo .Length que é a quantidade de items que tem dentro do array.
*/



using System;

namespace MelhorandoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
             meuArray[0] = 12;
    
             Console.WriteLine(meuArray.Length); // Quantidade de indices


            //Percorrer array
            for (int item = 0; item <= meuArray.Length; item++) // tamanho do meu array
            {
                Console.WriteLine(meuArray[item]);
            }

        }
    }
}