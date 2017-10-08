using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.IO;

namespace AccesoDatos
{
    public class PresentacionDA
    {
        public PresentacionDA()
        {

        }

        public BindingList<Presentacion> GetPresentaciones()
        {
            FileStream arch = new FileStream("presentaciones.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<Presentacion> ret = new BindingList<Presentacion>();

            while (true)
            {
                string aux = reader.ReadLine();
                if (aux == null) break;
                string unidad = reader.ReadLine();
                int codigo = Int32.Parse(aux);

                Presentacion prod = new Presentacion(codigo, unidad);
                ret.Add(prod);
            }

            reader.Close();
            arch.Close();

            return ret;
        }
    }
}
