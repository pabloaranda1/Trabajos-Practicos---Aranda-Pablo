namespace Practico_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lstNumeros = new ListBox();
            label1 = new Label();
            label2 = new Label();
            TextDesde = new TextBox();
            TextHasta = new TextBox();
            btnGenerar = new Button();
            label3 = new Label();
            btnPares = new Button();
            btnImpares = new Button();
            btnPrimos = new Button();
            chartNumeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartNumeros).BeginInit();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(348, 93);
            lstNumeros.Margin = new Padding(3, 4, 3, 4);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(205, 404);
            lstNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 109);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 179);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Hasta";
            // 
            // TextDesde
            // 
            TextDesde.Location = new Point(130, 109);
            TextDesde.Margin = new Padding(3, 4, 3, 4);
            TextDesde.Name = "TextDesde";
            TextDesde.Size = new Size(202, 27);
            TextDesde.TabIndex = 3;
            TextDesde.TextChanged += TextDesde_TextChanged;
            // 
            // TextHasta
            // 
            TextHasta.Location = new Point(130, 176);
            TextHasta.Margin = new Padding(3, 4, 3, 4);
            TextHasta.Name = "TextHasta";
            TextHasta.Size = new Size(202, 27);
            TextHasta.TabIndex = 4;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(82, 221);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(174, 36);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar Funcion";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 47);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 6;
            label3.Text = "Lista de Numeros";
            label3.Click += label3_Click;
            // 
            // btnPares
            // 
            btnPares.Location = new Point(82, 333);
            btnPares.Margin = new Padding(3, 4, 3, 4);
            btnPares.Name = "btnPares";
            btnPares.Size = new Size(174, 36);
            btnPares.TabIndex = 7;
            btnPares.Text = "Numeros Pares";
            btnPares.UseVisualStyleBackColor = true;
            btnPares.Click += btnPares_Click_1;
            // 
            // btnImpares
            // 
            btnImpares.Location = new Point(82, 377);
            btnImpares.Margin = new Padding(3, 4, 3, 4);
            btnImpares.Name = "btnImpares";
            btnImpares.Size = new Size(174, 36);
            btnImpares.TabIndex = 8;
            btnImpares.Text = "Numeros Impares";
            btnImpares.UseVisualStyleBackColor = true;
            btnImpares.Click += btnImpares_Click_1;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(82, 421);
            btnPrimos.Margin = new Padding(3, 4, 3, 4);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(174, 36);
            btnPrimos.TabIndex = 9;
            btnPrimos.Text = "Numeros Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            btnPrimos.Click += btnPrimos_Click_1;
            // 
            // chartNumeros
            // 
            chartArea1.Name = "ChartArea1";
            chartNumeros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartNumeros.Legends.Add(legend1);
            chartNumeros.Location = new Point(571, 176);
            chartNumeros.Margin = new Padding(3, 4, 3, 4);
            chartNumeros.Name = "chartNumeros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartNumeros.Series.Add(series1);
            chartNumeros.Size = new Size(331, 255);
            chartNumeros.TabIndex = 10;
            chartNumeros.Text = "chart1";
            chartNumeros.Click += chartNumeros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(chartNumeros);
            Controls.Add(btnPrimos);
            Controls.Add(btnImpares);
            Controls.Add(btnPares);
            Controls.Add(label3);
            Controls.Add(btnGenerar);
            Controls.Add(TextHasta);
            Controls.Add(TextDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNumeros);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartNumeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Label label1;
        private Label label2;
        private TextBox TextDesde;
        private TextBox TextHasta;
        private Button btnGenerar;
        private Label label3;
        private Button btnPares;
        private Button btnImpares;
        private Button btnPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumeros;
    }
}
