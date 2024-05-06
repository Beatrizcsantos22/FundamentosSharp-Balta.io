using System;

namespace ComparandoData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // DateTime ? data = null; // valor nulo, não aparece nada.

            DateTime data = DateTime.Now;

            // Comparando somente as datas
            if (data.Date == DateTime.Now.Date) // quando temos um tipo struct , o valor é comparado entre esse tipo de dado mesmo.
            {
                Console.WriteLine("A data é igual!");
            }

            else if (data.Date > DateTime.Now.Date) // Date.Now.Day ,  temos varios tipos para comparar
            {
                Console.WriteLine("A data é  maior que a de hoje!");

            }
            Console.WriteLine(data);
        }
    }
}
