using System;
using System.Reflection.Emit;
using System.Text;

namespace EditorHtml
{
   public static class Editor
   {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White; // Fundo Branco
      Console.ForegroundColor = ConsoleColor. Black; // Letra Preta
      
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("------------");
      Start();

   
    }

    public static void Start()
    {
       
        var file =  new StringBuilder();  // Quando tem muitas strings usar StringBuilder
         
         do{
            
            file.Append(Console.ReadLine()); // Adiciona as strings(textos)
             file.Append(Environment.NewLine);// Adiciona linhas, caso o usuário aperte enter
         } while(Console.ReadKey().Key != ConsoleKey.Escape); // Apertar esc irá pedir para salvar, se não continuará.

           // Salvar
           Console.WriteLine("Deseja salvar o arquivo?[S]Sim - [N]Não \n->");
          var caminho = Console.ReadLine();

        // StreamWriter significa fluxo de escritas, ou seja é um metodo que fornece que voce escreva quantidades enormes de caracters(array de bytes)
      // Sempre irá pedir uma caminho para o arquivo  

      // a variavel arquivo  irá carregar toda a escrita do caminho                   
      using (var arquivo = new StreamWriter(caminho))
      {
         // escrever o caminho,  e irá pegar tudo o file(arquivo escrito pelo usuario)
        arquivo.Write(file);
        
      }
       
       // Aqui irá salvar 
      Console.WriteLine($"Arquivo{caminho}salvo com sucesso!");
      Console.ReadLine();
      
      // Aparece a visualização do arquivo salvo
      Viewer.Show(file.ToString());
    }
    }

   }
