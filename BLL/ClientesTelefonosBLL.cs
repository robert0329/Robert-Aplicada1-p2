using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientesTelefonosBLL
    {
        public static bool Guardar(ClientesTelefonos ct)
        {
            bool retorno = false;
            try
            {
                var db = new Parcial2DB();
                db.CLientT.Add(ct);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }


        public static List<ClientesTelefonos> GetLis(int ClienteId)
        {
            var lista = new List<ClientesTelefonos>();
            using (var conexion = new Parcial2DB())
            {
                try
                {
                    lista = conexion.CLientT.Where(ge => ge.ClienteId== ClienteId).ToList();
                }
                catch (Exception)
                {
                }
            }
            return lista;
        }

        public static List<ClientesTelefonos> GetLista()
        {
            List<ClientesTelefonos> lista = new List<ClientesTelefonos>();
            var db = new Parcial2DB();

            lista = db.CLientT.ToList();
            return lista;
        }
    }
}
