namespace EDDemo.Recursividad
{
    partial class frmHanoi
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
            this.lblDIscos = new System.Windows.Forms.Label();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDIscos
            // 
            this.lblDIscos.AutoSize = true;
            this.lblDIscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIscos.Location = new System.Drawing.Point(13, 94);
            this.lblDIscos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDIscos.Name = "lblDIscos";
            this.lblDIscos.Size = new System.Drawing.Size(176, 22);
            this.lblDIscos.TabIndex = 1;
            this.lblDIscos.Text = "Numero de discos:";
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.ItemHeight = 20;
            this.lstMovimientos.Location = new System.Drawing.Point(259, 78);
            this.lstMovimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(343, 264);
            this.lstMovimientos.TabIndex = 5;
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(28, 169);
            this.txtDiscos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(148, 26);
            this.txtDiscos.TabIndex = 6;
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(45, 249);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(112, 35);
            this.btnResolver.TabIndex = 7;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 325);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(408, 370);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(0, 20);
            this.lblOperaciones.TabIndex = 9;
            // 
            // frmHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.lblDIscos);
            this.Name = "frmHanoi";
            this.Text = "frmHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDIscos;
        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.TextBox txtDiscos;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblOperaciones;
    }
}