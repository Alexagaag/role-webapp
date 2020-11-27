using RoleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.DataBase.DataAccesInterface
{
    public interface IPermisosDA
    {
        public Permiso Get(int Id);
        public List<Permiso> GetAll();
        public void Delete(Permiso value);
        public void Edit(Permiso value);
        public void Add(Permiso value);

    }
}
