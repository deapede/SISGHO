using System;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Modulos.Empleado
{
    public partial class FormularioEmpleado : Form
    {
        public FormularioEmpleado()
        {
            InitializeComponent();
        }

        private void FormularioEmpleado_Load(object sender, EventArgs e)
        {
            EmpleadoController ec = new EmpleadoController();
            ec.LlenarGridEmp(dataEmpleado);
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
