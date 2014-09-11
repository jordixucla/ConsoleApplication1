using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1ClassLibrary
{
  public class Persona
  {
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona()
    {
      Nombre = "";
      Edad = 0;
    }
  }

  public class Reto1
  {
    public static List<Persona> OrdenarLista(List<Persona> lista)
    {
      if (lista == null)
        return null;

      lista.Sort((x, y) => x.Edad == y.Edad ? string.Compare(x.Nombre, y.Nombre) : (x.Edad > y.Edad ? -1 : 1));
      return lista;
    }
  }
}
