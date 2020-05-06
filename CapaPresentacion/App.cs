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
        public static Modulos.Empleado.FormularioEmpleado fe = new Modulos.Empleado.FormularioEmpleado();
        public static Modulos.Proveedor.FormularioProveedor fp = new Modulos.Proveedor.FormularioProveedor();
        public App()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            
            //Ajuste minimo
            this.MinimumSize = new Size(500, 500);
        }

        private void App_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
        }

        //Botones ventana
        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                
                this.WindowState = FormWindowState.Maximized;      
            
            else if(this.WindowState==FormWindowState.Maximized)
                
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

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ac.AbrirFormulario(fe, panelFormularios);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ac.AbrirFormulario(fp, panelFormularios);
        }
    }//Fin clase
}//FIn namespace
