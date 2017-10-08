using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Modelo;

namespace Vista
{
    public partial class frmBusquedaPromocion : Form
    {
        private Promocion promoSeleccionada;
        public frmBusquedaPromocion()
        {
            InitializeComponent();
            PromocionDA promoDA = new PromocionDA();
            dgvPromociones.DataSource = promoDA.GetPromociones();
        }

        public Promocion PromoSeleccionada { get => promoSeleccionada; set => promoSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvPromociones.CurrentRow == null)
            {
                return;
            }
            PromoSeleccionada = (Promocion)dgvPromociones.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
