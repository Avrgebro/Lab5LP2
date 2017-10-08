using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable]
    public class DetallePromocion
    {
        private string _nombre;
        private float _costou;
        private string _unidad;
        private int _cantidad;

        public DetallePromocion(string nombre, float costou, string unidad, int cantidad)
        {
            Nombre = nombre;
            Costou = costou;
            Unidad = unidad;
            Cantidad = cantidad;
        }

        public DetallePromocion()
        {

        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Costou { get => _costou; set => _costou = value; }
        public string Unidad { get => _unidad; set => _unidad = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
