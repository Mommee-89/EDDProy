namespace EDDemo.Recursividad
{
    partial class frmBusquedaBinaria
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
            this.btnCargarArreglo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstArreglo = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarArreglo
            // 
            this.btnCargarArreglo.Location = new System.Drawing.Point(397, 63);
            this.btnCargarArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarArreglo.Name = "btnCargarArreglo";
            this.btnCargarArreglo.Size = new System.Drawing.Size(128, 35);
            this.btnCargarArreglo.TabIndex = 7;
            this.btnCargarArreglo.Text = "Cargar arreglo";
            this.btnCargarArreglo.UseVisualStyleBackColor = true;
            this.btnCargarArreglo.Click += new System.EventHandler(this.btnCargarArreglo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(397, 152);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(208, 67);
            this.txtArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(148, 26);
            this.txtArreglo.TabIndex = 9;
            this.txtArreglo.TextChanged += new System.EventHandler(this.txtArreglo_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(208, 151);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(148, 26);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Arreglo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero a buscar:";
            // 
            // lstArreglo
            // 
            this.lstArreglo.FormattingEnabled = true;
            this.lstArreglo.ItemHeight = 20;
            this.lstArreglo.Location = new System.Drawing.Point(66, 237);
            this.lstArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstArreglo.Name = "lstArreglo";
            this.lstArreglo.Size = new System.Drawing.Size(290, 144);
            this.lstArreglo.TabIndex = 13;
            this.lstArreglo.SelectedIndexChanged += new System.EventHandler(this.lstArreglo_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(397, 216);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 35);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(615, 295);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 15;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(636, 258);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(0, 20);
            this.lblOperaciones.TabIndex = 16;
            // 
            // frmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstArreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtArreglo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCargarArreglo);
            this.Name = "frmBusquedaBinaria";
            this.Text = "frmBusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarArreglo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstArreglo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOperaciones;
    }
}