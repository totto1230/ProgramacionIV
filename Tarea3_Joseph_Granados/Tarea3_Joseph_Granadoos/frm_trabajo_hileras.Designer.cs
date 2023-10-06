namespace Tarea3_Joseph_Granadoos
{
    partial class frm_trabajo_hileras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_hilera = new System.Windows.Forms.TextBox();
            this.ckb_contenido = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_ver = new System.Windows.Forms.Button();
            this.b_limpiar_hileras = new System.Windows.Forms.Button();
            this.tx_largo = new System.Windows.Forms.TextBox();
            this.tx_vocales = new System.Windows.Forms.TextBox();
            this.tx_no_alfa = new System.Windows.Forms.TextBox();
            this.tx_consonantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ckb_contenido);
            this.groupBox1.Controls.Add(this.tx_hilera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hilera:";
            // 
            // tx_hilera
            // 
            this.tx_hilera.Location = new System.Drawing.Point(62, 28);
            this.tx_hilera.Name = "tx_hilera";
            this.tx_hilera.Size = new System.Drawing.Size(291, 20);
            this.tx_hilera.TabIndex = 1;
            this.tx_hilera.TextChanged += new System.EventHandler(this.tx_hilera_TextChanged);
            // 
            // ckb_contenido
            // 
            this.ckb_contenido.AutoSize = true;
            this.ckb_contenido.Location = new System.Drawing.Point(389, 30);
            this.ckb_contenido.Name = "ckb_contenido";
            this.ckb_contenido.Size = new System.Drawing.Size(112, 17);
            this.ckb_contenido.TabIndex = 2;
            this.ckb_contenido.Text = "Mostrar Contenido";
            this.ckb_contenido.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tx_consonantes);
            this.groupBox2.Controls.Add(this.tx_no_alfa);
            this.groupBox2.Controls.Add(this.tx_vocales);
            this.groupBox2.Controls.Add(this.tx_largo);
            this.groupBox2.Location = new System.Drawing.Point(21, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_limpiar_hileras);
            this.groupBox3.Controls.Add(this.b_ver);
            this.groupBox3.Location = new System.Drawing.Point(389, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(530, 265);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 1;
            this.b_cerrar.Text = "Cerrar";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // b_ver
            // 
            this.b_ver.Location = new System.Drawing.Point(16, 19);
            this.b_ver.Name = "b_ver";
            this.b_ver.Size = new System.Drawing.Size(75, 23);
            this.b_ver.TabIndex = 0;
            this.b_ver.Text = "Ver";
            this.b_ver.UseVisualStyleBackColor = true;
            this.b_ver.Click += new System.EventHandler(this.b_ver_Click);
            // 
            // b_limpiar_hileras
            // 
            this.b_limpiar_hileras.Location = new System.Drawing.Point(16, 48);
            this.b_limpiar_hileras.Name = "b_limpiar_hileras";
            this.b_limpiar_hileras.Size = new System.Drawing.Size(75, 23);
            this.b_limpiar_hileras.TabIndex = 1;
            this.b_limpiar_hileras.Text = "Limpiar";
            this.b_limpiar_hileras.UseVisualStyleBackColor = true;
            this.b_limpiar_hileras.Click += new System.EventHandler(this.b_limpiar_hileras_Click);
            // 
            // tx_largo
            // 
            this.tx_largo.Location = new System.Drawing.Point(228, 22);
            this.tx_largo.Name = "tx_largo";
            this.tx_largo.ReadOnly = true;
            this.tx_largo.Size = new System.Drawing.Size(62, 20);
            this.tx_largo.TabIndex = 0;
            // 
            // tx_vocales
            // 
            this.tx_vocales.Location = new System.Drawing.Point(228, 48);
            this.tx_vocales.Name = "tx_vocales";
            this.tx_vocales.ReadOnly = true;
            this.tx_vocales.Size = new System.Drawing.Size(62, 20);
            this.tx_vocales.TabIndex = 1;
            // 
            // tx_no_alfa
            // 
            this.tx_no_alfa.Location = new System.Drawing.Point(228, 100);
            this.tx_no_alfa.Name = "tx_no_alfa";
            this.tx_no_alfa.ReadOnly = true;
            this.tx_no_alfa.Size = new System.Drawing.Size(62, 20);
            this.tx_no_alfa.TabIndex = 2;
            // 
            // tx_consonantes
            // 
            this.tx_consonantes.Location = new System.Drawing.Point(228, 74);
            this.tx_consonantes.Name = "tx_consonantes";
            this.tx_consonantes.ReadOnly = true;
            this.tx_consonantes.Size = new System.Drawing.Size(62, 20);
            this.tx_consonantes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Largo de la hilera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de vocales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de consonantes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad caracteres no alfanuméricos:";
            // 
            // frm_trabajo_hileras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 298);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_trabajo_hileras";
            this.Text = "Trabajo con Hileras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_hilera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_contenido;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_limpiar_hileras;
        private System.Windows.Forms.Button b_ver;
        private System.Windows.Forms.TextBox tx_consonantes;
        private System.Windows.Forms.TextBox tx_no_alfa;
        private System.Windows.Forms.TextBox tx_vocales;
        private System.Windows.Forms.TextBox tx_largo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}