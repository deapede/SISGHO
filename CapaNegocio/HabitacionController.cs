using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class HabitacionController
    {
        public List<HABITACION> ListadoHabitacion()
        {
            ServiceHabitacion sh = new ServiceHabitacion();
            return sh.getEntities();
        }

        public void LlenarGrid(DataGridView dt)
        {
            ServiceEstadoHabitacion seh = new ServiceEstadoHabitacion();
            String estado = "";
            
            dt.Rows.Clear();
            dt.Columns.Clear();

            //columnas cliente
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "id";
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "NUMERO HABITACION";
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "TIPO DE CAMA";
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "ACCESORIOS";
            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "PRECIO";
            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "ESTADO HABITACION";

           

            // Agregamos Columnas al DataGridView
            dt.Columns.Add(columna1);
            dt.Columns.Add(columna2);
            dt.Columns.Add(columna3);
            dt.Columns.Add(columna4);
            dt.Columns.Add(columna5);
            dt.Columns.Add(columna6);

            foreach (HABITACION h in ListadoHabitacion())
            {
                estado = seh.getEntity(h.ESTADOHABITACION).DESCRIPCION;
                dt.Rows.Add(h.IDHABITACION, h.NUMERO, h.TIPO_CAMA, h.ACCESORIOS, h.PRECIO, estado);
            }



            dt.ReadOnly = true;
        }

        public bool AgregarHabitacion(int numero, string tipoCama, string accesorios, int precio)
        {
            ServiceHabitacion sh = new ServiceHabitacion();

            try
            {
                // Habitacion
                HABITACION h = new HABITACION();
                h.IDHABITACION = sh.id();
                h.NUMERO = numero;
                h.TIPO_CAMA = tipoCama;
                h.ACCESORIOS = accesorios;
                h.PRECIO = precio;
                h.IDADMINISTRADOR = 1;
                h.ESTADOHABITACION = 1;

                if (this.BuscarHabitacion((int)h.NUMERO) == false)
                {
                    if((int)h.NUMERO >= 0)
                    {
                        if(h.PRECIO >= 0)
                        {
                            sh.addEntity(h);
                            MessageBox.Show("Habitacion Agregada.", "Agregar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("El precio debe ser mayor o igual a 0.", "Agregar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("La habitacion: " + h.NUMERO + " debe ser mayor o igual a 0.", "Agregar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("La habitacion: "+h.NUMERO+" ya existe.", "Agregar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo crear la habitacion.", "Crear Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            

        }

        public void LlenarCampos(int idHabitacion, TextBox numeroHabitacion, TextBox tipoCama, TextBox precio, ComboBox estadoHabitacion, TextBox accesorios, Label id)
        {
            
            ServiceHabitacion sh = new ServiceHabitacion();
            ServiceEstadoHabitacion seh = new ServiceEstadoHabitacion();

            this.LlenarComboEstado(estadoHabitacion);

            HABITACION h = sh.getEntity(idHabitacion);
            
            numeroHabitacion.Text = h.NUMERO.ToString();
            tipoCama.Text = h.TIPO_CAMA;
            precio.Text = h.PRECIO.ToString();
            accesorios.Text = h.ACCESORIOS;
            id.Text = h.IDHABITACION.ToString();
            estadoHabitacion.SelectedIndex = (int)h.ESTADOHABITACION1.IDESTADO-1;
            
        }

        public void LlenarComboEstado(ComboBox estado)
        {
            ServiceEstadoHabitacion seh = new ServiceEstadoHabitacion();
            List<ESTADOHABITACION> lista = seh.getEntities();
            
            estado.DropDownStyle = ComboBoxStyle.DropDownList;
            estado.Items.Clear();
            foreach (ESTADOHABITACION h in lista)
            {
                estado.Items.Add(h.DESCRIPCION);
            }

            

        }

        public bool ModificarHabitacion(int id, int numero, string tipoCama, int precio, string estado, string accesorios)
        {
            ServiceHabitacion sh = new ServiceHabitacion();
            ServiceEstadoHabitacion seh = new ServiceEstadoHabitacion();

            ESTADOHABITACION eh = seh.getEntityDesc(estado);
            HABITACION h = new HABITACION();
            h.IDHABITACION = id;
            h.NUMERO = numero;
            h.TIPO_CAMA = tipoCama;
            h.PRECIO = precio;
            h.ESTADOHABITACION = eh.IDESTADO;
            h.ACCESORIOS = accesorios;

            if (this.BuscarHabitacion((int)h.NUMERO) == false)
            {
               if(h.NUMERO >= 0)
                {
                    if (h.PRECIO >= 0)
                    {
                        sh.updEntity(h);
                        MessageBox.Show("Habitacion Modificada.", "Modificar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El precio debe ser mayor o igual a 0.", "Modificar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La habitacion: " + h.NUMERO + " debe ser mayor o igual a 0.", "Modificar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("La habitacion: " + h.NUMERO + " ya existe.", "Modificar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
                
            

        }


        public void EliminarHabitacion(int id)
        {
            ServiceHabitacion sh = new ServiceHabitacion();
        
            HABITACION h = sh.getEntity(id);
            

            if (MessageBox.Show("Esta seguro de que desea eliminar la habitacion: " + h.NUMERO + "?", "Eliminar Habitacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sh.delEntity(h.IDHABITACION);
                MessageBox.Show("Habitacion Eliminada", "Eliminar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
        }



        public bool BuscarHabitacion(int numeroHabitacion)
        {
           
            foreach(HABITACION h in this.ListadoHabitacion())
            {
                if((int)h.NUMERO == numeroHabitacion)
                {
                    
                    return true;
                    
                    
                }
            }

            return false;
            
        }











    }
}
