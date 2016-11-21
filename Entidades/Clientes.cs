using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Clientes
     {
        [Key]
        public int clienteId;
        public string Nombres;
        public string FechaNacimiento;
        public double LimiteCredito;
        private int selectedValue;
        private string text;

        public Clientes()
        {

        }
        public Clientes(int selectedValue, string text)
        {
            this.selectedValue = selectedValue;
            this.text = text;
        }

        public List<TiposTelefonos> Tipo { get; set; }
    }
   
}
