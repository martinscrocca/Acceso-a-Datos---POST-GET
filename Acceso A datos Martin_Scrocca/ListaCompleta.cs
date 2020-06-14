using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Acceso_A_datos_Martin_Scrocca
{
    public partial class ListaCompleta : Form
    {
        ClienteServicio OBJ1 = new ClienteServicio();
        public ListaCompleta()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListaCompleta_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = OBJ1.TraerClientes();

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void BtnSalirAPP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
