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

namespace CapaPresentacion.Modulos.Servicio
{
    public partial class FormularioServicio : Form
    {
        public FormularioServicio()
        {
            InitializeComponent();
        }

        private void FormularioServicio_Load(object sender, EventArgs e)
        {
            ServicioController sc = new ServicioController();
            sc.LlenarGrid(dataServicios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarServicio ags = new AgregarServicio();
            ags.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioController sc = new ServicioController();
                int id = int.Parse(dataServicios.CurrentRow.Cells[0].Value.ToString());
                ModificarServicio ms = new ModificarServicio();
                sc.LlenarComboTipo(ms.comboServicio);
                sc.LlenarCampos(id, ms.txtPlato, ms.txtPrecio, ms.comboServicio, ms.labelId);
                ms.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un servicio.", "Modificar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioController sc = new ServicioController();
                int id = int.Parse(dataServicios.CurrentRow.Cells[0].Value.ToString());
                sc.EliminarServicio(id);
                sc.LlenarGrid(App.fs.dataServicios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un servicio.", "Eliminar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
