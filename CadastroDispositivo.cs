using System;
using System.IO;
class CadastroDispositivo{

  private string memoria;
  private string hostname;
  private string ipInterno;
  private string antivirus;
  private string codigoComputador;
  private string tipoDispositivo;


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

  public string CodigoDoComputador{
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

  public static void novo(){
    string[] lines = File.ReadAllLines("dispositivosCadastrados.txt");
      foreach(var line in lines) Console.WriteLine(line);
  
  } 




}