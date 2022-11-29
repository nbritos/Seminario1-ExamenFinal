using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AfiliadoPlanesAdicionales
    {
        public int IDAfiliadoPlan { get; set; }
        public int IDAfiliado { get; set; }
        public int IDPlan { get; set; }
        public double PorcentajeCobertura { get; set; }
    }
}
