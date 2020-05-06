using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class EmpleadoController
    {

        public List<EMPLEADO> ListadoEmpleado()
        {
            ServiceEmpleado se = new ServiceEmpleado();
            return se.getEntities();
        }

        public void LlenarGridEmp(DataGridView dge)
        {
            dge.Rows.Clear();
            dge.Columns.Clear();

            //columna empleado
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "usuario";

            //columna usuario empleado
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "USUARIO";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "NOMBRE";
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "APELLIDO PATERNO";
            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "APELLIDO MATERNO";
            DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            columna7.HeaderText = "CORREO";


            dge.Columns.Add(columna1);
            dge.Columns.Add(columna2);
            dge.Columns.Add(columna3);
            dge.Columns.Add(columna4);
            dge.Columns.Add(columna5);
            dge.Columns.Add(columna6);
            dge.Columns.Add(columna7);


            foreach (EMPLEADO empleado in ListadoEmpleado())
            {

                dge.Rows.Add(empleado.IDEMPLEADO, empleado.USUARIO,empleado.USUARIO1.USUARIO1,empleado.USUARIO1.NOMBRE,empleado.USUARIO1.APELLIDO_PATERNO,empleado.USUARIO1.APELLIDO_MATERNO,empleado.USUARIO1.CORREO);
            }

            dge.ReadOnly = true;
        }



        public void AgregarEmpleado(string usuario, string contraseña, string nombre, string apellidop, string apellidom, string correo)
        {
            ServiceEmpleado sc = new ServiceEmpleado();
            ServiceUsuario su = new ServiceUsuario();
            if (!this.BuscarUsuario(usuario))
            {
                USUARIO user = new USUARIO();
                user.IDUSUARIO = su.id();
                user.TIPOUSUARIO = 2;
                user.USUARIO1 = usuario;
                user.CONTRASEÑA = contraseña;
                user.NOMBRE = nombre;
                user.APELLIDO_PATERNO = apellidop;
                user.APELLIDO_MATERNO = apellidom;
                user.CORREO = correo;
                su.addEntity(user);

                EMPLEADO empleado = new EMPLEADO();
                empleado.IDEMPLEADO = su.id();
                empleado.USUARIO= su.getEntity(usuario).IDUSUARIO;
                sc.addEntity(empleado);
                MessageBox.Show("Empleado Creado.", "Crear Empleado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El empleado ya existe.", "Crear Empleado", MessageBoxButtons.OK);
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

        public void ModificarEmpleado(string usuario, string contraseña, string nombre, string apellidop,string apellidom, string correo)
        {
            ServiceEmpleado se = new ServiceEmpleado();
            ServiceUsuario su = new ServiceUsuario();
            //Crear usuario
            USUARIO user = new USUARIO();
            user.IDUSUARIO = su.id();
            user.TIPOUSUARIO = 2;
            user.USUARIO1 = usuario;
            user.CONTRASEÑA = contraseña;
            user.NOMBRE = nombre;
            user.APELLIDO_PATERNO = apellidop;
            user.APELLIDO_MATERNO = apellidom;
            user.CORREO = correo;
            su.updEntity(user);

            EMPLEADO empleado = new EMPLEADO();
            empleado.IDEMPLEADO = su.id();
            empleado.USUARIO = su.getEntity(usuario).IDUSUARIO;
            se.addEntity(empleado);
            MessageBox.Show("Empleado Modificado", "Modificar Empleado", MessageBoxButtons.OK);
        }

        public void LlenarCamposEmp(int idEmpleado, TextBox usuario, TextBox contraseña, TextBox nombre, TextBox apellidop, TextBox apellidom, TextBox correo)
        {
            ServiceEmpleado se = new ServiceEmpleado();
            ServiceUsuario su = new ServiceUsuario();

            EMPLEADO empleado = se.getEntity(idEmpleado);
            USUARIO user = su.getEntity(empleado.USUARIO1.USUARIO1);

            usuario.Text = user.USUARIO1.ToString();
            contraseña.Text = user.CONTRASEÑA;
            nombre.Text = user.NOMBRE;
            apellidop.Text = user.APELLIDO_PATERNO;
            apellidom.Text = user.APELLIDO_MATERNO;
            correo.Text = user.CORREO;
        }

        public void EliminarEmpleado(int id)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceEmpleado se = new ServiceEmpleado();

            EMPLEADO emp = se.getEntity(id);
            USUARIO user = su.getEntity(emp.USUARIO1.USUARIO1);
            se.delEntity(emp.IDEMPLEADO);
            su.delEntity(user.USUARIO1);
        }
    }
}
