using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                String[] pass = user.CONTRASEÑA.Split('$');
                string contrasena = pass[3];
                




                if (contrasena.Equals(this.hash256(user,password)))
                {
                    if (user.TIPOUSUARIO == 1)
                    {
                        AbrirPrincipal(p, user);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No tiene permisos para acceder.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                else
                {
                     MessageBox.Show("Usuario o Contraseña incorrecta." + this.hash256(user, password), "Advertencia", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema al ingresar." + e.Message, "Advertencia", MessageBoxButtons.OK);
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

        public string hash256(USUARIO user, string password)
        {
            

            String[] pass = user.CONTRASEÑA.Split('$');
            int iter = int.Parse(pass[1]);
            string salt = pass[2];
            
            PBKDF2 hash = new PBKDF2(password, Encoding.ASCII.GetBytes(salt), iter);
                

            return Convert.ToBase64String(hash.GetBytes(32));
        }
        


        }
}
