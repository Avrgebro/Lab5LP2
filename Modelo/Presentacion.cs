using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Presentacion
    {
        private int _codigo;
        private string _unidad;

        public Presentacion(int codigo, string unidad)
        {
            Codigo = codigo;
            Unidad = unidad;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Unidad { get => _unidad; set => _unidad = value; }
    }
}
