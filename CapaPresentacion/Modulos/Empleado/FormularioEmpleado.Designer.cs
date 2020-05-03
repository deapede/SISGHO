namespace CapaPresentacion.Modulos.Empleado
{
    partial class FormularioEmpleado
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
            this.dataEmpleado = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmp = new System.Windows.Forms.Button();
            this.btnModificarEmp = new System.Windows.Forms.Button();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.linkEmpleado = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
            this.SuspendLayout();
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
            this.dataEmpleado.TabIndex = 0;
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmp.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmp.Location = new System.Drawing.Point(208, 411);
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Size = new System.Drawing.Size(92, 48);
            this.btnEliminarEmp.TabIndex = 6;
            this.btnEliminarEmp.Text = "Eliminar Empleado";
            this.btnEliminarEmp.UseVisualStyleBackColor = true;
            // 
            // btnModificarEmp
            // 
            this.btnModificarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmp.ForeColor = System.Drawing.Color.White;
            this.btnModificarEmp.Location = new System.Drawing.Point(110, 411);
            this.btnModificarEmp.Name = "btnModificarEmp";
            this.btnModificarEmp.Size = new System.Drawing.Size(92, 48);
            this.btnModificarEmp.TabIndex = 5;
            this.btnModificarEmp.Text = "Modificar Empleado";
            this.btnModificarEmp.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmp.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmp.Location = new System.Drawing.Point(12, 411);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(92, 48);
            this.btnAgregarEmp.TabIndex = 4;
            this.btnAgregarEmp.Text = "Agregar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleados.ForeColor = System.Drawing.Color.White;
            this.labelEmpleados.Location = new System.Drawing.Point(12, 25);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(119, 23);
            this.labelEmpleados.TabIndex = 7;
            this.labelEmpleados.Text = "Empleados";
            // 
            // linkEmpleado
            // 
            this.linkEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEmpleado.AutoSize = true;
            this.linkEmpleado.LinkColor = System.Drawing.Color.White;
            this.linkEmpleado.Location = new System.Drawing.Point(751, 484);
            this.linkEmpleado.Name = "linkEmpleado";
            this.linkEmpleado.Size = new System.Drawing.Size(93, 13);
            this.linkEmpleado.TabIndex = 10;
            this.linkEmpleado.TabStop = true;
            this.linkEmpleado.Text = "¿Necesita ayuda?";
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(856, 506);
            this.Controls.Add(this.linkEmpleado);
            this.Controls.Add(this.labelEmpleados);
            this.Controls.Add(this.btnEliminarEmp);
            this.Controls.Add(this.btnModificarEmp);
            this.Controls.Add(this.btnAgregarEmp);
            this.Controls.Add(this.dataEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioEmpleado";
            this.Text = "FormularioEmpleado";
            this.Load += new System.EventHandler(this.FormularioEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmpleado;
        private System.Windows.Forms.Button btnEliminarEmp;
        private System.Windows.Forms.Button btnModificarEmp;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.Label labelEmpleados;
        private System.Windows.Forms.LinkLabel linkEmpleado;
    }
}