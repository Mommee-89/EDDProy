
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btPodar = new System.Windows.Forms.Button();
            this.btEliminarPredecesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminarSucesor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btRecorridoNiveles = new System.Windows.Forms.Button();
            this.lblRecorridoPorNiveles = new System.Windows.Forms.Label();
            this.btAltura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btContarHojas = new System.Windows.Forms.Button();
            this.btContarNodos = new System.Windows.Forms.Button();
            this.btEsCompleto = new System.Windows.Forms.Button();
            this.btEsLleno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(64, 24);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(76, 38);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(9, 305);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(840, 462);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(635, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 37);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(635, 53);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(93, 37);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(155, 130);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(93, 50);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(9, 33);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(52, 20);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(155, 74);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(93, 52);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(61, 82);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(90, 32);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(263, 182);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(89, 20);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(358, 182);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(85, 20);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(280, 146);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(71, 20);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(268, 106);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(81, 20);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(358, 146);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(85, 20);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(358, 106);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(85, 20);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(267, 26);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(101, 36);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "Buscar :";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btPodar
            // 
            this.btPodar.Location = new System.Drawing.Point(743, 11);
            this.btPodar.Name = "btPodar";
            this.btPodar.Size = new System.Drawing.Size(93, 35);
            this.btPodar.TabIndex = 18;
            this.btPodar.Text = "Podar";
            this.btPodar.UseVisualStyleBackColor = true;
            this.btPodar.Click += new System.EventHandler(this.btPodar_Click);
            // 
            // btEliminarPredecesor
            // 
            this.btEliminarPredecesor.Location = new System.Drawing.Point(155, 194);
            this.btEliminarPredecesor.Name = "btEliminarPredecesor";
            this.btEliminarPredecesor.Size = new System.Drawing.Size(93, 30);
            this.btEliminarPredecesor.TabIndex = 19;
            this.btEliminarPredecesor.Text = "Eliminar";
            this.btEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btEliminarPredecesor.Click += new System.EventHandler(this.btEliminarPredecesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Predecesor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btEliminarSucesor
            // 
            this.btEliminarSucesor.Location = new System.Drawing.Point(155, 242);
            this.btEliminarSucesor.Name = "btEliminarSucesor";
            this.btEliminarSucesor.Size = new System.Drawing.Size(93, 29);
            this.btEliminarSucesor.TabIndex = 21;
            this.btEliminarSucesor.Text = "Eliminar";
            this.btEliminarSucesor.UseVisualStyleBackColor = true;
            this.btEliminarSucesor.Click += new System.EventHandler(this.btEliminarSucesor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sucesor";
            // 
            // btRecorridoNiveles
            // 
            this.btRecorridoNiveles.Location = new System.Drawing.Point(267, 211);
            this.btRecorridoNiveles.Name = "btRecorridoNiveles";
            this.btRecorridoNiveles.Size = new System.Drawing.Size(96, 60);
            this.btRecorridoNiveles.TabIndex = 23;
            this.btRecorridoNiveles.Text = "RecorridoNiveles";
            this.btRecorridoNiveles.UseVisualStyleBackColor = true;
            this.btRecorridoNiveles.Click += new System.EventHandler(this.btRecorridoNiveles_Click);
            // 
            // lblRecorridoPorNiveles
            // 
            this.lblRecorridoPorNiveles.AutoSize = true;
            this.lblRecorridoPorNiveles.Location = new System.Drawing.Point(384, 231);
            this.lblRecorridoPorNiveles.Name = "lblRecorridoPorNiveles";
            this.lblRecorridoPorNiveles.Size = new System.Drawing.Size(78, 20);
            this.lblRecorridoPorNiveles.TabIndex = 24;
            this.lblRecorridoPorNiveles.Text = "Recorrido";
            // 
            // btAltura
            // 
            this.btAltura.Location = new System.Drawing.Point(743, 59);
            this.btAltura.Name = "btAltura";
            this.btAltura.Size = new System.Drawing.Size(93, 31);
            this.btAltura.TabIndex = 25;
            this.btAltura.Text = "Altura";
            this.btAltura.UseVisualStyleBackColor = true;
            this.btAltura.Click += new System.EventHandler(this.btAltura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contar :";
            // 
            // btContarHojas
            // 
            this.btContarHojas.Location = new System.Drawing.Point(743, 117);
            this.btContarHojas.Name = "btContarHojas";
            this.btContarHojas.Size = new System.Drawing.Size(92, 37);
            this.btContarHojas.TabIndex = 27;
            this.btContarHojas.Text = "Hojas";
            this.btContarHojas.UseVisualStyleBackColor = true;
            this.btContarHojas.Click += new System.EventHandler(this.btContarHojas_Click);
            // 
            // btContarNodos
            // 
            this.btContarNodos.Location = new System.Drawing.Point(743, 160);
            this.btContarNodos.Name = "btContarNodos";
            this.btContarNodos.Size = new System.Drawing.Size(92, 33);
            this.btContarNodos.TabIndex = 28;
            this.btContarNodos.Text = "Nodos";
            this.btContarNodos.UseVisualStyleBackColor = true;
            this.btContarNodos.Click += new System.EventHandler(this.btContarNodos_Click);
            // 
            // btEsCompleto
            // 
            this.btEsCompleto.Location = new System.Drawing.Point(743, 213);
            this.btEsCompleto.Name = "btEsCompleto";
            this.btEsCompleto.Size = new System.Drawing.Size(88, 38);
            this.btEsCompleto.TabIndex = 29;
            this.btEsCompleto.Text = "Completo";
            this.btEsCompleto.UseVisualStyleBackColor = true;
            this.btEsCompleto.Click += new System.EventHandler(this.btEsCompleto_Click);
            // 
            // btEsLleno
            // 
            this.btEsLleno.Location = new System.Drawing.Point(743, 257);
            this.btEsLleno.Name = "btEsLleno";
            this.btEsLleno.Size = new System.Drawing.Size(88, 31);
            this.btEsLleno.TabIndex = 30;
            this.btEsLleno.Text = "Lleno";
            this.btEsLleno.UseVisualStyleBackColor = true;
            this.btEsLleno.Click += new System.EventHandler(this.btEsLleno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Arbol :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 775);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btEsLleno);
            this.Controls.Add(this.btEsCompleto);
            this.Controls.Add(this.btContarNodos);
            this.Controls.Add(this.btContarHojas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAltura);
            this.Controls.Add(this.lblRecorridoPorNiveles);
            this.Controls.Add(this.btRecorridoNiveles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEliminarSucesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminarPredecesor);
            this.Controls.Add(this.btPodar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btPodar;
        private System.Windows.Forms.Button btEliminarPredecesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminarSucesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRecorridoNiveles;
        private System.Windows.Forms.Label lblRecorridoPorNiveles;
        private System.Windows.Forms.Button btAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btContarHojas;
        private System.Windows.Forms.Button btContarNodos;
        private System.Windows.Forms.Button btEsCompleto;
        private System.Windows.Forms.Button btEsLleno;
        private System.Windows.Forms.Label label4;
    }
}