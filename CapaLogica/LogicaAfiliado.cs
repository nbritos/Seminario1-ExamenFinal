using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaAfiliado
    {
        CDConexion objDatos = new CDConexion();
        
        public DataSet TraerAfiliados()
        {
            return objDatos.Read();
        }

        public DataTable TraerPlanes()
        {
           return objDatos.TraerPlanes();
        }

        public void Agregar(Afiliado paramAfi)
        {
            objDatos.Create(paramAfi);
        }

    }
}
