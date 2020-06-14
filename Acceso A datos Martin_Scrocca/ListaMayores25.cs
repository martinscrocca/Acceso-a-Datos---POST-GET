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
    public partial class ListaMayores25 : Form
    {
        ClienteServicio OBJ2 = new ClienteServicio();
        public ListaMayores25()
        {
            InitializeComponent();
        }

        private void ListaMayores25_Load(object sender, EventArgs e)
        {
            lst25.DataSource = null;
            lst25.DataSource = OBJ2.TraerClientesMas25();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
