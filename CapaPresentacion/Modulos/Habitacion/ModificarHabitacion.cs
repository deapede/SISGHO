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
    public partial class ModificarHabitacion : Form
    {
        public ModificarHabitacion()
        {
            InitializeComponent();
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumero.Text))
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtTipoCama.Text))
                    {
                        if (!String.IsNullOrEmpty(txtPrecio.Text))
                        {
                            try
                            {
                                if (!String.IsNullOrEmpty(txtAccesorios.Text))
                                {
                                    HabitacionController hc = new HabitacionController();
                                    if(hc.ModificarHabitacion(int.Parse(labelidHabitacion.Text), int.Parse(txtNumero.Text), txtTipoCama.Text, int.Parse(txtPrecio.Text), comboEstado.Text, txtAccesorios.Text))
                                    {
                                        hc.LlenarGrid(App.fh.dataHabitaciones);
                                        this.Dispose();
                                    }
                                     
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Accesorios.", "Modificar Habitacion", MessageBoxButtons.OK);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ingrese precio valido.", "Modificar Habitacion", MessageBoxButtons.OK);
                           }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Numero.", "Modificar Habitacion", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Tipo de Cama.", "Modificar Habitacion", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
               {
                   MessageBox.Show("Ingrese Numero Valido.", "Modificar Habitacion", MessageBoxButtons.OK);
               }
            }
            else
            {
                MessageBox.Show("Ingrese Numero de Habitacion.", "Modificar Habitacion", MessageBoxButtons.OK);
            }

        }
    }
}
