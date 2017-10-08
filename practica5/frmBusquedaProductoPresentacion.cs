using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using AccesoDatos;

namespace Vista
{
    public partial class frmBusquedaProductoPresentacion : Form
    {
        private BindingList<Producto> prods;
        private BindingList<Presentacion> pres;
        private ProdPres productoSeleccionado;

        public ProdPres ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        public frmBusquedaProductoPresentacion()
        {
            InitializeComponent();
            ProductoDA proDA = new ProductoDA();
            PresentacionDA preDA = new PresentacionDA();

            prods = proDA.GetProductos();
            pres = preDA.GetPresentaciones();

            dgvProductoPresentacion.DataSource = GetCruce();

        }

        private BindingList<ProdPres> GetCruce()
        {
            FileStream arch = new FileStream("productopresentacion.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<ProdPres> ret = new BindingList<ProdPres>();

            while (true)
            {
                string auxpro = reader.ReadLine();
                if (auxpro == null) break;
                string auxpre = reader.ReadLine();
                string auxprecio = reader.ReadLine();
                string auxstock = reader.ReadLine();
                ProdPres item = new ProdPres();
                foreach(Producto pr in prods)
                {
                    if(pr.Codigo == Int32.Parse(auxpro))
                    {
                        item.Producto = pr;
                        item.Nombre = pr.Nombre;
                        break;
                    }
                }

                foreach(Presentacion pr in pres)
                {
                    if(pr.Codigo == Int32.Parse(auxpre))
                    {
                        item.Presentacion = pr;
                        item.Unidad = pr.Unidad;
                        break;
                    }
                }

                item.Precio = float.Parse(auxprecio);
                item.Stock = Int32.Parse(auxstock);

                ret.Add(item);
            }

            reader.Close();
            arch.Close();
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dgvProductoPresentacion.CurrentRow == null)
            {
                return;
            }
            ProductoSeleccionado = (ProdPres)dgvProductoPresentacion.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
