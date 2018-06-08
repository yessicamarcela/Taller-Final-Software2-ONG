namespace TrabajoFinalSoftwareONG
{
    partial class historiaCl
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiaCl));
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtNDocumento = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxMedicamentos = new System.Windows.Forms.ComboBox();
            this.txtEnfermedades = new System.Windows.Forms.TextBox();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.txtRevisiones = new System.Windows.Forms.TextBox();
            this.txtAnalisis = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.grpPaciente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPaciente
            // 
            this.grpPaciente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpPaciente.Controls.Add(this.txtDireccion);
            this.grpPaciente.Controls.Add(this.txtTelefono);
            this.grpPaciente.Controls.Add(this.txtApellido);
            this.grpPaciente.Controls.Add(this.txtNombre);
            this.grpPaciente.Controls.Add(this.txtSegundoNombre);
            this.grpPaciente.Controls.Add(this.txtSegundoApellido);
            this.grpPaciente.Controls.Add(this.txtNDocumento);
            this.grpPaciente.Controls.Add(this.txtDepartamento);
            this.grpPaciente.Controls.Add(this.txtCiudad);
            this.grpPaciente.Controls.Add(this.cbxTipoDocumento);
            this.grpPaciente.Controls.Add(this.label10);
            this.grpPaciente.Controls.Add(this.l);
            this.grpPaciente.Controls.Add(this.label8);
            this.grpPaciente.Controls.Add(this.label7);
            this.grpPaciente.Controls.Add(this.label6);
            this.grpPaciente.Controls.Add(this.label5);
            this.grpPaciente.Controls.Add(this.label4);
            this.grpPaciente.Controls.Add(this.label3);
            this.grpPaciente.Controls.Add(this.label2);
            this.grpPaciente.Controls.Add(this.label1);
            this.grpPaciente.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaciente.Location = new System.Drawing.Point(12, 12);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(744, 254);
            this.grpPaciente.TabIndex = 0;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Datos del Paciente";
            this.grpPaciente.Enter += new System.EventHandler(this.grpPaciente_Enter);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(234, 216);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 32);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(234, 174);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 32);
            this.txtTelefono.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(234, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 32);
            this.txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 32);
            this.txtNombre.TabIndex = 16;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(555, 45);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(100, 32);
            this.txtSegundoNombre.TabIndex = 15;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(555, 83);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(100, 32);
            this.txtSegundoApellido.TabIndex = 14;
            // 
            // txtNDocumento
            // 
            this.txtNDocumento.Location = new System.Drawing.Point(555, 130);
            this.txtNDocumento.Name = "txtNDocumento";
            this.txtNDocumento.Size = new System.Drawing.Size(100, 32);
            this.txtNDocumento.TabIndex = 13;
           
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(555, 174);
            this.txtDepartamento.MaxLength = 20;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 32);
            this.txtDepartamento.TabIndex = 3;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(555, 216);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 32);
            this.txtCiudad.TabIndex = 11;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Items.AddRange(new object[] {
            "Registro Civil",
            "Tarjeta de Identidad",
            "Cedula de Ciudadania",
            "Cedula de Extranjería"});
            this.cbxTipoDocumento.Location = new System.Drawing.Point(194, 130);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(210, 33);
            this.cbxTipoDocumento.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ciudad";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(404, 185);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(122, 25);
            this.l.TabIndex = 8;
            this.l.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Gold;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(476, 419);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 41);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRegistrar.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(381, 421);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 41);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.cbxMedicamentos);
            this.groupBox2.Controls.Add(this.txtEnfermedades);
            this.groupBox2.Controls.Add(this.txtAlergias);
            this.groupBox2.Controls.Add(this.txtRevisiones);
            this.groupBox2.Controls.Add(this.txtAnalisis);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 133);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // cbxMedicamentos
            // 
            this.cbxMedicamentos.FormattingEnabled = true;
            this.cbxMedicamentos.Location = new System.Drawing.Point(586, 48);
            this.cbxMedicamentos.Name = "cbxMedicamentos";
            this.cbxMedicamentos.Size = new System.Drawing.Size(121, 28);
            this.cbxMedicamentos.TabIndex = 9;
            // 
            // txtEnfermedades
            // 
            this.txtEnfermedades.Location = new System.Drawing.Point(409, 47);
            this.txtEnfermedades.Multiline = true;
            this.txtEnfermedades.Name = "txtEnfermedades";
            this.txtEnfermedades.Size = new System.Drawing.Size(125, 78);
            this.txtEnfermedades.TabIndex = 8;
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(255, 41);
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(100, 78);
            this.txtAlergias.TabIndex = 7;
            // 
            // txtRevisiones
            // 
            this.txtRevisiones.Location = new System.Drawing.Point(137, 41);
            this.txtRevisiones.Multiline = true;
            this.txtRevisiones.Name = "txtRevisiones";
            this.txtRevisiones.Size = new System.Drawing.Size(100, 78);
            this.txtRevisiones.TabIndex = 6;
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Location = new System.Drawing.Point(6, 41);
            this.txtAnalisis.Multiline = true;
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.Size = new System.Drawing.Size(125, 78);
            this.txtAnalisis.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(382, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Enfermedades Padecidas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "alergias sufridas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(565, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Medicamentos Tomados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Revisiones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Analisis";
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historiaCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(762, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "historiaCl";
            this.Text = "Historia clinica ONG Concordia";
            this.Load += new System.EventHandler(this.historiaCl_Load);
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtNDocumento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxMedicamentos;
        private System.Windows.Forms.TextBox txtEnfermedades;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.TextBox txtRevisiones;
        private System.Windows.Forms.TextBox txtAnalisis;
        private System.Windows.Forms.Button button1;
    }
}

