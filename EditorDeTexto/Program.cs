using System;
using System.IO;
class EditorDeTexto{
    public static void Main(String[]args){
        Menu();
    }



   static void Menu(){
    Console.Clear();
    Console.WriteLine("O que você deseja fazer");
    Console.WriteLine("1- Criar um arquivo ");
    Console.WriteLine("2- Editar o arquivo");
    Console.WriteLine("0 - Sair");
    short op = short.Parse(Console.ReadLine());
    switch(op){
        case 1:CriaArquivo(); break;
        case 2: AbreArquivo();break;
        case 0: System.Environment.Exit(0); break;
        default: Menu();break;

    }
   }



  static void CriaArquivo(){








        Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("-----------------------");

    string texto = "";
    do{
        texto += Console.ReadLine();
        texto+= Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);
     SalvaArquivo(texto);
  }

static void AbreArquivo(){
   
        Console.Clear();
       Console.WriteLine("Qual o caminhado do arquivo?");
       string caminho = Console.ReadLine();
       using (var arquivo =new StringReader(caminho))
       {
            string texto =arquivo.ReadToEnd();
            Console.WriteLine(texto);
       }

       Console.WriteLine("");
       Console.ReadLine();
       Menu();


 
    }

static void SalvaArquivo(string textos){
    Console.Clear();
    Console.WriteLine("Qual o caminhado para salvar o arquivo?");
    var caminho = Console.ReadLine();
    using(var arquivo = new StreamWriter(caminho))//abre o objeto e fecha
    {    
             arquivo.Write(textos);
    }
    Console.WriteLine($"Arquivo{caminho} Salvo com sucesso!");
    Console.ReadLine();
    Menu();
}

}
















