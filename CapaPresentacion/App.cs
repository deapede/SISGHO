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
    public partial class App : Form
    {
        AppController ac = new AppController();
        public static Modulos.Cliente.FormularioCliente fc = new Modulos.Cliente.FormularioCliente();
        public App()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            //Ajuste minimo
            this.MinimumSize = new Size(500, 500);
        }


        //Botones ventana
        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxApp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        //Arrastre ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ac.AbrirFormulario(fc, panelFormularios);
        }
    }//Fin clase
}//FIn namespace
