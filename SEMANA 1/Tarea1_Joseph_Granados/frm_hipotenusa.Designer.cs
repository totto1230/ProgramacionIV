namespace Tarea1_Joseph_Granados
{
    partial class frm_hipotenusa
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
            this.b_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_lado1 = new System.Windows.Forms.TextBox();
            this.tx_lado2 = new System.Windows.Forms.TextBox();
            this.tx_hipotenusa = new System.Windows.Forms.TextBox();
            this.b_calcular = new System.Windows.Forms.Button();
            this.b_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(218, 197);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 0;
            this.b_cerrar.Text = "Cerrar";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triángulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_limpiar);
            this.groupBox2.Controls.Add(this.b_calcular);
            this.groupBox2.Controls.Add(this.tx_hipotenusa);
            this.groupBox2.Controls.Add(this.tx_lado2);
            this.groupBox2.Controls.Add(this.tx_lado1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(17, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hipotenusa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hipotenusa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tx_lado1
            // 
            this.tx_lado1.Location = new System.Drawing.Point(89, 29);
            this.tx_lado1.Name = "tx_lado1";
            this.tx_lado1.Size = new System.Drawing.Size(49, 20);
            this.tx_lado1.TabIndex = 3;
            // 
            // tx_lado2
            // 
            this.tx_lado2.Location = new System.Drawing.Point(89, 60);
            this.tx_lado2.Name = "tx_lado2";
            this.tx_lado2.Size = new System.Drawing.Size(49, 20);
            this.tx_lado2.TabIndex = 4;
            // 
            // tx_hipotenusa
            // 
            this.tx_hipotenusa.Location = new System.Drawing.Point(89, 87);
            this.tx_hipotenusa.Name = "tx_hipotenusa";
            this.tx_hipotenusa.ReadOnly = true;
            this.tx_hipotenusa.Size = new System.Drawing.Size(49, 20);
            this.tx_hipotenusa.TabIndex = 5;
            // 
            // b_calcular
            // 
            this.b_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_calcular.Location = new System.Drawing.Point(158, 39);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(75, 23);
            this.b_calcular.TabIndex = 6;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // b_limpiar
            // 
            this.b_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_limpiar.Location = new System.Drawing.Point(158, 77);
            this.b_limpiar.Name = "b_limpiar";
            this.b_limpiar.Size = new System.Drawing.Size(75, 23);
            this.b_limpiar.TabIndex = 7;
            this.b_limpiar.Text = "Limpiar";
            this.b_limpiar.UseVisualStyleBackColor = true;
            this.b_limpiar.Click += new System.EventHandler(this.b_limpiar_Click);
            // 
            // frm_hipotenusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_cerrar);
            this.Name = "frm_hipotenusa";
            this.Text = "Formulas Geométricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_hipotenusa;
        private System.Windows.Forms.TextBox tx_lado2;
        private System.Windows.Forms.TextBox tx_lado1;
        private System.Windows.Forms.Button b_limpiar;
        private System.Windows.Forms.Button b_calcular;
    }
}