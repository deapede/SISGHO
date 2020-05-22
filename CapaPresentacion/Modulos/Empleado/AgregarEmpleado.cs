using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Modulos.Empleado
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!String.IsNullOrEmpty(txtContraseña.Text))
                {
                    if (!String.IsNullOrEmpty(txtNombre.Text))
                    {
                        if (!String.IsNullOrEmpty(txtApellidoP.Text))
                        {
                            if (!String.IsNullOrEmpty(txtApellidoM.Text))
                            {
                                if (!String.IsNullOrEmpty(txtCorreo.Text))
                                {
                                    try
                                    {
                                        EmpleadoController ec = new EmpleadoController();
                                        if (ec.AgregarEmpleado(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCorreo.Text))
                                        {
                                            ec.LlenarGridEmp(App.fe.dataEmpleado);
                                            this.Dispose();
                                        }
                                        
                                       

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Debe ingresar un correo valido", "Crear Empleado", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un correo", "Crear Empleado", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Apellido Materno", "Crear Empleado", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un Apellido Paterno", "Crear Empleado", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre", "Crear Empleado", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese contraseña", "Crear Empleado", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese Usuario", "Crear Empleado", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
