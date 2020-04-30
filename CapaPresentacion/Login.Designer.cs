namespace CapaPresentacion
{
    partial class formLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineContrasena = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineCorreo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkOlvido = new System.Windows.Forms.LinkLabel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(44)))), ((int)(((byte)(251)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(333, 30);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(287, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(309, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineContrasena,
            this.lineCorreo,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(333, 560);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineContrasena
            // 
            this.lineContrasena.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.lineContrasena.BorderWidth = 2;
            this.lineContrasena.Enabled = false;
            this.lineContrasena.Name = "lineContrasena";
            this.lineContrasena.X1 = 43;
            this.lineContrasena.X2 = 271;
            this.lineContrasena.Y1 = 376;
            this.lineContrasena.Y2 = 376;
            // 
            // lineCorreo
            // 
            this.lineCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.lineCorreo.BorderWidth = 2;
            this.lineCorreo.Enabled = false;
            this.lineCorreo.Name = "lineCorreo";
            this.lineCorreo.X1 = 43;
            this.lineCorreo.X2 = 271;
            this.lineCorreo.Y1 = 297;
            this.lineCorreo.Y2 = 297;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 75;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 23;
            // 
            // textContrasena
            // 
            this.textContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContrasena.ForeColor = System.Drawing.Color.Gray;
            this.textContrasena.Location = new System.Drawing.Point(46, 343);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(231, 19);
            this.textContrasena.TabIndex = 2;
            this.textContrasena.Text = "Contraseña";
            this.textContrasena.Enter += new System.EventHandler(this.textContrasena_Enter);
            this.textContrasena.Leave += new System.EventHandler(this.textContrasena_Leave);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.ForeColor = System.Drawing.Color.Gray;
            this.labelBienvenido.Location = new System.Drawing.Point(82, 50);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(159, 32);
            this.labelBienvenido.TabIndex = 1;
            this.labelBienvenido.Text = "Bienvenido";
            this.labelBienvenido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textCorreo
            // 
            this.textCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.ForeColor = System.Drawing.Color.Gray;
            this.textCorreo.Location = new System.Drawing.Point(47, 269);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(229, 19);
            this.textCorreo.TabIndex = 1;
            this.textCorreo.Text = "Correo";
            this.textCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.textCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(44)))), ((int)(((byte)(251)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(46, 421);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(231, 42);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // linkOlvido
            // 
            this.linkOlvido.AutoSize = true;
            this.linkOlvido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOlvido.ForeColor = System.Drawing.Color.Gray;
            this.linkOlvido.LinkColor = System.Drawing.Color.Gray;
            this.linkOlvido.Location = new System.Drawing.Point(87, 536);
            this.linkOlvido.Name = "linkOlvido";
            this.linkOlvido.Size = new System.Drawing.Size(149, 17);
            this.linkOlvido.TabIndex = 0;
            this.linkOlvido.TabStop = true;
            this.linkOlvido.Text = "¿Olvidó su Contraseña?";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::CapaPresentacion.Properties.Resources.sisghologo;
            this.pictureLogo.Location = new System.Drawing.Point(117, 85);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(89, 93);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(44)))), ((int)(((byte)(251)))));
            this.labelLogo.Location = new System.Drawing.Point(104, 193);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(115, 32);
            this.labelLogo.TabIndex = 8;
            this.labelLogo.Text = "SISGHO";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 560);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.linkOlvido);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogin_MouseDown);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineContrasena;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCorreo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkOlvido;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelLogo;
    }
}

