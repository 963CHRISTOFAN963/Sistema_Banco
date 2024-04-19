using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco_Nubank.Models
{
    public class Clientes
    {
       public int ID {get; set;}
       public string  Endereço {get; set;}
       public int Numero {get; set;}
       public string Nome {get; set;}
       public string Idade {get; set;}
       public string Celular {get; set;}
    }
}