using BLL;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertAntonio_Aplicada1_p2
{
    public partial class RegistroClientes : Form
    {
        List<Clientes> cc = new List<Clientes>();
        List<TiposTelefonos> tt = new List<TiposTelefonos>();
        private TiposTelefonos TiposTe = new TiposTelefonos();
        public RegistroClientes()
        {
            InitializeComponent();
        }
        public void Listartipo()
        {
            var conn = new Parcial2DB();
            var lis = conn.TipoTelefono.ToList();

            if (lis.Count > 0)
            {
                TipocomboBox.DataSource = lis;
                TipocomboBox.ValueMember = "Descripcion";
            }
        }
        

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes Client = new Clientes();
            Client.Nombres = NombretextBox.Text;
            Client.FechaNacimiento = FechamaskedTextBox.Text;
            Client.LimiteCredito = Convert.ToInt32(LimitemaskedTextBox.Text);

            if (BLL.ClientesBLL.Guardar(Client))
            {
                MessageBox.Show("Guardo");
            }
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            Listartipo();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            TiposTe.Client.Add(new Clientes((int)TipocomboBox.SelectedValue, TipocomboBox.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TiposTe.Client;
        }
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            var grupo = ClientesBLL.Buscar(Convert.ToInt32(ClienteIdmaskedTextBox.Text));
            if (grupo != null)
            {
                NombretextBox.Text = grupo.Nombres;
            }
        }
    }
}
