using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

    
    Cliente c = new Cliente();

    Console.WriteLine(); //pular linha **ESTETICA**
    Console.WriteLine("**SISTEMA DE SUPORTE DE TI**");
    Console.WriteLine(); //pular linha **ESTETICA**

    Console.WriteLine("Para vizualizar as empresas cadastradas digite 1 para SIM e 2 para NÃO!");
      string opcao = Console.ReadLine(); // variavel pra guardar a opçao do usuario
        if (opcao == "1"){
          string[] lines = File.ReadAllLines("empresas.txt");
            foreach(var line in lines ) Console.WriteLine(line);
        }

    Console.WriteLine("#CADASTRO DE NOVO CLIENTE#");
    Console.WriteLine("Digite 1 para cadastrar um novo cliente e 2 caso só queira ver a lista de clientes!");
    string opcao1 = Console.ReadLine(); // variavel pra guardar a opçao do usuario


    if (opcao1 == "1"){  // Cadastro de novo cliente

      Console.Write("Nome: ");
      c.Nome = Console.ReadLine(); 
      Console.WriteLine();

      Console.Write("Telefone: ");
      c.Telefone = Console.ReadLine();
      Console.WriteLine();

      Console.Write("Endereço: ");
      c.Endereco = Console.ReadLine();
      Console.WriteLine();

      Console.Write("Código: ");
      c.Codigo = Console.ReadLine();
      Console.WriteLine();
        
      File.WriteAllText("cadastroCliente.txt", "**CADASTRO DO CLIENTE**\nNome: " +c.Nome + "\nTelefone: " +c.Telefone + "\nEndereco: "+c.Endereco +"\nCódigo: " +c.Codigo);


      Console.WriteLine();
    }  
    else{
    Console.WriteLine("Você deseja ver as empresas cadastradas? Digite 1 para sim e 2 para sair. ");
      opcao = Console.ReadLine();
      if (opcao == "1"){
        string[] lines = File.ReadAllLines("clientescadastrados.txt");
          foreach(var line in lines) Console.WriteLine(line);
      }
    }


    CadastroDispositivo n = new CadastroDispositivo(); // INSTANCIA DE NOVO OBJETO ** CLASSE CADASTRO DISPOSITIVO **
    
    Console.WriteLine("*DISPOSITIVOS*");
    n.disp = Console.ReadLine();
    Console.WriteLine(n.disp);

    CadastroDispositivo.Novo(); // MÉTODO PARA MOSTRAR O MODELO DE CADASTRO DE DISPOSITIVO PRO USUARIO

    CadastroDispositivo.Dispo(); // MÉTODO PARA CADASTRO DE NOVO DISPOSITIVO

    







  }
}