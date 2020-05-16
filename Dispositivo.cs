using System;
using System.IO;

public class Dispositivo{

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

  public void ExibirModelo(){ // MÉTODO PARA MOSTRAR MODELO DE CADASTRO DE NOVO DISPOSITIVO

      string[] lines = File.ReadAllLines("dispositivosCadastrados.txt");
      foreach(var line in lines) Console.WriteLine(line);
    } 


  public void CadastrarDispositivo(){ // Método para cadastrar dispositivo
    
    Console.WriteLine("\n---**CADASTRE SEU DISPOSITIVO**--- \n");

    Console.Write("Memória: ");
    Memoria = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Hostname: ");
    Hostname = Console.ReadLine();
    Console.WriteLine();

    Console.Write("IP Interno: ");
    IpInterno = Console.ReadLine();
    Console.WriteLine();

    Console.Write("AntiVírus: ");
    Antivirus = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Código do Computador: ");
    CodigoComputador = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Tipo do Dispositivo: ");
    TipoDispositivo = Console.ReadLine();
    Console.WriteLine();

    File.WriteAllText("CadastrarDispositivos.txt", "**NOVO CADASTRO**\n Memória: " + Memoria +"\nHostname: " + Hostname + "\nIP Interno: " + IpInterno + "\nAntiVirus: " + Antivirus + "\nCódigo do Computador" + CodigoComputador + "\nTipo Do Dispositivo: " + TipoDispositivo);
    
  }  
}
  