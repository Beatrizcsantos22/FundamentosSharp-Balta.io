using System;
using System.Text;

namespace MeuApp
{
    class Program
    {
        static void Main()
        {
            //String Builder(String Construtor)-> Ele adiona textos complementarias na sua aplicação

            var text = new StringBuilder();
            text.Append("It text is a test");
            text.Append("\nIt text is a test");
            text.Append("It text is a test");
            text.Append("\nIt text is a test");


            text.ToString(); // Converte para string, caso no console.writeline não consiga  converter.
            Console.WriteLine(text);

        }
    }
}
