using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ClienteController
    {
        
        
        
        public List<CLIENTE> ListadoCliente()
        {

            ServiceCliente sc = new ServiceCliente();
            return sc.getEntities();
        }

        public void LlenarGrid(DataGridView dt)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            
            //columnas cliente
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "RUT";
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "NOMBRE EMPRESA";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "RUBRO";
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "DIRECCION";
            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "TELEFONO";

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
            dt.Columns.Add(columna6);
            dt.Columns.Add(columna7);
            dt.Columns.Add(columna8);
            dt.Columns.Add(columna9);
            dt.Columns.Add(columna10);
            dt.Columns.Add(columna11);

            foreach (CLIENTE cliente in ListadoCliente()) {
                
                dt.Rows.Add(cliente.IDCLIENTE, cliente.RUT, cliente.NOMBRE, cliente.RUBRO, cliente.DIRECCION, cliente.TELEFONO, cliente.USUARIO1.USUARIO1, cliente.USUARIO1.NOMBRE, cliente.USUARIO1.APELLIDO_PATERNO, cliente.USUARIO1.APELLIDO_MATERNO, cliente.USUARIO1.CORREO);
            }


            
            dt.ReadOnly = true;
            

        }

        public bool AgregarCliente(string usuario, string contraseña, string nombre, string apellidop, string apellidom, string correo, string rut, string nombreE, string rubro, string direccion, int telefono)
        {
            ServiceCliente sc = new ServiceCliente();
            ServiceUsuario su = new ServiceUsuario();
            PasswordController ps = new PasswordController();
            if (!this.BuscarUsuario(usuario))
            {
                // Creamos usuario
                USUARIO user = new USUARIO();
                user.IDUSUARIO = su.id();
                user.TIPOUSUARIO = 3;
                user.USUARIO1 = usuario;
                user.CONTRASEÑA = ps.generarContraseña(contraseña);
                user.NOMBRE = nombre;
                user.APELLIDO_PATERNO = apellidop;
                user.APELLIDO_MATERNO = apellidom;
                user.CORREO = correo;
                su.addEntity(user);

                //Agregamos Cliente
                CLIENTE cliente = new CLIENTE();
                cliente.IDCLIENTE = sc.id();
                cliente.RUT = rut;
                cliente.NOMBRE = nombreE;
                cliente.RUBRO = rubro;
                cliente.DIRECCION = direccion;
                cliente.TELEFONO = telefono;
                cliente.USUARIO = su.getEntity(usuario).IDUSUARIO;
                sc.addEntity(cliente);
                MessageBox.Show("Cliente Creado.", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("El usuario ya existe.", "Crear Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool ModificarCliente(string usuario, string nombre, string apellidop, string apellidom, string correo, string rut, string nombreE, string rubro, string direccion, int telefono, int id)
        {
            try
            {
                ServiceUsuario su = new ServiceUsuario();
                ServiceCliente sc = new ServiceCliente();
                // Creamos usuario
                USUARIO user = new USUARIO();
                user.USUARIO1 = usuario;
                user.NOMBRE = nombre;
                user.APELLIDO_PATERNO = apellidop;
                user.APELLIDO_MATERNO = apellidom;
                user.CORREO = correo;


                su.updEntity(user);

                //Agregamos Cliente
                CLIENTE cliente = new CLIENTE();
                cliente.IDCLIENTE = id;
                cliente.RUT = rut;
                cliente.NOMBRE = nombreE;
                cliente.RUBRO = rubro;
                cliente.DIRECCION = direccion;
                cliente.TELEFONO = telefono;
                sc.updEntity(cliente);
                MessageBox.Show("Cliente Modificado.", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el cliente.", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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
                ServiceCliente sc = new ServiceCliente();
                CLIENTE cli = sc.getEntity(id);
                PasswordController pc = new PasswordController();

                USUARIO user = new USUARIO();
                user.IDUSUARIO = cli.USUARIO1.IDUSUARIO;
                user.CONTRASEÑA = pc.generarContraseña(password);
                su.updPass(user);

                MessageBox.Show("Contraseña Modificada.", "Modificar Contrasña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            } catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, "Modificar Contrasña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
           }
            



        }




        public void LlenarCampos(int idCliente, TextBox usuario, TextBox nombre, TextBox apellidop, TextBox apellidom, TextBox correo, TextBox rut, TextBox nombreE, TextBox rubro, TextBox direccion, TextBox telefono, TextBox id)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceCliente sc = new ServiceCliente();

            CLIENTE cliente = sc.getEntity(idCliente);
            
            USUARIO user = su.getEntity(cliente.USUARIO1.USUARIO1);
            usuario.Text = user.USUARIO1;
            nombre.Text = user.NOMBRE;
            apellidop.Text = user.APELLIDO_PATERNO;
            apellidom.Text = user.APELLIDO_MATERNO;
            correo.Text = user.CORREO;
            rut.Text = cliente.RUT;
            nombreE.Text = cliente.NOMBRE;
            rubro.Text = cliente.RUBRO;
            direccion.Text = cliente.DIRECCION;
            telefono.Text = cliente.TELEFONO.ToString();
            id.Text = cliente.IDCLIENTE.ToString();
        }

        public void EliminarCliente(int id)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceCliente sc = new ServiceCliente();

            CLIENTE cli = sc.getEntity(id);
            USUARIO user = su.getEntity(cli.USUARIO1.USUARIO1);
            
            if (MessageBox.Show("Esta seguro de que desea eliminar el cliente: "+user.USUARIO1+"?", "Eliminar Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sc.delEntity(cli.IDCLIENTE);
                su.delEntity(user.USUARIO1);
                MessageBox.Show("Cliente Eliminado", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }





    }
}
