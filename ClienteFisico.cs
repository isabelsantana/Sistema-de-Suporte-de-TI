using System;
using System.IO;
class ClienteFisico : Cliente{

  protected string cpf;

  
  public void PedirCPF(){
    Console.Write("CPF: ");
    cpf = Console.ReadLine();

 // File.WriteAllText("cadastroCliente.txt","CPF:" + cpf);

  }
    
}