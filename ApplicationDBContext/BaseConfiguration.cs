using Banco_Nubank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banco_Nubank.ApplicationDBContext
{
    public class BaseConfiguration : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public BaseConfiguration() : base("Name=BaseConfiguration") { }

        }
    }
