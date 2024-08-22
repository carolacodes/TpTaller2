namespace Practico2
{
    partial class Form1
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
            this.lblNyA = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMastercard = new System.Windows.Forms.CheckBox();
            this.cbxVisa = new System.Windows.Forms.CheckBox();
            this.cbxNaranja = new System.Windows.Forms.CheckBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbVaron = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNyA
            // 
            this.lblNyA.AutoSize = true;
            this.lblNyA.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyA.Location = new System.Drawing.Point(11, 17);
            this.lblNyA.Name = "lblNyA";
            this.lblNyA.Size = new System.Drawing.Size(171, 24);
            this.lblNyA.TabIndex = 0;
            this.lblNyA.Text = "Nombre y Apellido";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.LightBlue;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.Color.Red;
            this.lblModificar.Location = new System.Drawing.Point(223, 17);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(92, 24);
            this.lblModificar.TabIndex = 1;
            this.lblModificar.Text = "Modificar";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(20, 101);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(48, 24);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(20, 243);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 24);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtDni.Location = new System.Drawing.Point(124, 103);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(242, 22);
            this.txtDni.TabIndex = 5;
            this.txtDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 172);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(124, 245);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(242, 22);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbxMastercard);
            this.panel1.Controls.Add(this.cbxVisa);
            this.panel1.Controls.Add(this.cbxNaranja);
            this.panel1.Controls.Add(this.lblTarjeta);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblModificar);
            this.panel1.Controls.Add(this.lblNyA);
            this.panel1.Location = new System.Drawing.Point(24, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 506);
            this.panel1.TabIndex = 10;
            // 
            // cbxMastercard
            // 
            this.cbxMastercard.AutoSize = true;
            this.cbxMastercard.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMastercard.Location = new System.Drawing.Point(206, 448);
            this.cbxMastercard.Name = "cbxMastercard";
            this.cbxMastercard.Size = new System.Drawing.Size(116, 23);
            this.cbxMastercard.TabIndex = 15;
            this.cbxMastercard.Text = "Mastercard";
            this.cbxMastercard.UseVisualStyleBackColor = true;
            // 
            // cbxVisa
            // 
            this.cbxVisa.AutoSize = true;
            this.cbxVisa.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVisa.Location = new System.Drawing.Point(206, 421);
            this.cbxVisa.Name = "cbxVisa";
            this.cbxVisa.Size = new System.Drawing.Size(62, 23);
            this.cbxVisa.TabIndex = 14;
            this.cbxVisa.Text = "Visa";
            this.cbxVisa.UseVisualStyleBackColor = true;
            // 
            // cbxNaranja
            // 
            this.cbxNaranja.AutoSize = true;
            this.cbxNaranja.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNaranja.Location = new System.Drawing.Point(206, 394);
            this.cbxNaranja.Name = "cbxNaranja";
            this.cbxNaranja.Size = new System.Drawing.Size(92, 23);
            this.cbxNaranja.TabIndex = 13;
            this.cbxNaranja.Text = "Naranja";
            this.cbxNaranja.UseVisualStyleBackColor = true;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(21, 371);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(166, 24);
            this.lblTarjeta.TabIndex = 12;
            this.lblTarjeta.Text = "Tarjeta de credito:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 312);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(240, 22);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(19, 310);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(91, 24);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono:";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(478, 257);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(75, 23);
            this.rbMujer.TabIndex = 12;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbMujer_CheckedChanged);
            // 
            // rbVaron
            // 
            this.rbVaron.AutoSize = true;
            this.rbVaron.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVaron.Location = new System.Drawing.Point(582, 257);
            this.rbVaron.Name = "rbVaron";
            this.rbVaron.Size = new System.Drawing.Size(76, 23);
            this.rbVaron.TabIndex = 13;
            this.rbVaron.TabStop = true;
            this.rbVaron.Text = "Varon";
            this.rbVaron.UseVisualStyleBackColor = true;
            this.rbVaron.CheckedChanged += new System.EventHandler(this.rbVaron_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Practico2.Properties.Resources.puerta;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(526, 588);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 57);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Practico2.Properties.Resources.user_7718888;
            this.pbUser.Location = new System.Drawing.Point(478, 68);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(180, 164);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 11;
            this.pbUser.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Practico2.Properties.Resources.carpeta;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(24, 588);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 57);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::Practico2.Properties.Resources.boton;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(308, 588);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 57);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 669);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbVaron);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNyA;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox cbxMastercard;
        private System.Windows.Forms.CheckBox cbxVisa;
        private System.Windows.Forms.CheckBox cbxNaranja;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbVaron;
        private System.Windows.Forms.Button btnSalir;
    }
}

