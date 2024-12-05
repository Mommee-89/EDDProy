
namespace EDDemo
{
    partial class frmPilas
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnPop = new System.Windows.Forms.Button();
            this.BtnPush = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(191, 189);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 36);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnPop
            // 
            this.BtnPop.Location = new System.Drawing.Point(102, 241);
            this.BtnPop.Name = "BtnPop";
            this.BtnPop.Size = new System.Drawing.Size(81, 36);
            this.BtnPop.TabIndex = 4;
            this.BtnPop.Text = "Pop";
            this.BtnPop.UseVisualStyleBackColor = true;
            this.BtnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // BtnPush
            // 
            this.BtnPush.Location = new System.Drawing.Point(102, 132);
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.Size = new System.Drawing.Size(85, 37);
            this.BtnPush.TabIndex = 5;
            this.BtnPush.Text = "Push";
            this.BtnPush.UseVisualStyleBackColor = true;
            this.BtnPush.Click += new System.EventHandler(this.BtnPush_Click_1);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 20;
            this.lstPila.Location = new System.Drawing.Point(297, 169);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(224, 84);
            this.lstPila.TabIndex = 6;
            this.lstPila.SelectedIndexChanged += new System.EventHandler(this.lstPila_SelectedIndexChanged);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(102, 62);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 26);
            this.txtDato.TabIndex = 7;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dato:";
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.BtnPush);
            this.Controls.Add(this.BtnPop);
            this.Controls.Add(this.BtnMostrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnPop;
        private System.Windows.Forms.Button BtnPush;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
    }
}