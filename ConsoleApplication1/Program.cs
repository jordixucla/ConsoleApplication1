using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reto1ClassLibrary;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      var listaSinOrdenar = new List<Persona>()
            {
                new Persona() { Nombre = "Roya", Edad = 25 },
                new Persona() { Nombre = "Jose Angel" , Edad = 27 },
                new Persona() { Nombre = "Luis", Edad = 31 }, 
                new Persona() { Nombre = "Jose", Edad = 37 },
                new Persona() { Nombre = "Alex", Edad = 37 },
            };

      foreach (Persona p in listaSinOrdenar) Console.WriteLine(p.Nombre);
      var resultado = Reto1.OrdenarLista(listaSinOrdenar);
      Console.WriteLine();
      foreach (Persona p in resultado) Console.WriteLine(p.Nombre + " " + p.Edad);

      var listaOrdenada = new List<Persona>()
            {
                new Persona() { Nombre = "Alex", Edad = 37 },
                new Persona() { Nombre = "Jose", Edad = 37 },
                new Persona() { Nombre = "Luis", Edad = 31 }, 
                new Persona() { Nombre = "Jose Angel" , Edad = 27 },
                new Persona() { Nombre = "Roya", Edad = 25 }
            };
      Console.WriteLine();
      foreach (Persona p in listaOrdenada) Console.WriteLine(p.Nombre + " " + p.Edad);

      Console.WriteLine(listaOrdenada.Count);
      Console.WriteLine(resultado.Count);
      for (int i = 0; i < listaOrdenada.Count; i++)
      {
        Console.WriteLine(i+" "+listaOrdenada[i].Nombre + " " + resultado[i].Nombre);
        Console.WriteLine(string.Compare(listaOrdenada[i].Nombre, resultado[i].Nombre));
      }

    }
  }
}
