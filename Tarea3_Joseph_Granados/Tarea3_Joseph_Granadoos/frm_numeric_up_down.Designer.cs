namespace Tarea3_Joseph_Granadoos
{
    partial class frm_numeric_up_down
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tx_monto_pagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_limpiar_parqueo = new System.Windows.Forms.Button();
            this.b_calcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_cerrar_parqueo = new System.Windows.Forms.Button();
            this.num_horas_entrada = new System.Windows.Forms.NumericUpDown();
            this.num_horas_salida = new System.Windows.Forms.NumericUpDown();
            this.num_min_salida = new System.Windows.Forms.NumericUpDown();
            this.num_min_entrada = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_horas_entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horas_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_entrada)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de Valores";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tx_monto_pagar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(17, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 69);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // tx_monto_pagar
            // 
            this.tx_monto_pagar.Location = new System.Drawing.Point(112, 29);
            this.tx_monto_pagar.Name = "tx_monto_pagar";
            this.tx_monto_pagar.ReadOnly = true;
            this.tx_monto_pagar.Size = new System.Drawing.Size(157, 20);
            this.tx_monto_pagar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto a Pagar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_limpiar_parqueo);
            this.groupBox3.Controls.Add(this.b_calcular);
            this.groupBox3.Location = new System.Drawing.Point(267, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // b_limpiar_parqueo
            // 
            this.b_limpiar_parqueo.Location = new System.Drawing.Point(107, 19);
            this.b_limpiar_parqueo.Name = "b_limpiar_parqueo";
            this.b_limpiar_parqueo.Size = new System.Drawing.Size(75, 23);
            this.b_limpiar_parqueo.TabIndex = 1;
            this.b_limpiar_parqueo.Text = "Limpiar";
            this.b_limpiar_parqueo.UseVisualStyleBackColor = true;
            this.b_limpiar_parqueo.Click += new System.EventHandler(this.b_limpiar_parqueo_Click);
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(15, 19);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(75, 23);
            this.b_calcular.TabIndex = 0;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_min_entrada);
            this.groupBox2.Controls.Add(this.num_min_salida);
            this.groupBox2.Controls.Add(this.num_horas_salida);
            this.groupBox2.Controls.Add(this.num_horas_entrada);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Salida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora Entrada:";
            // 
            // b_cerrar_parqueo
            // 
            this.b_cerrar_parqueo.Location = new System.Drawing.Point(413, 261);
            this.b_cerrar_parqueo.Name = "b_cerrar_parqueo";
            this.b_cerrar_parqueo.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar_parqueo.TabIndex = 1;
            this.b_cerrar_parqueo.Text = "Cerrar";
            this.b_cerrar_parqueo.UseVisualStyleBackColor = true;
            this.b_cerrar_parqueo.Click += new System.EventHandler(this.b_cerrar_parqueo_Click);
            // 
            // num_horas_entrada
            // 
            this.num_horas_entrada.Location = new System.Drawing.Point(99, 39);
            this.num_horas_entrada.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_horas_entrada.Name = "num_horas_entrada";
            this.num_horas_entrada.Size = new System.Drawing.Size(32, 20);
            this.num_horas_entrada.TabIndex = 3;
            // 
            // num_horas_salida
            // 
            this.num_horas_salida.Location = new System.Drawing.Point(99, 70);
            this.num_horas_salida.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_horas_salida.Name = "num_horas_salida";
            this.num_horas_salida.Size = new System.Drawing.Size(32, 20);
            this.num_horas_salida.TabIndex = 4;
            // 
            // num_min_salida
            // 
            this.num_min_salida.Location = new System.Drawing.Point(152, 70);
            this.num_min_salida.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_min_salida.Name = "num_min_salida";
            this.num_min_salida.Size = new System.Drawing.Size(32, 20);
            this.num_min_salida.TabIndex = 5;
            // 
            // num_min_entrada
            // 
            this.num_min_entrada.Location = new System.Drawing.Point(152, 39);
            this.num_min_entrada.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_min_entrada.Name = "num_min_entrada";
            this.num_min_entrada.Size = new System.Drawing.Size(32, 20);
            this.num_min_entrada.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "AM: 01 - 12  ,  PM: 13 - 23";
            // 
            // frm_numeric_up_down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 289);
            this.Controls.Add(this.b_cerrar_parqueo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_numeric_up_down";
            this.Text = "Parqueo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_horas_entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_horas_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_entrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_limpiar_parqueo;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_monto_pagar;
        private System.Windows.Forms.Button b_cerrar_parqueo;
        private System.Windows.Forms.NumericUpDown num_min_entrada;
        private System.Windows.Forms.NumericUpDown num_min_salida;
        private System.Windows.Forms.NumericUpDown num_horas_salida;
        private System.Windows.Forms.NumericUpDown num_horas_entrada;
        private System.Windows.Forms.Label label6;
    }
}