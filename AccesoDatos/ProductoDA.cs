using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Modelo;

namespace AccesoDatos
{
    public class ProductoDA
    {
        public ProductoDA()
        {

        }

        public BindingList<Producto> GetProductos()
        {
            FileStream arch = new FileStream("productos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(arch);
            BindingList<Producto> ret = new BindingList<Producto>();

            while (true)
            {
                string aux = reader.ReadLine();
                if (aux == null) break;
                string nombre = reader.ReadLine();
                string descripcion = reader.ReadLine();
                int codigo = Int32.Parse(aux);

                Producto prod = new Producto(codigo, nombre, descripcion);
                ret.Add(prod);  
            }

            reader.Close();
            arch.Close();

            return ret;
        }
    }
}
