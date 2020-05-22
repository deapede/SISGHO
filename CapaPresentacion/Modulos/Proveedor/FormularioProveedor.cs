using CapaNegocio;
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

        private void FormularioProveedor_Load(object sender, EventArgs e)
        {
            ProveedorController pc = new ProveedorController();
            pc.LlenarGrid(dataProv);
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            AgregarProveedor ac = new AgregarProveedor();
            ac.Show();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorController pc = new ProveedorController();
                int id = int.Parse(dataProv.CurrentRow.Cells[0].Value.ToString());
                EditarProveedor ep = new EditarProveedor();
                pc.LlenarCampos(id, ep.txtUsuario, ep.txtNombre, ep.txtApellidoP, ep.txtApellidoM, ep.txtCorreo, ep.txtRubro, ep.txtTelefono, ep.txtDesc, ep.txtSitio, ep.labelID);
                ep.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 proveedor.", "Modificar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorController ec = new ProveedorController();
                int id = int.Parse(dataProv.CurrentRow.Cells[0].Value.ToString());
                ec.EliminarProv(id);
                ec.LlenarGrid(App.fp.dataProv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 proveedor.", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarPass_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorController pc = new ProveedorController();
                int id = int.Parse(dataProv.CurrentRow.Cells[0].Value.ToString());
                ModificarContraseña mc = new ModificarContraseña();
                pc.CambiarPassId(mc.labelID, id);
                mc.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 empleado.", "Modificar Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
