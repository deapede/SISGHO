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
namespace CapaPresentacion.Modulos
{
    public partial class AgregarCliente : Form
    {
       
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                                    if (!String.IsNullOrEmpty(txtRut.Text))
                                    {
                                        if (!String.IsNullOrEmpty(txtNombreE.Text))
                                        {
                                            if (!String.IsNullOrEmpty(txtRubro.Text))
                                            {
                                                if (!String.IsNullOrEmpty(txtDireccion.Text))
                                                {
                                                    if (!String.IsNullOrEmpty(txtTelefono.Text))
                                                    {
                                                      try
                                                            {
                                                             ClienteController cc = new ClienteController();
                                                             cc.AgregarCliente(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCorreo.Text, txtRut.Text, txtNombreE.Text, txtRubro.Text, txtDireccion.Text, int.Parse(txtTelefono.Text));
                                                             cc.LlenarGrid(App.fc.dataClientes);
                                                             this.Dispose();
                                                           }
                                                        catch(Exception ex)
                                                        {
                                                            MessageBox.Show("Debe ingresar un numero de telefono valido.", "Crear Usuario", MessageBoxButtons.OK);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Ingrese Telefono.", "Crear Usuario", MessageBoxButtons.OK);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese Direccion.", "Crear Usuario", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese Rubro.", "Crear Usuario", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese Nombre Empresa.", "Crear Usuario", MessageBoxButtons.OK);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese Rut.", "Crear Usuario", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Correo.", "Crear Usuario", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Apellido Materno.", "Crear Usuario", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Apellido Paterno.", "Crear Usuario", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre.", "Crear Usuario", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Contrasena.", "Crear Usuario", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Ingrese Usuario.", "Crear Usuario", MessageBoxButtons.OK);
            }
            
        }
    }
}
