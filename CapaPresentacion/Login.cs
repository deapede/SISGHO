using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        //Boton Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //TextBox Correo
        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if(textCorreo.Text == "Correo")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.LightGray;

            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "Correo";
                textCorreo.ForeColor = Color.DarkGray;
            }
        }


        //Textbox Contraseña
        private void textContrasena_Enter(object sender, EventArgs e)
        {
            if (textContrasena.Text == "Contraseña")
            {
                textContrasena.Text = "";
                textContrasena.ForeColor = Color.LightGray;
                textContrasena.UseSystemPasswordChar = true;

            }
        }

        private void textContrasena_Leave(object sender, EventArgs e)
        {
            if (textContrasena.Text == "")
            {
                textContrasena.Text = "Contraseña";
                textContrasena.ForeColor = Color.DarkGray;
                textContrasena.UseSystemPasswordChar = false;
            }
        }


        //Arraste de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

















    }//Fin Form

}//Fin Clase


