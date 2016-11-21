using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TiposTelefonosBLL
    {
        public static bool Guardar(TiposTelefonos Tipo)
        {
            bool retorno = false;
            Parcial2DB r = new Parcial2DB();
            try
            {
                r.TipoTelefono.Add(Tipo);
                r.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        public static TiposTelefonos Buscar(int Id)
        {
            TiposTelefonos tt = new TiposTelefonos();
            using (var conexion = new Parcial2DB())
            {
                try
                {
                    tt = conexion.TipoTelefono.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tt;
        }
        public static List<Clientes> GetList()
        {
            var lista = new List<Clientes>();
            using (var db = new Parcial2DB())
            {
                lista = db.clientes.ToList();
                return lista;
            }
        }
    }
}
