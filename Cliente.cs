using System;
using System.IO;

class Cliente{

  private string endereco;
  private string telefone;
  private string nome;
  private string codigo;

  public string Endereco{
    get{
      return endereco;
    }
    set{
      endereco = value;
    }
  }

  public string Telefone{
    get{
      return telefone;
    }
    set{
      telefone = value;
    }
  }

  public string Nome{
    get{
      return nome;
    }
    set{
      nome = value;
    }
  }

  public string Codigo{
    get{
      return codigo;
    }
    set {
      codigo = value;
    }
  }
  
  public static void Cadastro(){

    Console.WriteLine("\n  #CADASTRO DE NOVO CLIENTE#\n");

    Console.Write("Nome: ");
    string nome = Console.ReadLine(); 
    Console.WriteLine();

    Console.Write("Telefone: ");
    string telefone = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Endereço: ");
    string endereco = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Código: ");
    string codigo = Console.ReadLine();
    Console.WriteLine();
        
    File.WriteAllText("cadastroCliente.txt", "**CADASTRO DO CLIENTE**\nNome: " +nome + "\nTelefone: " +telefone + "\nEndereco: "+endereco +"\nCódigo: " +codigo);

  }

}