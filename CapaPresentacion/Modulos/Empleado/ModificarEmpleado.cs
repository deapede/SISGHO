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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
        }


        

        private void btnModEmp_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text))
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
                                    if (ec.ModificarEmpleado(txtUsuario.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCorreo.Text))
                                    {
                                        ec.LlenarGridEmp(App.fe.dataEmpleado);
                                        this.Dispose();
                                    }
                                        
                                        
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Debe ingresar un correo valido", "Modificar Empleado", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un correo", "Modificar Empleado", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Apellido Materno", "Modificar Empleado", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un Apellido Paterno", "Modificar Empleado", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre", "Modificar Empleado", MessageBoxButtons.OK);
                    }
                
               
            }
            else
            {
                MessageBox.Show("Ingrese Usuario", "Modificar Empleado", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
