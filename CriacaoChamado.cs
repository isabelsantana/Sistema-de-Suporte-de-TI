using System;
using System.IO;

class CriacaoChamado{

  private string cliente;
  private string contatoCliente;
  private string tipoDispositivo;
  private string problema;

  public string Cliente{
    get{
      return cliente;
    }
    set{
      cliente = value;
    }
  }

  public string ContatoCliente{
    get{
      return contatoCliente;
    }
    set{
      contatoCliente = value; 
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

  public string Problema{
    get{
      return problema;
    }
    set{
      problema = value;
    }
  }

  public static void Chamado(){ // Método para criar chamado

    Console.WriteLine("**CRIAR CHAMADO**\n");

    Console.Write("Cliente (Físico / Jurídico): ");
    string cliente = Console.ReadLine();

    Console.Write("Contato do Cliente: ");
    string contato = Console.ReadLine();

    Console.Write("Tipo do Dispositivo: ");
    string tipoDispositivo = Console.ReadLine();

    Console.Write("Descreva seu problema: ");
    string problema = Console.ReadLine();

    File.WriteAllText("chamadosNovos.txt", "**NOVO CHAMADO**\n Cliente: " +cliente +
      "\nContato do Cliente: " +contato +
      "\nTipo Do Dispositivo: " +tipoDispositivo + 
      "\nProblema: " +problema);
  }    


}