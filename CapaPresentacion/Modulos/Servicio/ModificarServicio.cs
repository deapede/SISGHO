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
    public partial class ModificarServicio : Form
    {
        public ModificarServicio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPlato.Text))
            {
                if (!String.IsNullOrEmpty(txtPrecio.Text))
                {
                    try
                    {
                        ServicioController sc = new ServicioController();
                        if (sc.ModificarServicio(int.Parse(labelId.Text), txtPlato.Text, int.Parse(txtPrecio.Text), comboServicio.Text))
                        {
                            sc.LlenarGrid(App.fs.dataServicios);
                            this.Dispose();
                        }
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ingrese un numero valido.", "Modificar Servicio", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese precio.", "Modificar Servicio", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre del plato.", "Modificar Servicio", MessageBoxButtons.OK);
            }
        }
        
    }
}
