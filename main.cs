using System;

class MainClass {
  public static void Main (string[] args) {

    Cliente c = new Cliente();

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

    
  }
}