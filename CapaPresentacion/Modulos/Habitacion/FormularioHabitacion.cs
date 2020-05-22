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

namespace CapaPresentacion.Modulos.Habitacion
{
    public partial class FormularioHabitacion : Form
    {
        public FormularioHabitacion()
        {
            InitializeComponent();
        }

        private void FormularioHabitacion_Load(object sender, EventArgs e)
        {
            HabitacionController hc = new HabitacionController();
            hc.LlenarGrid(dataHabitaciones);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarHabitacion ah = new AgregarHabitacion();
            ah.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                HabitacionController hc = new HabitacionController();
                int id = int.Parse(dataHabitaciones.CurrentRow.Cells[0].Value.ToString());
                ModificarHabitacion mh = new ModificarHabitacion();
                hc.LlenarComboEstado(mh.comboEstado);
                hc.LlenarCampos(id,mh.txtNumero,mh.txtTipoCama,mh.txtPrecio,mh.comboEstado,mh.txtAccesorios, mh.labelidHabitacion);
                mh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una habitacion.", "Modificar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                HabitacionController hc = new HabitacionController();
                int id = int.Parse(dataHabitaciones.CurrentRow.Cells[0].Value.ToString());
                hc.EliminarHabitacion(id);
                hc.LlenarGrid(App.fh.dataHabitaciones);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una habitacion.", "Eliminar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

