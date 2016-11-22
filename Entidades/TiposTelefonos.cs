using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId;
        public string Descripcion;
        public List<Clientes> Client { get; set; }
    }
}
