using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class PasswordController
    {

        public string generarContraseña(string pass)
        {
            string algor = "pbkdf2_sha256";
            int iteraciones = 180000;

            string salt = this.RandomString(12);


            PBKDF2 hash = new PBKDF2(pass, Encoding.ASCII.GetBytes(salt), iteraciones);

            return algor + "$" + iteraciones + "$" + salt + "$" + Convert.ToBase64String(hash.GetBytes(32));

        }

        
        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdfghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }





    }
}
