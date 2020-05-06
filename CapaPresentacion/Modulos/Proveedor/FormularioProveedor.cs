using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modulos.Proveedor
{
    public partial class FormularioProveedor : Form
    {
        public FormularioProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            AgregarProveedor ap = new AgregarProveedor();
            ap.Show();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            ModificarProveedor mp = new ModificarProveedor();
            mp.Show();
        }
    }
}
