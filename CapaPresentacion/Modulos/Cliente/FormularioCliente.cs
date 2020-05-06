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

namespace CapaPresentacion.Modulos.Cliente
{
    public partial class FormularioCliente : Form
    {
        
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

            ClienteController cc = new ClienteController();
            cc.LlenarGrid(dataClientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente ac = new AgregarCliente();
            ac.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                
            ClienteController cc = new ClienteController();
            int id = int.Parse(dataClientes.CurrentRow.Cells[0].Value.ToString());
            ModificarCliente mc = new ModificarCliente();
            cc.LlenarCampos(id, mc.txtUsuario, mc.txtContraseña, mc.txtNombre, mc.txtApellidoP, mc.txtApellidoM, mc.txtCorreo, mc.txtRut, mc.txtNombreE, mc.txtRubro, mc.txtDireccion, mc.txtTelefono, mc.id);
            mc.Show();
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteController cc = new ClienteController();
            int id = int.Parse(dataClientes.CurrentRow.Cells[0].Value.ToString());
            cc.EliminarCliente(id);
            cc.LlenarGrid(App.fc.dataClientes);
        }
    }
}
