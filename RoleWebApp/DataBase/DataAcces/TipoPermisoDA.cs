using Microsoft.Extensions.Configuration;
using RoleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.DataBase.DataAcces
{
    public class TipoPermisoDA : BaseDA
    {



        public TipoPermiso Get(int Id)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    TipoPermiso result = ctx.TipoPermiso.FirstOrDefault(x => x.Id == Id);
                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public List<TipoPermiso> GetAll()
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    List<TipoPermiso> result = ctx.TipoPermiso.ToList();
                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


        }
        public void Delete(TipoPermiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    ctx.TipoPermiso.Remove(value);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Edit(TipoPermiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    ctx.Entry(value).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Add(TipoPermiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    ctx.TipoPermiso.Add(value);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
