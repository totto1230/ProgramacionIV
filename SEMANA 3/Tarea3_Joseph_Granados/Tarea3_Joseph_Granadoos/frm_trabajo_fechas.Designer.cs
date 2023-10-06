namespace Tarea3_Joseph_Granadoos
{
    partial class frm_trabajo_fechas
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
            this.tx_dia_semana = new System.Windows.Forms.TextBox();
            this.tx_signo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_anio = new System.Windows.Forms.TextBox();
            this.tx_mes = new System.Windows.Forms.TextBox();
            this.tx_dia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_extraer = new System.Windows.Forms.Button();
            this.tx_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_dias = new System.Windows.Forms.TextBox();
            this.tx_horas = new System.Windows.Forms.TextBox();
            this.tx_mins = new System.Windows.Forms.TextBox();
            this.tx_fecha_inicio = new System.Windows.Forms.MaskedTextBox();
            this.tx_fecha_final = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.b_ver = new System.Windows.Forms.Button();
            this.b_cerrar_fechas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_dia_semana);
            this.groupBox1.Controls.Add(this.tx_signo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_anio);
            this.groupBox1.Controls.Add(this.tx_mes);
            this.groupBox1.Controls.Add(this.tx_dia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.b_extraer);
            this.groupBox1.Controls.Add(this.tx_fecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partes de una fecha";
            // 
            // tx_dia_semana
            // 
            this.tx_dia_semana.Location = new System.Drawing.Point(131, 170);
            this.tx_dia_semana.Name = "tx_dia_semana";
            this.tx_dia_semana.ReadOnly = true;
            this.tx_dia_semana.Size = new System.Drawing.Size(100, 20);
            this.tx_dia_semana.TabIndex = 12;
            // 
            // tx_signo
            // 
            this.tx_signo.Location = new System.Drawing.Point(131, 132);
            this.tx_signo.Name = "tx_signo";
            this.tx_signo.ReadOnly = true;
            this.tx_signo.Size = new System.Drawing.Size(100, 20);
            this.tx_signo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Día de la semana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Signo Zodiacal:";
            // 
            // tx_anio
            // 
            this.tx_anio.Location = new System.Drawing.Point(302, 78);
            this.tx_anio.Name = "tx_anio";
            this.tx_anio.ReadOnly = true;
            this.tx_anio.Size = new System.Drawing.Size(56, 20);
            this.tx_anio.TabIndex = 8;
            // 
            // tx_mes
            // 
            this.tx_mes.Location = new System.Drawing.Point(164, 78);
            this.tx_mes.Name = "tx_mes";
            this.tx_mes.ReadOnly = true;
            this.tx_mes.Size = new System.Drawing.Size(56, 20);
            this.tx_mes.TabIndex = 7;
            // 
            // tx_dia
            // 
            this.tx_dia.Location = new System.Drawing.Point(52, 78);
            this.tx_dia.Name = "tx_dia";
            this.tx_dia.ReadOnly = true;
            this.tx_dia.Size = new System.Drawing.Size(56, 20);
            this.tx_dia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Día:";
            // 
            // b_extraer
            // 
            this.b_extraer.Location = new System.Drawing.Point(161, 26);
            this.b_extraer.Name = "b_extraer";
            this.b_extraer.Size = new System.Drawing.Size(96, 23);
            this.b_extraer.TabIndex = 2;
            this.b_extraer.Text = "Extraer";
            this.b_extraer.UseVisualStyleBackColor = true;
            this.b_extraer.Click += new System.EventHandler(this.b_extraer_Click);
            // 
            // tx_fecha
            // 
            this.tx_fecha.Location = new System.Drawing.Point(61, 26);
            this.tx_fecha.Mask = "00/00/0000";
            this.tx_fecha.Name = "tx_fecha";
            this.tx_fecha.Size = new System.Drawing.Size(71, 20);
            this.tx_fecha.TabIndex = 1;
            this.tx_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_ver);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tx_fecha_final);
            this.groupBox2.Controls.Add(this.tx_fecha_inicio);
            this.groupBox2.Controls.Add(this.tx_mins);
            this.groupBox2.Controls.Add(this.tx_horas);
            this.groupBox2.Controls.Add(this.tx_dias);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diferencias entre fechas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Diferencias en días:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Diferencias en horas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Diferencias en minutos:";
            // 
            // tx_dias
            // 
            this.tx_dias.Location = new System.Drawing.Point(161, 60);
            this.tx_dias.Name = "tx_dias";
            this.tx_dias.ReadOnly = true;
            this.tx_dias.Size = new System.Drawing.Size(70, 20);
            this.tx_dias.TabIndex = 4;
            // 
            // tx_horas
            // 
            this.tx_horas.Location = new System.Drawing.Point(161, 97);
            this.tx_horas.Name = "tx_horas";
            this.tx_horas.ReadOnly = true;
            this.tx_horas.Size = new System.Drawing.Size(70, 20);
            this.tx_horas.TabIndex = 5;
            // 
            // tx_mins
            // 
            this.tx_mins.Location = new System.Drawing.Point(161, 130);
            this.tx_mins.Name = "tx_mins";
            this.tx_mins.ReadOnly = true;
            this.tx_mins.Size = new System.Drawing.Size(70, 20);
            this.tx_mins.TabIndex = 6;
            // 
            // tx_fecha_inicio
            // 
            this.tx_fecha_inicio.Location = new System.Drawing.Point(92, 27);
            this.tx_fecha_inicio.Mask = "00/00/0000 90:00:00";
            this.tx_fecha_inicio.Name = "tx_fecha_inicio";
            this.tx_fecha_inicio.Size = new System.Drawing.Size(114, 20);
            this.tx_fecha_inicio.TabIndex = 13;
            // 
            // tx_fecha_final
            // 
            this.tx_fecha_final.Location = new System.Drawing.Point(302, 27);
            this.tx_fecha_final.Mask = "00/00/0000 90:00:00";
            this.tx_fecha_final.Name = "tx_fecha_final";
            this.tx_fecha_final.Size = new System.Drawing.Size(114, 20);
            this.tx_fecha_final.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fecha Final:";
            // 
            // b_ver
            // 
            this.b_ver.Location = new System.Drawing.Point(432, 25);
            this.b_ver.Name = "b_ver";
            this.b_ver.Size = new System.Drawing.Size(43, 23);
            this.b_ver.TabIndex = 16;
            this.b_ver.Text = "Ver";
            this.b_ver.UseVisualStyleBackColor = true;
            this.b_ver.Click += new System.EventHandler(this.b_ver_Click);
            // 
            // b_cerrar_fechas
            // 
            this.b_cerrar_fechas.Location = new System.Drawing.Point(430, 394);
            this.b_cerrar_fechas.Name = "b_cerrar_fechas";
            this.b_cerrar_fechas.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar_fechas.TabIndex = 2;
            this.b_cerrar_fechas.Text = "Cerrar";
            this.b_cerrar_fechas.UseVisualStyleBackColor = true;
            this.b_cerrar_fechas.Click += new System.EventHandler(this.b_cerrar_fechas_Click);
            // 
            // frm_trabajo_fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 424);
            this.Controls.Add(this.b_cerrar_fechas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_trabajo_fechas";
            this.Text = "Trabajo con Fechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_extraer;
        private System.Windows.Forms.MaskedTextBox tx_fecha;
        private System.Windows.Forms.TextBox tx_anio;
        private System.Windows.Forms.TextBox tx_mes;
        private System.Windows.Forms.TextBox tx_dia;
        private System.Windows.Forms.TextBox tx_dia_semana;
        private System.Windows.Forms.TextBox tx_signo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tx_mins;
        private System.Windows.Forms.TextBox tx_horas;
        private System.Windows.Forms.TextBox tx_dias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tx_fecha_inicio;
        private System.Windows.Forms.Button b_ver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tx_fecha_final;
        private System.Windows.Forms.Button b_cerrar_fechas;
    }
}