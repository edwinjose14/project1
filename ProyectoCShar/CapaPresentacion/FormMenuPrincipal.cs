using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FormEstilista formEstilista = new FormEstilista();

            formEstilista.ShowDialog();

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();
            formProducto.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactProducto formFactProducto = new FormFactProducto();
            formFactProducto.ShowDialog();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactServicio formFactServicio = new FormFactServicio();
            formFactServicio.ShowDialog();
        }

        private void ventasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.ShowDialog ();
        }
    }
}
