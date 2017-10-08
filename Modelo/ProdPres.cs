using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class ProdPres
    {
        private Producto _producto;
        private Presentacion _presentacion;
        private string _nombre;
        private string _unidad;
        private float _precio;
        private int _stock;

        public ProdPres()
        {

        }

        public ProdPres(Producto producto, Presentacion presentacion, string nombre, string unidad, float precio, int stock)
        {
            Producto = producto;
            Presentacion = presentacion;
            Nombre = nombre;
            Unidad = unidad;
            Precio = precio;
            Stock = stock;
        }

        public Producto Producto { get => _producto; set => _producto = value; }
        public Presentacion Presentacion { get => _presentacion; set => _presentacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Unidad { get => _unidad; set => _unidad = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
