using CapaEntidad;
using CapaNegocios;
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
    public partial class FormProducto : MetroFramework.Forms.MetroForm
    {

        ServicioProducto servicio = new ServicioProducto();
        Producto producto = new Producto();
        IRecibir recibirpro;
        public FormProducto()
        {
            InitializeComponent();
            DtgProductos.DataSource = servicio.Consultar();
        }
        public FormProducto(IRecibir recibir)
        {
            InitializeComponent();
            DtgProductos.DataSource = servicio.Consultar();
            recibirpro = recibir;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        public Producto Mapear()
        {

            producto.Nit = TxtNit.Text;
            producto.Nombre = TxtNombre.Text;
            producto.Marca = TxtMarca.Text;
            producto.Cantidad = Convert.ToInt16(TxtCantidad.Text);
            producto.ValorUnitario = Convert.ToDouble(TxtValorUnitario.Text);

            return producto;
        }

        public void Limpiar()
        {
            TxtNit.Text="";
            TxtNombre.Text="";
            TxtMarca.Text="";
            TxtCantidad.Text="";
            TxtValorUnitario.Text="";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            producto = Mapear();
            var Mensaje = servicio.Guardar(producto);
            MessageBox.Show(Mensaje, "El Producto se guardo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            DtgProductos.Update();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var nit = TxtNit.Text;
            if (nit != "")
            {
                Producto productoConsultado = servicio.Buscar(nit);
                if (productoConsultado != null)
                {
                    servicio.Modificar(servicio.Buscar(nit), servicio.CrearProducto(producto));
                }
                else
                {
                    MessageBox.Show("El Producto no existe", "Confirmacion de Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            var nit = TxtNit.Text;
            if (nit != "")
            {
                Producto productoConsultado = servicio.Buscar(nit);
                if (productoConsultado != null)
                {
                    servicio.Eliminar(servicio.Buscar(nit));
                    MessageBox.Show("Seguro que quiere eliminar el producto", "Confirmacion de eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    MessageBox.Show("El producto fue eliminado con exito", "Confirmacion de eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El Producto no existe", "Confirmacion de Eliminar" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var nit = TxtNit.Text;
            if (nit != "")
            {
                Producto productoConsultado = servicio.Buscar(nit);
                if (productoConsultado != null)
                {
                    Mapear();
                }
                else
                {
                    MessageBox.Show("El Producto no existe", "Busqueda" +
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void DtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = (Producto)DtgProductos.CurrentRow.DataBoundItem;
            recibirpro.RecibirProducto(producto);
            this.Hide();
        }
    }
}
