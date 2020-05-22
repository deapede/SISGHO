﻿using System;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Modulos.Empleado
{
    public partial class FormularioEmpleado : Form
    {
        public FormularioEmpleado()
        {
            InitializeComponent();
        }

        private void FormularioEmpleado_Load(object sender, EventArgs e)
        {
            EmpleadoController ec = new EmpleadoController();
            ec.LlenarGridEmp(dataEmpleado);
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            AgregarEmpleado ae = new AgregarEmpleado();
            ae.Show();
        }

        private void btnModificarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoController ec = new EmpleadoController();
                int id = int.Parse(dataEmpleado.CurrentRow.Cells[0].Value.ToString());
                ModificarEmpleado me = new ModificarEmpleado();
                ec.LlenarCamposEmp(id, me.txtUsuario, me.txtNombre, me.txtApellidoP, me.txtApellidoM, me.txtCorreo);
                    me.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 empleado.", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoController ec = new EmpleadoController();
                int id = int.Parse(dataEmpleado.CurrentRow.Cells[0].Value.ToString());
                ec.EliminarEmpleado(id);
                ec.LlenarGridEmp(App.fe.dataEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 empleado.", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarPass_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoController ec = new EmpleadoController();
                int id = int.Parse(dataEmpleado.CurrentRow.Cells[0].Value.ToString());
                ModificarContraseña mc = new ModificarContraseña();
                ec.CambiarPassId(mc.labelID, id);
                mc.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar 1 empleado.", "Modificar Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
