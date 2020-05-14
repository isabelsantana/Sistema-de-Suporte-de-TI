using System;
using System.IO;

public class CadastroDispositivo{

  private string memoria;
  private string hostname;
  private string ipInterno;
  private string antivirus;
  private string codigoComputador;
  private string tipoDispositivo;
  public string disp;


  public string Memoria{
    get{
      return memoria;
    }
    set{
      memoria = value;
    }
  }

  public string Hostname{
    get{
      return hostname;
    }
    set{
      hostname = value;
    }
  }
  
  public string IpInterno{
    get{
      return ipInterno;
    }
    set{
      ipInterno = value;
    }
  }

  public string Antivirus{
    get{
      return antivirus;
    }
    set{
      antivirus = value;
    }
  }

  public string CodigoComputador{
    get{
      return codigoComputador;
    }
    set{
      codigoComputador = value;
    }
  }

  public string TipoDispositivo{
    get{
      return tipoDispositivo;
    }
    set{
      tipoDispositivo = value;
    }
  }

  public static void Novo(){ // MÉTODO PARA MOSTRAR MODELO DE CADASTRO DE NOVO DISPOSITIVO
    Console.WriteLine("**MODELO DE CADASTRO DE NOVO DISPOSITIVO**");
    Console.WriteLine("Digite 1"); 
    string opcao2 = Console.ReadLine();

    if (opcao2 == "1"){
      string[] lines = File.ReadAllLines("dispositivosCadastrados.txt");
      foreach(var line in lines) Console.WriteLine(line);
    } 
  }

  public static void Dispo(){ // Método para cadastrar dispositivo
    
    Console.WriteLine("**CADASTRE SEU DISPOSITIVO**\n");

    Console.Write("Memória: ");
    string memoria = Console.ReadLine();

    Console.Write("Hostname: ");
    string hostname = Console.ReadLine();

    Console.Write("IP Interno: ");
    string ipInterno = Console.ReadLine();

    Console.Write("AntiVírus: ");
    string antivirus = Console.ReadLine();

    Console.Write("Código do Computador: ");
    string codigoComputador = Console.ReadLine();

    Console.Write("Tipo do Dispositivo: ");
    string tipoDispositivo = Console.ReadLine();

    File.WriteAllText("dispC.txt", "**NOVO CADASTRO**\n Memória: " +memoria +
    "\nHostname: " +hostname +
    "\nIP Interno: " +ipInterno + 
    "\nAntiVirus: " +antivirus + 
    "\nCódigo do Computador" +codigoComputador +
    "\nTipo Do Dispositivo: " +tipoDispositivo);
  }
}