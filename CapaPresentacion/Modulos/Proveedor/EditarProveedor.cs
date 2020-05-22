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
    public partial class EditarProveedor : Form
    {
        public EditarProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                                                        if (cc.ModificarProv(txtUsuario.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCorreo.Text, int.Parse(labelID.Text), txtRubro.Text, int.Parse(txtTelefono.Text), txtDesc.Text, txtSitio.Text))
                                                        {
                                                            cc.LlenarGrid(App.fp.dataProv);
                                                            this.Dispose();
                                                        }
                                                        
                                                        
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Debe ingresar un numero de telefono valido.", "Modificar Proveedor", MessageBoxButtons.OK);
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese SitioWeb.", "Modificar Proveedor", MessageBoxButtons.OK);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese Descripcion.", "Modificar Proveedor", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese Telefono.", "Modificar Proveedor", MessageBoxButtons.OK);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese Rubro.", "Modificar Proveedor", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese Correo.", "Modificar Proveedor", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Apellido Materno.", "Modificar Proveedor", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Apellido Paterno.", "Modificar Proveedor", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre.", "Modificar Proveedor", MessageBoxButtons.OK);
                    }
               

            }
            else
            {
                MessageBox.Show("Ingrese Usuario.", "Modificar Proveedor", MessageBoxButtons.OK);
            }
        }
    }
}
