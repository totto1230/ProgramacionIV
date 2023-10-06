namespace Tarea3_Joseph_Granadoos
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
            this.li_la_hileras = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.li_la_num = new System.Windows.Forms.LinkLabel();
            this.li_la_tabla_multi = new System.Windows.Forms.LinkLabel();
            this.li_la_masked_fechas = new System.Windows.Forms.LinkLabel();
            this.li_la_salir = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.li_la_salir);
            this.groupBox1.Controls.Add(this.li_la_masked_fechas);
            this.groupBox1.Controls.Add(this.li_la_tabla_multi);
            this.groupBox1.Controls.Add(this.li_la_num);
            this.groupBox1.Controls.Add(this.li_la_hileras);
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // li_la_hileras
            // 
            this.li_la_hileras.AutoSize = true;
            this.li_la_hileras.Location = new System.Drawing.Point(30, 30);
            this.li_la_hileras.Name = "li_la_hileras";
            this.li_la_hileras.Size = new System.Drawing.Size(92, 13);
            this.li_la_hileras.TabIndex = 0;
            this.li_la_hileras.TabStop = true;
            this.li_la_hileras.Text = "Manejo de Hileras";
            this.li_la_hileras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // li_la_num
            // 
            this.li_la_num.AutoSize = true;
            this.li_la_num.Location = new System.Drawing.Point(30, 58);
            this.li_la_num.Name = "li_la_num";
            this.li_la_num.Size = new System.Drawing.Size(88, 13);
            this.li_la_num.TabIndex = 1;
            this.li_la_num.TabStop = true;
            this.li_la_num.Text = "NumericUpDown";
            this.li_la_num.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.li_la_num_LinkClicked);
            // 
            // li_la_tabla_multi
            // 
            this.li_la_tabla_multi.AutoSize = true;
            this.li_la_tabla_multi.Location = new System.Drawing.Point(30, 90);
            this.li_la_tabla_multi.Name = "li_la_tabla_multi";
            this.li_la_tabla_multi.Size = new System.Drawing.Size(99, 13);
            this.li_la_tabla_multi.TabIndex = 2;
            this.li_la_tabla_multi.TabStop = true;
            this.li_la_tabla_multi.Text = "Tabla de Multiplicar";
            this.li_la_tabla_multi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.li_la_tabla_multi_LinkClicked);
            // 
            // li_la_masked_fechas
            // 
            this.li_la_masked_fechas.AutoSize = true;
            this.li_la_masked_fechas.Location = new System.Drawing.Point(30, 119);
            this.li_la_masked_fechas.Name = "li_la_masked_fechas";
            this.li_la_masked_fechas.Size = new System.Drawing.Size(130, 13);
            this.li_la_masked_fechas.TabIndex = 3;
            this.li_la_masked_fechas.TabStop = true;
            this.li_la_masked_fechas.Text = "MaskedTextBox y Fechas";
            this.li_la_masked_fechas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.li_la_masked_fechas_LinkClicked);
            // 
            // li_la_salir
            // 
            this.li_la_salir.AutoSize = true;
            this.li_la_salir.Location = new System.Drawing.Point(30, 146);
            this.li_la_salir.Name = "li_la_salir";
            this.li_la_salir.Size = new System.Drawing.Size(27, 13);
            this.li_la_salir.TabIndex = 4;
            this.li_la_salir.TabStop = true;
            this.li_la_salir.Text = "Salir";
            this.li_la_salir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Menú";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel li_la_salir;
        private System.Windows.Forms.LinkLabel li_la_masked_fechas;
        private System.Windows.Forms.LinkLabel li_la_tabla_multi;
        private System.Windows.Forms.LinkLabel li_la_num;
        private System.Windows.Forms.LinkLabel li_la_hileras;
        private System.Windows.Forms.Label label1;
    }
}

