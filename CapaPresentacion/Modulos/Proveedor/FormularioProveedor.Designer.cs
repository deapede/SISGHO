namespace CapaPresentacion.Modulos.Proveedor
{
    partial class FormularioProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkProv = new System.Windows.Forms.LinkLabel();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.btnAgregarProv = new System.Windows.Forms.Button();
            this.dataEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // linkProv
            // 
            this.linkProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkProv.AutoSize = true;
            this.linkProv.LinkColor = System.Drawing.Color.White;
            this.linkProv.Location = new System.Drawing.Point(751, 484);
            this.linkProv.Name = "linkProv";
            this.linkProv.Size = new System.Drawing.Size(93, 13);
            this.linkProv.TabIndex = 16;
            this.linkProv.TabStop = true;
            this.linkProv.Text = "¿Necesita ayuda?";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(12, 25);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(132, 23);
            this.labelProveedor.TabIndex = 15;
            this.labelProveedor.Text = "Proveedores";
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProv.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProv.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProv.Location = new System.Drawing.Point(208, 411);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(92, 48);
            this.btnEliminarProv.TabIndex = 14;
            this.btnEliminarProv.Text = "Eliminar Proveedor";
            this.btnEliminarProv.UseVisualStyleBackColor = true;
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProv.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProv.ForeColor = System.Drawing.Color.White;
            this.btnModificarProv.Location = new System.Drawing.Point(110, 411);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(92, 48);
            this.btnModificarProv.TabIndex = 13;
            this.btnModificarProv.Text = "Modificar Proveedor";
            this.btnModificarProv.UseVisualStyleBackColor = true;
            this.btnModificarProv.Click += new System.EventHandler(this.btnModificarProv_Click);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProv.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProv.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProv.Location = new System.Drawing.Point(12, 411);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(92, 48);
            this.btnAgregarProv.TabIndex = 12;
            this.btnAgregarProv.Text = "Agregar Proveedor";
            this.btnAgregarProv.UseVisualStyleBackColor = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // dataEmpleado
            // 
            this.dataEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleado.Location = new System.Drawing.Point(12, 74);
            this.dataEmpleado.Name = "dataEmpleado";
            this.dataEmpleado.Size = new System.Drawing.Size(832, 304);
            this.dataEmpleado.TabIndex = 11;
            // 
            // FormularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(856, 506);
            this.Controls.Add(this.linkProv);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.btnModificarProv);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.dataEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioProveedor";
            this.Text = "FormularioProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkProv;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.DataGridView dataEmpleado;
    }
}