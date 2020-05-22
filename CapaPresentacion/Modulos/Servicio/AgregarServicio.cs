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
    public partial class AgregarServicio : Form
    {
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            ServicioController sc = new ServicioController();
            sc.LlenarComboTipo(comboServicio);
            comboServicio.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPlato.Text))
            {
                if (!String.IsNullOrEmpty(txtPrecio.Text))
                {
                    try
                    {
                        ServicioController sc = new ServicioController();
                        if(sc.AgregarServicio(txtPlato.Text, int.Parse(txtPrecio.Text), comboServicio.Text))
                        {
                            sc.LlenarGrid(App.fs.dataServicios);
                            this.Dispose();
                        }
                        
                        
                    }
                    catch (Exception ex)
                   {
                        MessageBox.Show("Ingrese un numero valido.", "Crear Servicio", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese precio.", "Crear Servicio", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre del plato.", "Crear Servicio", MessageBoxButtons.OK);
            }
        }
    }
}
