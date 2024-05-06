using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; // Fundo do Menu
            Console.ForegroundColor = ConsoleColor.Black; // Letra do Menu

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }

        public static void DrawScreen()
        {

            Console.Write("+"); // fechamento das linhas
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-"); // Linha 
            }
            Console.Write("+"); // quebra o fechamento jogando ele para o lado
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|"); // colunas
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");


        }


        public static void WriteOptions() //Função Escreva a Opção
        {
            // Escreva algo na posição que deseja
            Console.SetCursorPosition(3, 2); //posição do editor html
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }

        public static void HandleMenuOptions(short option) // Manipular as opções do Menu
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Show(); break;
            }

        }


    }
}
