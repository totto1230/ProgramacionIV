namespace Tarea1_Joseph_Granados
{
    partial class frm_conversiones
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_decimal = new System.Windows.Forms.TextBox();
            this.b_calcular = new System.Windows.Forms.Button();
            this.b_limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_double = new System.Windows.Forms.TextBox();
            this.tx_float = new System.Windows.Forms.TextBox();
            this.tx_long = new System.Windows.Forms.TextBox();
            this.tx_int = new System.Windows.Forms.TextBox();
            this.tx_short = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_limpiar);
            this.groupBox1.Controls.Add(this.b_calcular);
            this.groupBox1.Controls.Add(this.tx_decimal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversiones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_short);
            this.groupBox2.Controls.Add(this.tx_int);
            this.groupBox2.Controls.Add(this.tx_long);
            this.groupBox2.Controls.Add(this.tx_float);
            this.groupBox2.Controls.Add(this.tx_double);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(245, 327);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 1;
            this.b_cerrar.Text = "Cerrar";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Decimal: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_decimal
            // 
            this.tx_decimal.Location = new System.Drawing.Point(102, 39);
            this.tx_decimal.Name = "tx_decimal";
            this.tx_decimal.Size = new System.Drawing.Size(100, 20);
            this.tx_decimal.TabIndex = 2;
            this.tx_decimal.TextChanged += new System.EventHandler(this.tx_decimal_TextChanged);
            // 
            // b_calcular
            // 
            this.b_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_calcular.Location = new System.Drawing.Point(211, 39);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(90, 23);
            this.b_calcular.TabIndex = 3;
            this.b_calcular.Text = "Ver Resultados";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // b_limpiar
            // 
            this.b_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_limpiar.Location = new System.Drawing.Point(211, 68);
            this.b_limpiar.Name = "b_limpiar";
            this.b_limpiar.Size = new System.Drawing.Size(90, 23);
            this.b_limpiar.TabIndex = 4;
            this.b_limpiar.Text = "Limpiar";
            this.b_limpiar.UseVisualStyleBackColor = true;
            this.b_limpiar.Click += new System.EventHandler(this.b_limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Short";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Long";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Float";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(11, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Double";
            // 
            // tx_double
            // 
            this.tx_double.Location = new System.Drawing.Point(96, 168);
            this.tx_double.Name = "tx_double";
            this.tx_double.ReadOnly = true;
            this.tx_double.Size = new System.Drawing.Size(100, 20);
            this.tx_double.TabIndex = 5;
            // 
            // tx_float
            // 
            this.tx_float.Location = new System.Drawing.Point(96, 132);
            this.tx_float.Name = "tx_float";
            this.tx_float.ReadOnly = true;
            this.tx_float.Size = new System.Drawing.Size(100, 20);
            this.tx_float.TabIndex = 6;
            // 
            // tx_long
            // 
            this.tx_long.Location = new System.Drawing.Point(96, 98);
            this.tx_long.Name = "tx_long";
            this.tx_long.ReadOnly = true;
            this.tx_long.Size = new System.Drawing.Size(100, 20);
            this.tx_long.TabIndex = 7;
            // 
            // tx_int
            // 
            this.tx_int.Location = new System.Drawing.Point(96, 68);
            this.tx_int.Name = "tx_int";
            this.tx_int.ReadOnly = true;
            this.tx_int.Size = new System.Drawing.Size(100, 20);
            this.tx_int.TabIndex = 8;
            this.tx_int.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tx_short
            // 
            this.tx_short.Location = new System.Drawing.Point(96, 31);
            this.tx_short.Name = "tx_short";
            this.tx_short.ReadOnly = true;
            this.tx_short.Size = new System.Drawing.Size(100, 20);
            this.tx_short.TabIndex = 9;
            // 
            // frm_conversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 359);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_conversiones";
            this.Text = "Conversiones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_limpiar;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.TextBox tx_decimal;
        private System.Windows.Forms.TextBox tx_short;
        private System.Windows.Forms.TextBox tx_int;
        private System.Windows.Forms.TextBox tx_long;
        private System.Windows.Forms.TextBox tx_float;
        private System.Windows.Forms.TextBox tx_double;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}