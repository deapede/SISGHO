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

namespace CapaPresentacion.Modulos.Proveedor
{
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
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
                                    if (!String.IsNullOrEmpty(txtRubro.Text))
                                    {
                                        if (!String.IsNullOrEmpty(txtTelefono.Text))
                                        {
                                            if (!String.IsNullOrEmpty(txtDesc.Text))
                                            {
                                                if (!String.IsNullOrEmpty(txtSitio.Text))
                                                {
                                                    
                                                        try
                                                        {
                                                            ProveedorController cc = new ProveedorController();
                                                        if (cc.AgregarProv(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCorreo.Text, txtRubro.Text, int.Parse(txtTelefono.Text), txtDesc.Text, txtSitio.Text))
                                                        {
                                                            cc.LlenarGrid(App.fp.dataProv);
                                                            this.Dispose();
                                                        }
                                                            
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            MessageBox.Show("Debe ingresar un numero de telefono valido.", "Crear Proveedor", MessageBoxButtons.OK);
                                                        }
                                                    
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese SitioWeb.", "Crear Proveedor", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese Descripcion.", "Crear Proveedor", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese Telefono.", "Crear Proveedor", MessageBoxButtons.OK);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese Rubro.", "Crear Proveedor", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Correo.", "Crear Proveedor", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Apellido Materno.", "Crear Proveedor", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Apellido Paterno.", "Crear Proveedor", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre.", "Crear Proveedor", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Contrasena.", "Crear Proveedor", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Ingrese Usuario.", "Crear Proveedor", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
