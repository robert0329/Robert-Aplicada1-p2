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
using BLL;
using DAL;

namespace RobertAntonio_Aplicada1_p2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes r = new RegistroClientes();
            r.Show();
        }
    }
}
