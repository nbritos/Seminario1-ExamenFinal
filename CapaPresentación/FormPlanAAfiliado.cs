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

        private void dgvAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvAfiliados.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvAfiliados.CurrentRow.Cells["apellido"].Value.ToString();
            txtIDAfi.Text = dgvAfiliados.CurrentRow.Cells["idAfiliado"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAfiliado = int.Parse(txtIDAfi.Text);
            int idPlan = int.Parse(comboBoxPlanes.SelectedItem.ToString());

            //Afiliado objAfiliado = new Afiliado();
            //objAfiliado.Nombre = dgvAfiliados.CurrentRow.Cells["nombre"].Value.ToString();
            //objAfiliado.Apellido = dgvAfiliados.CurrentRow.Cells["apellido"].Value.ToString();
            //objAfiliado.IDPlan = (int)dgvAfiliados.CurrentRow.Cells["idPlan"].Value;
            //objAfiliado.FechaAlta = (DateTime)dgvAfiliados.CurrentRow.Cells["fechaAlta"].Value;
            //objAfiliado.Observaciones = dgvAfiliados.CurrentRow.Cells["observaciones"].Value.ToString();

            //objLogicaAdicional.Update(objAfiliado);

        }
    }
}
