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
        private string selectedValue1;

        public Clientes()
        {

        }

        public Clientes(string selectedValue1, string text)
        {
            this.selectedValue1 = selectedValue1;
            this.text = text;
        }

        public List<TiposTelefonos> Tipo { get; set; }
    }
   
}
