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
  
  public void CadastroCliente(){ // metodo para cadastrar cliente

    Console.WriteLine("\n  #CADASTRO DE NOVO CLIENTE#\n ");

    Console.Write("Nome: ");
    Nome = Console.ReadLine(); 
    Console.WriteLine();

    Console.Write("Telefone: ");
    Telefone = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Endereço: ");
    Endereco = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Código: ");
    Codigo = Console.ReadLine();
    Console.WriteLine();
        
    File.WriteAllText("cadastroCliente.txt", "**CADASTRO DO CLIENTE**\nNome: " +Nome + "\nTelefone: " +Telefone + "\nEndereco: "+Endereco +"\nCódigo: " +Codigo);

  }

  public void ExibirEmpresasCadastradas(){
    string[] lines = File.ReadAllLines("empresas.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }

}