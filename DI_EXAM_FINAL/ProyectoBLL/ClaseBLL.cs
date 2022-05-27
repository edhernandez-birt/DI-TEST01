using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using UtilidadesNW;

namespace ProyectoBLL
{
    public class ClaseBLL
    {
        public static string PideCadenaDatos()
        {
            //return AccesoDatos.
            //return DAL.AccesoDatos.;
            //return ProyectoBLL.ClaseBLL.PideCadenaDatos();
            return ClaseAccesoDatos.RealizarConsultaBD();
        }

        public static List<FacturacionRegionesDTO> PideListaFacturacionRegiones()
        {
            return ClaseAccesoDatos.ListaFacturacionRegiones();
        }
    }
}
