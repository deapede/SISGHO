using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ProveedorController
    {



        public List<PROVEEDOR> ListadoProv()
        {

            ServiceProveedor sp = new ServiceProveedor();
            return sp.getEntities();
        }

        public void LlenarGrid(DataGridView dt)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            //columnas cliente
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "RUBRO";
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "TELEFONO";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "DESCRIPCION";
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "SITIO WEB";

            //columnas usuario cliente
            DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            columna7.HeaderText = "USUARIO";
            DataGridViewTextBoxColumn columna8 = new DataGridViewTextBoxColumn();
            columna8.HeaderText = "NOMBRE";
            DataGridViewTextBoxColumn columna9 = new DataGridViewTextBoxColumn();
            columna9.HeaderText = "APELLIDO PATERNO";
            DataGridViewTextBoxColumn columna10 = new DataGridViewTextBoxColumn();
            columna10.HeaderText = "APELLIDO MATERNO";
            DataGridViewTextBoxColumn columna11 = new DataGridViewTextBoxColumn();
            columna11.HeaderText = "CORREO";

            // Agregamos Columnas al DataGridView
            dt.Columns.Add(columna1);
            dt.Columns.Add(columna2);
            dt.Columns.Add(columna3);
            dt.Columns.Add(columna4);
            dt.Columns.Add(columna5);
            dt.Columns.Add(columna7);
            dt.Columns.Add(columna8);
            dt.Columns.Add(columna9);
            dt.Columns.Add(columna10);
            dt.Columns.Add(columna11);

            foreach (PROVEEDOR prov in ListadoProv())
            {

                dt.Rows.Add(prov.IDPROVEEDOR, prov.RUBRO, prov.TELEFONO, prov.DESCRIPCION, prov.SITIOWEB, prov.USUARIO1.USUARIO1, prov.USUARIO1.NOMBRE, prov.USUARIO1.APELLIDO_PATERNO, prov.USUARIO1.APELLIDO_MATERNO, prov.USUARIO1.CORREO);
            }



            dt.ReadOnly = true;


        }

        public bool AgregarProv(string usuario, string contraseña, string nombre, string apellidop, string apellidom, string correo, string rubro, int telefono, string descripcion, string sitioweb)
        {
            ServiceProveedor sp = new ServiceProveedor();
            ServiceUsuario su = new ServiceUsuario();
            PasswordController pc = new PasswordController();
            if (!this.BuscarUsuario(usuario))
            {
                // Creamos usuario
                USUARIO user = new USUARIO();
                user.IDUSUARIO = su.id();
                user.TIPOUSUARIO = 4;
                user.USUARIO1 = usuario;
                user.CONTRASEÑA = pc.generarContraseña(contraseña);
                user.NOMBRE = nombre;
                user.APELLIDO_PATERNO = apellidop;
                user.APELLIDO_MATERNO = apellidom;
                user.CORREO = correo;
                su.addEntity(user);

                //Agregamos proveedor
                PROVEEDOR prov = new PROVEEDOR();
                prov.IDPROVEEDOR = sp.id();
                prov.RUBRO = rubro;
                prov.TELEFONO = telefono;
                prov.DESCRIPCION = descripcion;
                prov.SITIOWEB = sitioweb;
                prov.USUARIO = su.getEntity(usuario).IDUSUARIO;

            
                sp.addEntity(prov);
                MessageBox.Show("Proveedor Creado.", "Crear Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("El proveedor ya existe.", "Crear Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        public bool BuscarUsuario(string usuario)
        {
            ServiceUsuario su = new ServiceUsuario();
            USUARIO user = su.getEntity(usuario);

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ModificarProv(string usuario, string nombre, string apellidop, string apellidom, string correo, int id, string rubro, int telefono, string descripcion, string sitioweb)
        {
            try
            {
                ServiceUsuario su = new ServiceUsuario();
                ServiceProveedor sp = new ServiceProveedor();
                // Creamos usuario
                USUARIO user = new USUARIO();
                user.USUARIO1 = usuario;
                user.NOMBRE = nombre;
                user.APELLIDO_PATERNO = apellidop;
                user.APELLIDO_MATERNO = apellidom;
                user.CORREO = correo;
                su.updEntity(user);

                //Agregamos Cliente
                PROVEEDOR prov = new PROVEEDOR();
                prov.IDPROVEEDOR = id;

                prov.RUBRO = rubro;
                prov.TELEFONO = telefono;
                prov.DESCRIPCION = descripcion;
                prov.SITIOWEB = sitioweb;

                sp.updEntity(prov);
                MessageBox.Show("Proveedor  Modificado.", "Modificar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            




        }

        public void LlenarCampos(int idprov, TextBox usuario, TextBox nombre, TextBox apellidop, TextBox apellidom, TextBox correo, TextBox rubro, TextBox telefono, TextBox descrp, TextBox sitioweb, Label id)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceProveedor sp = new ServiceProveedor();

            PROVEEDOR prov = sp.getEntity(idprov);

            USUARIO user = su.getEntity(prov.USUARIO1.USUARIO1);
            usuario.Text = user.USUARIO1;
            nombre.Text = user.NOMBRE;
            apellidop.Text = user.APELLIDO_PATERNO;
            apellidom.Text = user.APELLIDO_MATERNO;
            correo.Text = user.CORREO;
            rubro.Text = prov.RUBRO;
            telefono.Text = prov.TELEFONO.ToString();
            descrp.Text = prov.DESCRIPCION;
            sitioweb.Text = prov.SITIOWEB;            
            id.Text = prov.IDPROVEEDOR.ToString();
        }

        public void EliminarProv(int id)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceProveedor sp = new ServiceProveedor();

            PROVEEDOR prov = sp.getEntity(id);
            USUARIO user = su.getEntity(prov.USUARIO1.USUARIO1);

            if (MessageBox.Show("Esta seguro de que desea eliminar el proveedor: " + user.USUARIO1 + "?", "Eliminar Proveedor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sp.delEntity(prov.IDPROVEEDOR);
                su.delEntity(user.USUARIO1);
                MessageBox.Show("Proveedor Eliminado", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
        }

        public void CambiarPassId(Label id, int iduser)
        {
            id.Text = iduser.ToString();
        }

        public bool ModificarPassword(int id, string password)
        {
            try
            {
                ServiceUsuario su = new ServiceUsuario();
                ServiceProveedor sp = new ServiceProveedor();
                PROVEEDOR prov = sp.getEntity(id);
                PasswordController pc = new PasswordController();

                USUARIO user = new USUARIO();
                user.IDUSUARIO = prov.USUARIO1.IDUSUARIO;
                user.CONTRASEÑA = pc.generarContraseña(password);
                su.updPass(user);

                MessageBox.Show("Contraseña Modificada.", "Modificar Contrasña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Modificar Contrasña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }




        }














    }
}
