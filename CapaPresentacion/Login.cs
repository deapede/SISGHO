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
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class formLogin : Form
    {
        LoginController lc = new LoginController();
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
            if(textUser.Text == "Usuario")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;

            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Usuario";
                textUser.ForeColor = Color.DarkGray;
            }
        }


        //Textbox Contraseña
        private void textContrasena_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Contraseña")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.LightGray;
                textPass.UseSystemPasswordChar = true;

            }
        }

        private void textContrasena_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Contraseña";
                textPass.ForeColor = Color.DarkGray;
                textPass.UseSystemPasswordChar = false;
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            App p = new App();
            if(lc.Logear(textUser.Text, textPass.Text, p))
            {
                p.lblUser.Text = lc.ObtenerUsuario(textUser.Text);
                this.Hide();

            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }//Fin Form

}//Fin Clase


