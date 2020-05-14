using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

    Cliente c = new Cliente();
    string opcao;

    Console.WriteLine("**SISTEMA DE SUPORTE DE TI**");
    Console.WriteLine("Olá, digite 1 para cadastrar um novo cliente e 2 caso só queira ver a lista de clientes!");
    opcao = Console.ReadLine();

    if (opcao == "1"){
    

      Console.WriteLine("Informe o nome do cliente: ");
      c.Nome = Console.ReadLine();
      //Console.WriteLine(c.Nome); 
      Console.WriteLine();

      Console.WriteLine("Informe o telefone: ");
      c.Telefone = Console.ReadLine();
      Console.WriteLine();

      Console.WriteLine("Informe o endereço do cliente: ");
      c.Endereco = Console.ReadLine();
      Console.WriteLine();

      Console.WriteLine("Informe o código do cliente: ");
      c.Codigo = int.Parse(Console.ReadLine());
      Console.WriteLine();
      
      File.WriteAllText("cadastroCliente.txt", "**CADASTRO DO CLIENTE**\nNome: " +c.Nome + "\nTelefone: " +c.Telefone + "\nEndereco: "+c.Endereco +"\nCódigo: " +c.Codigo);

    }    

    
  }
}