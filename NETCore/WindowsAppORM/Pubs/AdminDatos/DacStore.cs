using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace Pubs.AdminDatos
{
    public class DacStore
    {
        PubsContext context = new PubsContext();
        public List<Store> Lista()
        {
            List<Store> lista = context.Stores.ToList();
            return lista;
        }
        public Store TraerUno(string id)
        {
            Store store = context.Stores.Find(id);
            return store;
        }
        public int Nuevo(Store store)
        {
            context.Stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Modificar(Store storeNuevo)
        {
            Store store = context.Stores.Find(storeNuevo.Stor_id);
            if (store != null)
            {
                store = storeNuevo;
            }
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public int Eliminar(Store store)
        {

            if (store != null)
            {
                // context.Stores.Remove(store);
                context.Entry(store).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                return 0;
            }

            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

    }
}
