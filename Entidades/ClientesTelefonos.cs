using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesTelefonos
    {
        [Key]
        public int Id;
        public int ClienteId;
        public int TipoId;
    }
}
