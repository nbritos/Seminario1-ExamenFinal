using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaAdicionales
    {
        CDConexion objDatos = new CDConexion();
        public DataSet TraerAfiliadoPlanesAdicionales()
        {
            return objDatos.TraerAfiliadoPlanesAdicionales();
        }
    }
}
