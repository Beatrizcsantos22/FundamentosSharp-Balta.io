using System;


namespace ManipulandoStrg
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = " The World it's walking to collapsion ";
            Console.WriteLine(text.Replace("collapsion", "sucess"));
            // Replace(substituir)-> substitui um caracter pelo outro.


            //Splip(dividir)-> Separa caracter, quebra de linha
            //Assim, quando fazemos uma lista, vai ficar um em cima do outro
            var division = text.Split("");
            Console.WriteLine(division[0]);

            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);
            Console.WriteLine(division[5]);


            //Pega os caracteres que deseja exibir
            //var result = text.Substring(5, 5); // caracter 5 , exibe 5
            var result = text.Substring(5, text.LastIndexOf("o"));
            Console.WriteLine(result);

            Console.WriteLine(text.Trim());
            //Trim(aparar,consrtar) - Usados em formulário, remove os espaços no começo e no fim.




        }
    }
}
