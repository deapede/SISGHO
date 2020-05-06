using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    class ProveedorController
    {
        public List<PROVEEDOR> ListadoProveedor()
        {
            ServiceProveedor sp = new ServiceProveedor();
            return sp.getEntities();
        }

        public void LlenarGridProv(DataGridView dt)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            //columnas proveedor
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Telefono";
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Descripcion";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Sitio Web";
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Tipo Usuario";
            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "Usuario";
           

            //se agregan columnas al datagrid
            dt.Columns.Add(columna1);
            dt.Columns.Add(columna2);
            dt.Columns.Add(columna3);
            dt.Columns.Add(columna4);
            dt.Columns.Add(columna5);
            dt.Columns.Add(columna6);

            foreach(PROVEEDOR proveedor in ListadoProveedor())
            {
                dt.Rows.Add(proveedor.IDPROVEEDOR, proveedor.TELEFONO, proveedor.DESCRIPCION, proveedor.SITIOWEB, proveedor.USUARIO, proveedor.USUARIO1);
            }

            dt.ReadOnly = true;
        }

        public void AgregarProveedor(int idprov, string rubro, int telefono, string descripcion, string sitioweb, string usuario)
        {
            ServiceProveedor sp = new ServiceProveedor();
            ServiceUsuario su = new ServiceUsuario();
            if (!this.BuscarUsuario(usuario))
            {
                USUARIO user = new USUARIO();
                user.IDUSUARIO = su.id();
                su.addEntity(user);

                PROVEEDOR proveedor = new PROVEEDOR();
                proveedor.IDPROVEEDOR = sp.id();
                proveedor.RUBRO = rubro;
                proveedor.TELEFONO = telefono;
                proveedor.DESCRIPCION = descripcion;
                proveedor.SITIOWEB = sitioweb;
                proveedor.USUARIO = su.getEntity(usuario).IDUSUARIO;
                sp.addEntity(proveedor);
                MessageBox.Show("Proveedor Creado", "Crear Proveedor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("El proveedor ya existe","Crear Proveedor",MessageBoxButtons.OK);
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

        public void ModificarProveedor(int idprov, string rubro, int telefono, string descripcion, string sitioweb, int usuario)
        {
            ServiceUsuario su = new ServiceUsuario();
            ServiceProveedor sp = new ServiceProveedor();

            USUARIO user = new USUARIO();
            user.IDUSUARIO = usuario;

            PROVEEDOR proveedor = new PROVEEDOR();
            proveedor.IDPROVEEDOR = idprov;
            proveedor.RUBRO = rubro;
            proveedor.TELEFONO = telefono;
            proveedor.DESCRIPCION = descripcion;
            proveedor.SITIOWEB = sitioweb;
            sp.updEntity(proveedor);
            MessageBox.Show("Proveedor Modificado","Modicar Proveedor", MessageBoxButtons.OK);

            

        }
    }
}
