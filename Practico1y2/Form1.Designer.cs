namespace Practico3
{
    partial class Form1
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
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(45, 37);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(45, 71);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 1;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(45, 132);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(45, 103);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(176, 37);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(149, 68);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(149, 132);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 6;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(149, 103);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(45, 225);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(176, 225);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LDni);
            Controls.Add(LNya);
            Name = "Form1";
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Button TGuardar;
        private Button TEliminar;
    }
}
