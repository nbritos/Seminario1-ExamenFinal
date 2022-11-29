using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FormPlanAAfiliado : Form
    {
        LogicaAdicionales objLogicaAdicional = new LogicaAdicionales();
        public FormPlanAAfiliado()
        {
            InitializeComponent();
        }

        private void FormPlanAAfiliado_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            objLogicaAdicional.TraerAfiliadoPlanesAdicionales();
            dgvAfiliados.DataSource = objLogicaAdicional.TraerAfiliadoPlanesAdicionales().Tables["tabla"];

        }
    }
}
