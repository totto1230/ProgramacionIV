namespace Tarea1_Joseph_Granados
{
    partial class Form1
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
            this.b_Salir = new System.Windows.Forms.Button();
            this.b_conversiones = new System.Windows.Forms.Button();
            this.b_restaurante = new System.Windows.Forms.Button();
            this.b_evaluacion = new System.Windows.Forms.Button();
            this.b_hipotenusa = new System.Windows.Forms.Button();
            this.b_ecuacion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_Salir);
            this.groupBox1.Controls.Add(this.b_conversiones);
            this.groupBox1.Controls.Add(this.b_restaurante);
            this.groupBox1.Controls.Add(this.b_evaluacion);
            this.groupBox1.Controls.Add(this.b_hipotenusa);
            this.groupBox1.Controls.Add(this.b_ecuacion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // b_Salir
            // 
            this.b_Salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_Salir.Location = new System.Drawing.Point(22, 259);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(156, 28);
            this.b_Salir.TabIndex = 5;
            this.b_Salir.Text = "Salir";
            this.b_Salir.UseVisualStyleBackColor = true;
            this.b_Salir.Click += new System.EventHandler(this.b_Salir_Click);
            // 
            // b_conversiones
            // 
            this.b_conversiones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_conversiones.Location = new System.Drawing.Point(22, 212);
            this.b_conversiones.Name = "b_conversiones";
            this.b_conversiones.Size = new System.Drawing.Size(156, 28);
            this.b_conversiones.TabIndex = 4;
            this.b_conversiones.Text = "Conversiones";
            this.b_conversiones.UseVisualStyleBackColor = true;
            this.b_conversiones.Click += new System.EventHandler(this.b_conversiones_Click);
            // 
            // b_restaurante
            // 
            this.b_restaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_restaurante.Location = new System.Drawing.Point(22, 165);
            this.b_restaurante.Name = "b_restaurante";
            this.b_restaurante.Size = new System.Drawing.Size(156, 28);
            this.b_restaurante.TabIndex = 3;
            this.b_restaurante.Text = "Restaurante";
            this.b_restaurante.UseVisualStyleBackColor = true;
            this.b_restaurante.Click += new System.EventHandler(this.b_restaurante_Click);
            // 
            // b_evaluacion
            // 
            this.b_evaluacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_evaluacion.Location = new System.Drawing.Point(22, 117);
            this.b_evaluacion.Name = "b_evaluacion";
            this.b_evaluacion.Size = new System.Drawing.Size(156, 28);
            this.b_evaluacion.TabIndex = 2;
            this.b_evaluacion.Text = "Evaluación";
            this.b_evaluacion.UseVisualStyleBackColor = true;
            this.b_evaluacion.Click += new System.EventHandler(this.b_evaluacion_Click);
            // 
            // b_hipotenusa
            // 
            this.b_hipotenusa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_hipotenusa.Location = new System.Drawing.Point(22, 74);
            this.b_hipotenusa.Name = "b_hipotenusa";
            this.b_hipotenusa.Size = new System.Drawing.Size(156, 28);
            this.b_hipotenusa.TabIndex = 1;
            this.b_hipotenusa.Text = "Hipotenusa";
            this.b_hipotenusa.UseVisualStyleBackColor = true;
            this.b_hipotenusa.Click += new System.EventHandler(this.b_hipotenusa_Click);
            // 
            // b_ecuacion
            // 
            this.b_ecuacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_ecuacion.Location = new System.Drawing.Point(22, 29);
            this.b_ecuacion.Name = "b_ecuacion";
            this.b_ecuacion.Size = new System.Drawing.Size(156, 28);
            this.b_ecuacion.TabIndex = 0;
            this.b_ecuacion.Text = "Ecuación";
            this.b_ecuacion.UseVisualStyleBackColor = true;
            this.b_ecuacion.Click += new System.EventHandler(this.b_ecuacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Menú";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Button b_conversiones;
        private System.Windows.Forms.Button b_restaurante;
        private System.Windows.Forms.Button b_evaluacion;
        private System.Windows.Forms.Button b_hipotenusa;
        private System.Windows.Forms.Button b_ecuacion;
    }
}

