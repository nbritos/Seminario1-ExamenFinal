using CapaEntidad;
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
    public partial class FormAgregarAfiliado : Form
    {
        LogicaAfiliado objlogica = new LogicaAfiliado();
        public FormAgregarAfiliado()
        {
            InitializeComponent();
        }

        private void FormAgregarAfiliado_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            objlogica.TraerPlanes();
            dataGridView1.DataSource = objlogica.TraerAfiliados().Tables["tabla"];
            listboxPlan.DataSource = objlogica.TraerPlanes();
            listboxPlan.DisplayMember= "idplan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afiliado objAfiliado = new Afiliado();
            objAfiliado.Nombre=txtNombre.Text;
            objAfiliado.Apellido = txtApellido.Text;
            objAfiliado.IDPlan=(int)listboxPlan.SelectedIndex;
            objAfiliado.FechaAlta = dtpFechaAlta.Value.Date;
            objAfiliado.Observaciones = txtObs.Text;

            objlogica.Agregar(objAfiliado);
            
        }
    }
}
