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
    
    public partial class FormListaConApellBuscado : Form
    { 
        ClienteServicio obj3 = new ClienteServicio();
        string apellido;
        
        public FormListaConApellBuscado(string apell)
        {
            apellido = apell;
            InitializeComponent();
        }

        private void FormListaConApellBuscado_Load(object sender, EventArgs e)
        {
            lstBuscaXapell.DataSource = null;
            lstBuscaXapell.DataSource = obj3.BuscarClienteXApelli(apellido);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
