using System;

namespace ProjetoCronometro.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos => 10s = 10 segundos");
            Console.WriteLine("M - Minutos => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar");

            string data = Console.ReadLine().ToLower(); // Converte tudo para minusculo
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega a posição de uma string, no caso queremos a última posição(-1), e para que a contagem seja automatica pois dependendo do que o usuario digitar a cada vez será quantidade de arrays diferente. E para essa automação usaremos o Length.
            //Type s ,  time 10.
            int time = int.Parse(data.Substring(0, data.Length - 1)); // Pegar os numeros antes do tipo m ou s, o data.leght garante na qual o usuario irá digitar, -1 pois semrpre a contagem é menos um.

            // caso for em segundo, irá contar de 1s
            int multiplier = 1;

            //caso for em minutos irá contar de 60s
            if (type == 'm' || type == 'M')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0); //Sair da aplicação

            }

            //Conversão do tempo que será contado, ex: 60*60 = 
            PreStart(time * multiplier);

            //data.Length para pegar todos os numeros e trazer para a tela (10s)
            Console.WriteLine(data);
            Console.WriteLine(type);
            Console.WriteLine(time);






        }

        static void PreStart(int time)
        {
            //Animação antes de começar a contagem do cronograma
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {

            int currentTime = 0; //Minuto atual
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                // Ele fará a aplicação esperar 1 segundo antes de começar outro while.
                Thread.Sleep(1000);

            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();

        }
    }
}