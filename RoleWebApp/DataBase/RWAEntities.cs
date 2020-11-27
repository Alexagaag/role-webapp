using RoleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace RoleWebApp.DataBase
{
    public class RWAEntities : DbContext
    {
        public RWAEntities(string connstr) : base(connstr) {}

        public DbSet<Permiso> Permiso { get; set; }

        public DbSet<TipoPermiso> TipoPermiso { get; set; }


    }
}
