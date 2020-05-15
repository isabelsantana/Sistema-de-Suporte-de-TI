using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

    Catalogo catalogo = new Catalogo(); 
    Console.WriteLine(" ** BEM VINDO AO SEU SUPORTE DE TI ** ");
    catalogo.ExibirCatalogo(); // Chamando método
    Menu();
  }
    public static void Menu(){

      string opcao;
      Catalogo catalogo = new Catalogo(); // Instanciando as classes (objetos)
      Chamado chamado = new Chamado();
      Cliente cliente = new Cliente();
      Dispositivo dispositivo = new Dispositivo();

      //-------------------------------------------------------------------------------------// 
      Console.WriteLine("Digite o código do serviço desejado: ");
      opcao = Console.ReadLine();
      //-------------------------------------------------------------------------------------//
      if (opcao == "1"){ // Menu interativo para o usuario 
        cliente.ExibirEmpresasCadastradas();
        MainClass.Menu();
      }
      else if (opcao == "2"){
        cliente.CadastroCliente(); 
        MainClass.Menu();
      } 
      else if (opcao == "3"){
        chamado.CriarChamado();
        MainClass.Menu();
      }
      else if (opcao == "4"){
        dispositivo.ExibirModelo();
        MainClass.Menu();

      }
      else if (opcao == "5"){
        dispositivo.CadastrarDispositivo();
        MainClass.Menu();    
      }
      else{
        catalogo.ExibirCatalogo();
        MainClass.Menu();
      }
    }
  }