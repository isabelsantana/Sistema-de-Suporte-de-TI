using System;
using System.IO;

class Catalogo {

  public void ExibirCatalogo(){ // Método para exibir catalogo
    string[] lines = File.ReadAllLines("catalogo.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }

  


}