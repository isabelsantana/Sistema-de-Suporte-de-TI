using System;
class ClienteJuridico : Cliente{

  protected string cnpj;

  public void PedirCNPJ(){
    Console.Write("CNPJ: ");
    cnpj = Console.ReadLine();  
  }
}