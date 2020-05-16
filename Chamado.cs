using System;
using System.IO;

class Chamado{

  private string cliente;
  private string telefone;
  private string email;
  private string tipoDispositivo;
  private string problema;
  private string tipo;
  private string nivel;

  public string Cliente{
    get{
      return cliente;
    }
    set{
      cliente = value;
    }
  }

  public string Telefone{
    get{
      return telefone;
    }
    set{
      telefone = value; 
    }
  }

   public string Email{
    get{
      return email;
    }
    set{
      email = value; 
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

  public string Tipo{
    get{
      return tipo;
    }
    set{
      tipo = value;
    }
  }
  public string Nivel{
    get{
      return nivel;
    }
    set{
      nivel = value;
    }
  }
  public void CriarChamado(){ // Método para criar chamado

    Console.WriteLine("---**CRIAR CHAMADO**---\n");

    Console.Write("Cliente: ");
    Cliente = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Telefone: ");
    Telefone = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Email: ");
    Email = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Tipo do Dispositivo: ");
    TipoDispositivo = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Descreva seu problema: ");
    Problema = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Tipo do chamado (hardware/software): ");
    Tipo = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Nível do chamado (baixo/médio/alto): ");
    Nivel = Console.ReadLine();
    Console.WriteLine();

    File.WriteAllText("chamadosNovos.txt", "**NOVO CHAMADO**\n Cliente: " + cliente + "\nTelefone: " + telefone +"\nEmail: " + email + "\nTipo Do Dispositivo: " + tipoDispositivo + "\nProblema: " + problema + "\nTipo do chamado (Hardware/Software): "+ tipo + "\nNível do chamado (baixo/médio/alto): " + nivel);
  }    


}