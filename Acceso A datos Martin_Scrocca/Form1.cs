using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entindades;
using Negocio;

namespace Acceso_A_datos_Martin_Scrocca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnListaComp_Click(object sender, EventArgs e)
        {
            ListaCompleta frmLC = new ListaCompleta();
            frmLC.Owner = this;
            frmLC.Show();
            this.Hide();
        }

        private void BtnListaMayores_25_Click(object sender, EventArgs e)
        {
            ListaMayores25 FRMMAY = new ListaMayores25();
            FRMMAY.Owner = this;
            FRMMAY.Show();
            this.Hide();


        }

        private void BtnBuscarApell_Click(object sender, EventArgs e)
        {
            FormListaConApellBuscado FrmXapell = new FormListaConApellBuscado(txtApell.Text);
            FrmXapell.Owner = this;
            FrmXapell.Show();
            this.Hide();
        }

        private void BtnGuarDatos_Click(object sender, EventArgs e)
        {

            ClienteServicio ser = new ClienteServicio();

            int cod = ser.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text);

            MessageBox.Show("EL Cliente N° " + cod.ToString() + " se ha insertado correctamente");




            
        }
    }
}
