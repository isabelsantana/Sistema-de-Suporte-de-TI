using System;
using System.IO;

class MainClass {

  public static void Nome(){  // FUNÇÃO PARA MOSTRAR O MENU
    
    Console.WriteLine("\n---------------------**M E N U**---------------------\n");
 
    Console.WriteLine("  --DIGITE QUAL SERVIÇO VOCÊ DESEJA REALIZAR--  \n");
    Console.WriteLine("1 - Vizualizar empresas cadastradas");
    Console.WriteLine("2 - Cadastrar cliente");
    Console.WriteLine("3 - Criar chamado");
    Console.WriteLine("4 - Descobrir como cadastrar um novo dispositivo");
    Console.WriteLine("5 - Cadastrar novo dispositivo\n");
    string serv = Console.ReadLine();
    

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
    

    CadastroDispositivo n = new CadastroDispositivo(); // INSTANCIA DE NOVO OBJETO ** CLASSE CADASTRO DISPOSITIVO **
    
    Console.WriteLine("*DISPOSITIVOS*");
    n.disp = Console.ReadLine();
    Console.WriteLine(n.disp);

    CadastroDispositivo.Novo(); // MÉTODO PARA MOSTRAR O MODELO DE CADASTRO DE DISPOSITIVO PRO USUARIO

    CadastroDispositivo.Dispo(); // MÉTODO PARA CADASTRO DE NOVO DISPOSITIVO

    CriacaoChamado a = new CriacaoChamado();

    CriacaoChamado.Chamado(); //MÉTODO PARA CRIAR NOVO CHAMADO

    







  }  
}