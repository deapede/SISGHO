using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class AppController
    {
        public void AbrirFormulario(object form, Panel p)
        {
            if (p.Controls.Count > 0)
                p.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            p.Controls.Add(fh);
            p.Tag = fh;
            fh.Show();
        }
    }
}
