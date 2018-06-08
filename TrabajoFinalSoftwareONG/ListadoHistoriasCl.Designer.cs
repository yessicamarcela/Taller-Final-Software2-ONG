namespace TrabajoFinalSoftwareONG
{
    partial class ListadoHistoriasCl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoHistoriasCl));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.PrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlergiasSufridas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnfermedadesPadecidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimerNombre,
            this.SegundoNombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdTipoDocumento,
            this.NumeroDocumento,
            this.Telefono,
            this.Departamento,
            this.Ciudad,
            this.Direccion,
            this.Analisis,
            this.Revisiones,
            this.AlergiasSufridas,
            this.EnfermedadesPadecidas,
            this.IdMedicamentos});
            this.dgvListado.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvListado.Location = new System.Drawing.Point(-2, 3);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(1286, 386);
            this.dgvListado.TabIndex = 0;
            // 
            // PrimerNombre
            // 
            this.PrimerNombre.DataPropertyName = "PrimerNombre";
            this.PrimerNombre.HeaderText = "Primer Nombre";
            this.PrimerNombre.Name = "PrimerNombre";
            this.PrimerNombre.ReadOnly = true;
            // 
            // SegundoNombre
            // 
            this.SegundoNombre.DataPropertyName = "SegundoNombre";
            this.SegundoNombre.HeaderText = "Segundo Nombre";
            this.SegundoNombre.Name = "SegundoNombre";
            this.SegundoNombre.ReadOnly = true;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            // 
            // IdTipoDocumento
            // 
            this.IdTipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.IdTipoDocumento.HeaderText = "Tipo de Documento";
            this.IdTipoDocumento.Name = "IdTipoDocumento";
            this.IdTipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Numero de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Analisis
            // 
            this.Analisis.DataPropertyName = "Analisis";
            this.Analisis.HeaderText = "Analisis";
            this.Analisis.Name = "Analisis";
            this.Analisis.ReadOnly = true;
            // 
            // Revisiones
            // 
            this.Revisiones.DataPropertyName = "Revisiones";
            this.Revisiones.HeaderText = "Revisiones";
            this.Revisiones.Name = "Revisiones";
            this.Revisiones.ReadOnly = true;
            // 
            // AlergiasSufridas
            // 
            this.AlergiasSufridas.DataPropertyName = "AlergiasSufridas";
            this.AlergiasSufridas.HeaderText = "Alergias Sufridas";
            this.AlergiasSufridas.Name = "AlergiasSufridas";
            this.AlergiasSufridas.ReadOnly = true;
            // 
            // EnfermedadesPadecidas
            // 
            this.EnfermedadesPadecidas.DataPropertyName = "EnfermedadesPadecidas";
            this.EnfermedadesPadecidas.HeaderText = "Enfermedades Padecidas";
            this.EnfermedadesPadecidas.Name = "EnfermedadesPadecidas";
            this.EnfermedadesPadecidas.ReadOnly = true;
            // 
            // IdMedicamentos
            // 
            this.IdMedicamentos.DataPropertyName = "IdMedicamentos";
            this.IdMedicamentos.HeaderText = "Medicamentos Tomados";
            this.IdMedicamentos.Name = "IdMedicamentos";
            this.IdMedicamentos.ReadOnly = true;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Pink;
            this.Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(442, 395);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(78, 46);
            this.Regresar.TabIndex = 1;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // ListadoHistoriasCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1321, 453);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoHistoriasCl";
            this.Text = "ListadoHistoriasCl";
            this.Load += new System.EventHandler(this.ListadoHistoriasCl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlergiasSufridas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnfermedadesPadecidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicamentos;
        private System.Windows.Forms.Button Regresar;
    }
}