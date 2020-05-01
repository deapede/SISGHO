using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class LoginController
    {
        ServiceUsuario su = new ServiceUsuario();
        public Boolean Logear(string usuario, string password, Form p)
        {
            USUARIO user = su.getEntity(usuario);
            try
            {
                if (user.CONTRASEÑA.Equals(password))
                {
                    if(user.TIPOUSUARIO == 1)
                    {
                        AbrirPrincipal(p, user);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No tiene permisos para acceder.", "Advertencia", MessageBoxButtons.OK);
                        return false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta.", "Advertencia", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta.", "Advertencia", MessageBoxButtons.OK);
                return false;
            }

        }
        public void AbrirPrincipal(Form Formulario, USUARIO user)
        {
            Formulario.Show();


        }

        public String ObtenerUsuario(string usuario)
        {
            USUARIO user = su.getEntity(usuario);
            return user.NOMBRE + " " + user.APELLIDO_PATERNO + " " + user.APELLIDO_MATERNO;
        }
    }
}
