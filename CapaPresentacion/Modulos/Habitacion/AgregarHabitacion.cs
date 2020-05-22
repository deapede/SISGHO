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
    public partial class AgregarHabitacion : Form
    {
        public AgregarHabitacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                                    if(hc.AgregarHabitacion(int.Parse(txtNumero.Text), txtTipoCama.Text, txtAccesorios.Text, int.Parse(txtPrecio.Text)))
                                    {
                                        hc.LlenarGrid(App.fh.dataHabitaciones);
                                        this.Dispose();
                                    }
                                    
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Accesorios.", "Crear Habitacion", MessageBoxButtons.OK);
                                }
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Ingrese precio valido.", "Crear Habitacion", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Numero.", "Crear Habitacion", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Tipo de Cama.", "Crear Habitacion", MessageBoxButtons.OK);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ingrese Numero Valido.", "Crear Habitacion", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Numero de Habitacion.", "Crear Habitacion", MessageBoxButtons.OK);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

 
    }
}
