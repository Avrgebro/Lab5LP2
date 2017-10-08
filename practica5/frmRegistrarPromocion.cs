using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Modelo;
using AccesoDatos;

namespace Vista
{
    public partial class frmRegistrarProducto : Form
    {
        private Promocion promo;
        public frmRegistrarProducto()
        {
            InitializeComponent();
            FileStream pedidos;
            try
            {
                pedidos = new FileStream("promociones.bin", FileMode.Open, FileAccess.Write);
            }catch(Exception se)
            {
                pedidos = new FileStream("promociones.bin", FileMode.Create, FileAccess.Write);
            }
            
            pedidos.Close();
            SetEstado(0);
        }

        public void LimpiarDatos()
        {
            promo = new Promocion();
            txtCantidad.Text = "";
            txtCostoUnitario.Text = "";
            txtDescripcionProducto.Text = "";
            txtDescripcionPromocion.Text = "";
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtNombrePromocion.Text = "";
            txtStock.Text = "";
            txtUnidadMedida.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaTermino.Value = DateTime.Now;
            txtCostoTotal.Text = "";
            dgvDetallePromocion.DataSource = promo.Productos;

        }

        public void SetEstado(int e)
        {
            if(e == 0)//inicial
            {
                //LimpiarDatos();
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCantidad.Enabled = false;
                txtCostoUnitario.Enabled = false;
                txtDescripcionProducto.Enabled = false;
                txtDescripcionPromocion.Enabled = false;
                txtIdProducto.Enabled = false;
                txtNombreProducto.Enabled = false;
                txtNombrePromocion.Enabled = false;
                txtStock.Enabled = false;
                txtUnidadMedida.Enabled = false;
                dtpFechaInicio.Enabled = false;
                dtpFechaTermino.Enabled = false;
                txtCostoTotal.Enabled = false;
                dgvDetallePromocion.Enabled = false;
            }
            else if(e == 1)//nuevo
            {
                LimpiarDatos();
                btnNuevo.Enabled = false;
                btnAgregar.Enabled = true;
                btnBuscarProducto.Enabled = true;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                txtCantidad.Enabled = true;
                //txtCostoUnitario.Enabled = true;
                //txtDescripcionProducto.Enabled = true;
                txtDescripcionPromocion.Enabled = true;
                //txtIdProducto.Enabled = true;
                //txtNombreProducto.Enabled = true;
                txtNombrePromocion.Enabled = true;
                //txtStock.Enabled = true;
                //txtUnidadMedida.Enabled = true;
                dtpFechaInicio.Enabled = true;
                dtpFechaTermino.Enabled = true;
                txtCostoTotal.Enabled = true;
                dgvDetallePromocion.Enabled = true;
            }
            else if(e == 2)
            {
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCantidad.Enabled = false;
                txtCostoUnitario.Enabled = false;
                txtDescripcionProducto.Enabled = false;
                txtDescripcionPromocion.Enabled = false;
                txtIdProducto.Enabled = false;
                txtNombreProducto.Enabled = false;
                txtNombrePromocion.Enabled = false;
                txtStock.Enabled = false;
                txtUnidadMedida.Enabled = false;
                dtpFechaInicio.Enabled = false;
                dtpFechaTermino.Enabled = false;
                txtCostoTotal.Enabled = false;
                dgvDetallePromocion.Enabled = false;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPromocion frmBusqProm = new frmBusquedaPromocion();
            //frmBusqProm.ShowDialog();
            LimpiarDatos();
            if (frmBusqProm.ShowDialog() == DialogResult.OK)
            {
                txtNombrePromocion.Text = frmBusqProm.PromoSeleccionada.Nombre;
                txtDescripcionPromocion.Text = frmBusqProm.PromoSeleccionada.Descripcion;
                dtpFechaInicio.Value = frmBusqProm.PromoSeleccionada.Fechaini;
                dtpFechaTermino.Value = frmBusqProm.PromoSeleccionada.Fechafin;
                txtCostoTotal.Text = frmBusqProm.PromoSeleccionada.Costo.ToString("N2");
                dgvDetallePromocion.DataSource = frmBusqProm.PromoSeleccionada.Productos;
                

            }



        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProductoPresentacion frmBusqProdPres = new frmBusquedaProductoPresentacion();
            //frmBusqProdPres.ShowDialog();
            if (frmBusqProdPres.ShowDialog() == DialogResult.OK)
            {
                txtIdProducto.Text = frmBusqProdPres.ProductoSeleccionado.Producto.Codigo.ToString();
                txtNombreProducto.Text = frmBusqProdPres.ProductoSeleccionado.Nombre;
                txtDescripcionProducto.Text = frmBusqProdPres.ProductoSeleccionado.Producto.Descripcion;
                txtCostoUnitario.Text = frmBusqProdPres.ProductoSeleccionado.Precio.ToString("N2");
                txtStock.Text = frmBusqProdPres.ProductoSeleccionado.Stock.ToString();
                txtUnidadMedida.Text = frmBusqProdPres.ProductoSeleccionado.Unidad;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            promo = new Promocion();
            SetEstado(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetEstado(0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //aca meto la huevada
            if(txtIdProducto.Text == "" || txtCantidad.Text == "") { return; }
            DetallePromocion nuevo = new DetallePromocion();
            nuevo.Nombre = txtNombreProducto.Text;
            nuevo.Unidad = txtUnidadMedida.Text;
            nuevo.Costou = float.Parse(txtCostoUnitario.Text);
            nuevo.Cantidad = Int32.Parse(txtCantidad.Text);
            promo.Productos.Add(nuevo);
            dgvDetallePromocion.DataSource = promo.Productos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //aca lo escribo en promociones
            

            promo.Descripcion = txtDescripcionPromocion.Text;
            promo.Nombre = txtNombrePromocion.Text;
            promo.Fechaini = dtpFechaInicio.Value;
            promo.Fechafin = dtpFechaTermino.Value;
            promo.Costo = float.Parse(txtCostoTotal.Text);
            PromocionDA pDA = new PromocionDA();
            pDA.GuardarPromocion(promo);
            SetEstado(2);
            
        }
    }
}
