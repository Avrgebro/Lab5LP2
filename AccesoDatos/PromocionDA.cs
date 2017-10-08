using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AccesoDatos
{
    public class PromocionDA
    {
        public PromocionDA()
        {

        }

        public BindingList<Promocion> GetPromociones()
        {
            BindingList<Promocion> ret = new BindingList<Promocion>();

            FileStream arch = new FileStream("promociones.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();

            while (true)
            {
                Promocion p;
                try { p = (Promocion)formatter.Deserialize(arch); }
                catch(Exception se) { break; }
                ret.Add(p);
            }

            arch.Close();
            return ret;
        }

        public void GuardarPromocion(Promocion promo)
        {
            FileStream archivo = new FileStream("promociones.bin", FileMode.Append, FileAccess.Write);
            BinaryFormatter Formateador = new BinaryFormatter();
            Formateador.Serialize(archivo, promo);
            archivo.Close();
            
        }
    }
}
