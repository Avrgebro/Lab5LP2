using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class Promocion
    {
        private string _nombre;
        private string _descripcion;
        private DateTime _fechaini;
        private DateTime _fechafin;
        private float _costo;
        private BindingList<DetallePromocion> _productos;

        public Promocion(string nombre, string descripcion, DateTime fechaini, DateTime fechafin, float costo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fechaini = fechaini;
            Fechafin = fechafin;
            Costo = costo;
            Productos = new BindingList<DetallePromocion>();
        }

        public Promocion()
        {
            Productos = new BindingList<DetallePromocion>();
            Costo = 0;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime Fechaini { get => _fechaini; set => _fechaini = value; }
        public DateTime Fechafin { get => _fechafin; set => _fechafin = value; }
        public float Costo { get => _costo; set => _costo = value; }
        public BindingList<DetallePromocion> Productos { get => _productos; set => _productos = value; }
    }
}
