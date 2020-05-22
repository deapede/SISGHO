using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ServicioController
    {

        public List<SERVICIOCOMEDOR> ListadoServicios()
        {
            ServiceServicioComedor ssc = new ServiceServicioComedor();
            return ssc.getEntities();
        }

        public void LlenarGrid(DataGridView dt)
        {
            ServiceTipoServicio sts = new ServiceTipoServicio();
            String tipo = "";

            dt.Rows.Clear();
            dt.Columns.Clear();

            //columnas cliente
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "PLATO";
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "PRECIO";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "TIPO SERVICIO";



            // Agregamos Columnas al DataGridView
            dt.Columns.Add(columna1);
            dt.Columns.Add(columna2);
            dt.Columns.Add(columna3);
            dt.Columns.Add(columna4);

            foreach (SERVICIOCOMEDOR ts in this.ListadoServicios())
            {
                tipo = sts.getEntity(ts.TIPOSERVICIO1.IDTIPO).DESCRIPCION;
                dt.Rows.Add(ts.IDSERVICIO, ts.PLATO, ts.PRECIO, tipo);
            }



            dt.ReadOnly = true;
        }

        public bool AgregarServicio(string plato, int precio, string tipoServicio)
        {
           
            ServiceServicioComedor ssc = new ServiceServicioComedor();
            ServiceTipoServicio sts = new ServiceTipoServicio();

            try
            {
                // Servicio
                TIPOSERVICIO ts = sts.getEntityDesc(tipoServicio);
                SERVICIOCOMEDOR sc = new SERVICIOCOMEDOR();
                sc.IDSERVICIO = ssc.id();
                sc.PLATO = plato;
                sc.PRECIO = precio;
                sc.TIPOSERVICIO = ts.IDTIPO;
                sc.IDADMINISTRADOR = 1;
                

                if (sc.PRECIO >= 0)
                {
                    ssc.addEntity(sc);
                    MessageBox.Show("Servicio Agregado.", "Agregar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                else
                {
                    MessageBox.Show("El precio debe ser mayor o igual a 0.", "Agregar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                
            }
            catch (Exception ex)
            {
               MessageBox.Show("No se pudo crear el servicio.", "Crear Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        


        }

        public void LlenarCampos(int idServicio, TextBox plato, TextBox precio, ComboBox tipoServicio, Label id)
        {
            ServiceServicioComedor ssc = new ServiceServicioComedor();
            ServiceTipoServicio sts = new ServiceTipoServicio();


            SERVICIOCOMEDOR sc = ssc.getEntity(idServicio);

            this.LlenarComboTipo(tipoServicio);

            plato.Text = sc.PLATO;
            precio.Text = sc.PRECIO.ToString();
            tipoServicio.SelectedIndex = (int)sc.TIPOSERVICIO-1;
            id.Text = sc.IDSERVICIO.ToString();

        }

        public void LlenarComboTipo(ComboBox tipo)
        {
            ServiceTipoServicio sts = new ServiceTipoServicio();
            List<TIPOSERVICIO> lista = sts.getEntities();

            tipo.Items.Clear();
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (TIPOSERVICIO ts in lista)
            {
                tipo.Items.Add(ts.DESCRIPCION);
            }

        }

        public bool ModificarServicio(int id, string plato, int precio, string tiposervicio)
        {
            ServiceServicioComedor ssc = new ServiceServicioComedor();
            ServiceTipoServicio sts = new ServiceTipoServicio();

            
            TIPOSERVICIO ts = sts.getEntityDesc(tiposervicio);
            SERVICIOCOMEDOR sc = new SERVICIOCOMEDOR();

            sc.IDSERVICIO = id;
            sc.PLATO = plato;
            sc.PRECIO = precio;
            sc.TIPOSERVICIO = ts.IDTIPO;

            if(sc.PRECIO >= 0)
            {
                ssc.updEntity(sc);
                MessageBox.Show("Servicio Modificado.", "Modificar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("El precio debe ser mayor o igual a 0.", "Agregar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            

        }


        public void EliminarServicio(int id)
        {
           ServiceServicioComedor ssc = new ServiceServicioComedor();

            
            SERVICIOCOMEDOR sc = ssc.getEntity(id);

            if (MessageBox.Show("Esta seguro de que desea eliminar el servicio: " + sc.PLATO + "?", "Eliminar Servicio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ssc.delEntity(sc.IDSERVICIO);
                MessageBox.Show("Servicio Eliminado", "Eliminar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            
        }









    }
}
