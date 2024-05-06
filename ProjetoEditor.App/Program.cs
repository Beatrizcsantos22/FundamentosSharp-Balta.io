9using System;
using System.IO;
using Microsoft.VisualBasic;

namespace ProjetoEditor.App
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
      Console.WriteLine("O que você deseja fazer");
      Console.WriteLine("1 - Abrir arquivo ");
      Console.WriteLine("Criar novo arquivo");
      Console.WriteLine("0 - Sair");
      short opc = short.Parse(Console.ReadLine());


      switch (opc)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
      }
    }

    static void Abrir()
    {
      Console.Clear();
      Console.WriteLine("Qual caminho o arquivo?");
      string caminho = Console.ReadLine();

      //using usado quando for ler ou salvar um arquivo.
      using (var arquivo = new StreamReader(caminho))
      {
        // Leitura do caminho, ReadToEnd ler o arquivo até o final(ler texto)
        /*StreamReader é fornecer métodos para ler caracteres, 
        linhas ou até mesmo todo o conteúdo de um fluxo de entrada de texto.*/
        string texto = arquivo.ReadToEnd();
        Console.WriteLine(texto);
      }
      Console.WriteLine("");
      Console.ReadLine();
      Menu();
    }


    static void Editar()
    {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
      Console.WriteLine("------------------------");
      // Armazena o texto escrito em text.
      string text = "";

      do //Faça
      {
        // text irá receber mais ou igual(irá receber e armazenar outras linhas)
        text += Console.ReadLine();
        // Quebra de limha, ou seja colocando mais uma linha
        text += Environment.NewLine;

      }
      // Enquanto o usuário não apertar esc, tudo séra mantido e armazenado no arquivo
      // Console.ReadKey é um método em que o usuário irá pressionar uma tecla
      // No caso aqui, especificamos a tecla esc, que seria o Escape.
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      Salvar(text);



    }


    static void Salvar(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual caminho para salvar o arquivo?");
      var caminho = Console.ReadLine();



      // StreamWriter significa fluxo de escritas, ou seja é um metodo que fornece que voce escreva quantidades enormes de caracters(array de bytes)
      // Sempre irá pedir uma caminho para o arquivo
      using (var arquivo = new StreamWriter(caminho))
      {
        arquivo.Write(text);

      }

      Console.WriteLine($"Arquivo{caminho}salvo com sucesso!");
      Console.ReadLine();

      Menu();
    }



    // Extra 
    static void Excluir()
    {
      Console.Clear();
      Console.WriteLine("Coloque o caminho que deseja excluir:");
      var caminho = Console.ReadLine();

      // Arquivo existente (nome do caminho colocado)
      if (File.Exists(caminho))
      {

        // Arquivo será deletado(nome do caminho colocado)
        File.Delete(caminho);
      }

      else
      {
        Console.WriteLine("Arquivo não encotrado");
      }
      Console.WriteLine($"Arquivo{caminho} excluido com sucesso!");
      Menu();
    }
  }

}
