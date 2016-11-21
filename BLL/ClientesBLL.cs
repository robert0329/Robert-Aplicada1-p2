using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            Parcial2DB r = new Parcial2DB();
            try
            {
                r.clientes.Add(cliente);
                r.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        public static Clientes Buscar(int Id)
        {
            Clientes Client = new Clientes();
            using (var conexion = new Parcial2DB())
            {
                try
                {
                    Client = conexion.clientes.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Client;
        }
        public static bool Eliminar(int e)
        {
            bool r = false;
            using (var db = new Parcial2DB())
            {
                try
                {
                    Clientes c = db.clientes.Find(e);
                    db.clientes.Remove(c);
                    db.SaveChanges();
                    r = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return r;
            }
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

        public static List<Clientes> GetLista(int id)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new Parcial2DB();

            lista = db.clientes.Where(u => u.clienteId == id).ToList();
            return lista;
        }
    }
}
