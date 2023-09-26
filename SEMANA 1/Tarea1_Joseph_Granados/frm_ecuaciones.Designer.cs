namespace Tarea1_Joseph_Granados
{
    partial class frm_ecuaciones
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
            this.label5 = new System.Windows.Forms.Label();
            this.tx_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_calcular = new System.Windows.Forms.Button();
            this.tx_c = new System.Windows.Forms.TextBox();
            this.tx_b = new System.Windows.Forms.TextBox();
            this.tx_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_resultado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.b_calcular);
            this.groupBox1.Controls.Add(this.tx_c);
            this.groupBox1.Controls.Add(this.tx_b);
            this.groupBox1.Controls.Add(this.tx_a);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Ecuación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(45, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Formato: ax + b = c";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tx_resultado
            // 
            this.tx_resultado.Location = new System.Drawing.Point(85, 113);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.ReadOnly = true;
            this.tx_resultado.Size = new System.Drawing.Size(79, 20);
            this.tx_resultado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // b_calcular
            // 
            this.b_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_calcular.Location = new System.Drawing.Point(200, 62);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(75, 23);
            this.b_calcular.TabIndex = 6;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // tx_c
            // 
            this.tx_c.Location = new System.Drawing.Point(139, 65);
            this.tx_c.Name = "tx_c";
            this.tx_c.Size = new System.Drawing.Size(32, 20);
            this.tx_c.TabIndex = 5;
            // 
            // tx_b
            // 
            this.tx_b.Location = new System.Drawing.Point(85, 65);
            this.tx_b.Name = "tx_b";
            this.tx_b.Size = new System.Drawing.Size(32, 20);
            this.tx_b.TabIndex = 4;
            // 
            // tx_a
            // 
            this.tx_a.Location = new System.Drawing.Point(27, 65);
            this.tx_a.Name = "tx_a";
            this.tx_a.Size = new System.Drawing.Size(32, 20);
            this.tx_a.TabIndex = 3;
            this.tx_a.TextChanged += new System.EventHandler(this.tx_a_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(147, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(91, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_cerrar.Location = new System.Drawing.Point(212, 165);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 1;
            this.b_cerrar.Text = "Cerrar";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // frm_ecuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 194);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ecuaciones";
            this.Text = "Ecuaciones Primer Grado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.TextBox tx_b;
        private System.Windows.Forms.TextBox tx_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_c;
        private System.Windows.Forms.TextBox tx_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.Label label5;
    }
}