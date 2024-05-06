using System;

namespace TryCath.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            // tente
            try
            {
                    // erro na abertura do arquivo
                // for(var index = 0 ; index < 10; index ++)
                // {
                //     //System.IndexOutOfRangeException
                //    Console.WriteLine(arr[index]);

                //   }
                Cadastrar("dsfjjssfjk");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encotrei o indice na lista...");

            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }

            //Exception criada  atraves de uma classe especifica.
            // aqui o erro somente dessa classe será tratado
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Excessão customizada!");
            }

           
           // arquivo já está aberto
            catch (Exception ex) //qualquer de informação desse'tratamento de erro' que queira saber está na variavel ex
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado...");
            }

           // garantia que feche o arquivo, seja q deu certo ou errado.
            finally
            {
                Console.WriteLine("Chegou ao fim :)");
            }


        }
       
       
        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) // Checa se a string está vazia
            {
                // throw - arremeçar/jogar
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
