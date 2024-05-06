using System;

namespace Interpolacaostrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var preco = 10.2;

            //tipos de interpolação

           // var texto = $@" O preço do Produto é:{preco}";
            
            var texto = string.Format("O preço do produto é apenas{0} na promoção de quinta!");
            Console.WriteLine(texto);

         }
    }
}
