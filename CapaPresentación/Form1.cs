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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarAfiliado formafiliado = new FormAgregarAfiliado();
            formafiliado.MdiParent= this;
            formafiliado.StartPosition= FormStartPosition.CenterScreen;
            formafiliado.Show();
        }

        private void agregarPlanesAlAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlanAAfiliado objPlanAAfi = new FormPlanAAfiliado();
            objPlanAAfi.MdiParent= this;
            objPlanAAfi.StartPosition= FormStartPosition.CenterScreen;
            objPlanAAfi.Show();
        }
    }
}
