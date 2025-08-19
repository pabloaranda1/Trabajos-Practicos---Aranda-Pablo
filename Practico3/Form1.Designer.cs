namespace Practico2
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LNya = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LDni = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            LTarjeta = new Panel();
            CMastercard = new CheckBox();
            CVisa = new CheckBox();
            CNaranja = new CheckBox();
            label1 = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            BSalir = new Button();
            LTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(14, 12);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(4, 100);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(3, 148);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(14, 51);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 3;
            LDni.Text = "DNI";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(162, 12);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(70, 51);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.Validated += TDni_Validated;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(70, 97);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.Validated += TApellido_Validated;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(70, 145);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.Validated += TNombre_Validated;
            // 
            // BGuardar
            // 
            BGuardar.Image = Properties.Resources.Captura3;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(12, 349);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(107, 50);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = Properties.Resources.Captura4;
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(156, 349);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(107, 50);
            BEliminar.TabIndex = 10;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // LTarjeta
            // 
            LTarjeta.BackColor = SystemColors.ControlDark;
            LTarjeta.Controls.Add(CMastercard);
            LTarjeta.Controls.Add(CVisa);
            LTarjeta.Controls.Add(CNaranja);
            LTarjeta.Controls.Add(label1);
            LTarjeta.Controls.Add(TTelefono);
            LTarjeta.Controls.Add(LTelefono);
            LTarjeta.Controls.Add(LModificar);
            LTarjeta.Controls.Add(LDni);
            LTarjeta.Controls.Add(LNya);
            LTarjeta.Controls.Add(TDni);
            LTarjeta.Controls.Add(TApellido);
            LTarjeta.Controls.Add(TNombre);
            LTarjeta.Controls.Add(LApellido);
            LTarjeta.Controls.Add(LNombre);
            LTarjeta.Location = new Point(12, 36);
            LTarjeta.Name = "LTarjeta";
            LTarjeta.Size = new Size(251, 303);
            LTarjeta.TabIndex = 11;
            // 
            // CMastercard
            // 
            CMastercard.AutoSize = true;
            CMastercard.Location = new Point(113, 281);
            CMastercard.Name = "CMastercard";
            CMastercard.Size = new Size(85, 19);
            CMastercard.TabIndex = 12;
            CMastercard.Text = "Mastercard";
            CMastercard.UseVisualStyleBackColor = true;
            // 
            // CVisa
            // 
            CVisa.AutoSize = true;
            CVisa.Location = new Point(113, 255);
            CVisa.Name = "CVisa";
            CVisa.Size = new Size(47, 19);
            CVisa.TabIndex = 11;
            CVisa.Text = "Visa";
            CVisa.UseVisualStyleBackColor = true;
            // 
            // CNaranja
            // 
            CNaranja.AutoSize = true;
            CNaranja.Location = new Point(113, 230);
            CNaranja.Name = "CNaranja";
            CNaranja.Size = new Size(67, 19);
            CNaranja.TabIndex = 10;
            CNaranja.Text = "Naranja";
            CNaranja.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 231);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 9;
            label1.Text = "Tarjeta de credito: ";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(70, 189);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 8;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(4, 192);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 4;
            LTelefono.Text = "Telefono";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura1;
            pictureBox1.Location = new Point(313, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 96);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(288, 181);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 14;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(369, 181);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 15;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.Captura5;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(318, 349);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(107, 50);
            BSalir.TabIndex = 16;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 411);
            Controls.Add(BSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(LTarjeta);
            Name = "Form2";
            Text = "Pequeño Formulario";
            LTarjeta.ResumeLayout(false);
            LTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LApellido;
        private Label LNombre;
        private Label LDni;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BGuardar;
        private Button BEliminar;
        private Panel LTarjeta;
        private Label LTelefono;
        private TextBox TTelefono;
        private Label label1;
        private CheckBox CMastercard;
        private CheckBox CVisa;
        private CheckBox CNaranja;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button BSalir;
    }
}
