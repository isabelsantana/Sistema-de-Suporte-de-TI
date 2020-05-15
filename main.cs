using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

  string opcao;
  Catalogo catalogo = new Catalogo(); // Instanciando Objeto   
  Chamado chamado = new Chamado();
  Cliente cliente = new Cliente();
  Dispositivo dispositivo = new Dispositivo();
  
  Console.WriteLine(" ** BEM VINDO AO SEU SUPORTE DE TI ** ");
  catalogo.ExibirCatalogo(); // Chamando método

  Console.WriteLine("Digite o código do serviço desejado: ");
  opcao = Console.ReadLine();

  if (opcao == "1"){ // Menu interativo para o usuario 
    cliente.ExibirEmpresasCadastradas();
  }
  if (opcao == "2"){
    cliente.CadastroCliente(); 
  } 
  if (opcao == "3"){
    chamado.CriarChamado();
  }
  if (opcao == "4"){
    dispositivo.ExibirModelo();

  }
  if (opcao == "5"){
    dispositivo.CadastrarDispositivo();    
  }
  if (opcao == "6"){
    

  }

  









 /* 

    

    if (serv == "1"){
      string[] lines = File.ReadAllLines("empresas.txt");
        foreach(var line in lines ) Console.WriteLine(line); // ARQUIVO PARA MOSTRAR AS EMPRESAS CADASTRADAS
    } 
    else if (serv == "2"){
      Cliente.Cadastro(); // MÉTODO PARA CADASTRAR CLIENTE
    }
    else if(serv == "3"){
      CriacaoChamado.Chamado(); //MÉTODO PARA CRIAR NOVO CHAMADO
    } 
    else if(serv == "4"){
      CadastroDispositivo.Novo(); // MÉTODO PARA MOSTRAR O MODELO DE CADASTRO DE DISPOSITIVO PRO USUARIO
    }
    else if(serv == "5"){
      CadastroDispositivo.Dispo(); // // MÉTODO PARA CADASTRO DE NOVO DISPOSITIVO
    }
    else{
      Console.WriteLine("\nDigite um número válido!");
      Nome();
    }
      
  }


  

  public static void Main (string[] args) {

    Cliente c = new Cliente();
    Nome(); // função pra mostrar o menu
    

   // CadastroDispositivo n = new CadastroDispositivo(); // INSTANCIA DE NOVO OBJETO ** CLASSE CADASTRO DISPOSITIVO **
    
   /* Console.WriteLine("*DISPOSITIVOS*");
    n.disp = Console.ReadLine();
    Console.WriteLine(n.disp);*/

   // CadastroDispositivo.Novo(); // MÉTODO PARA MOSTRAR O MODELO DE CADASTRO DE DISPOSITIVO PRO USUARIO

    //CadastroDispositivo.Dispo(); // MÉTODO PARA CADASTRO DE NOVO DISPOSITIVO

   // CriacaoChamado a = new CriacaoChamado();

   // CriacaoChamado.Chamado(); //MÉTODO PARA CRIAR NOVO CHAMADO*/

    







  }
}   
