namespace Tarea3_Joseph_Granadoos
{
    partial class frm_tablas_multiplicar
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
            this.cb_tablas = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_tabla_final = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_limpiar_tablas = new System.Windows.Forms.Button();
            this.b_cargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_al = new System.Windows.Forms.NumericUpDown();
            this.num_del = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_cerrar_tablas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_al)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_del)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tablas);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de Valores";
            // 
            // cb_tablas
            // 
            this.cb_tablas.FormattingEnabled = true;
            this.cb_tablas.Location = new System.Drawing.Point(61, 95);
            this.cb_tablas.Name = "cb_tablas";
            this.cb_tablas.Size = new System.Drawing.Size(141, 21);
            this.cb_tablas.TabIndex = 6;
            this.cb_tablas.SelectedIndexChanged += new System.EventHandler(this.cb_tablas_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_tabla_final);
            this.groupBox4.Location = new System.Drawing.Point(16, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 139);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tabla Final";
            // 
            // lb_tabla_final
            // 
            this.lb_tabla_final.FormattingEnabled = true;
            this.lb_tabla_final.Location = new System.Drawing.Point(10, 19);
            this.lb_tabla_final.Name = "lb_tabla_final";
            this.lb_tabla_final.ScrollAlwaysVisible = true;
            this.lb_tabla_final.Size = new System.Drawing.Size(190, 108);
            this.lb_tabla_final.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tablas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_limpiar_tablas);
            this.groupBox3.Controls.Add(this.b_cargar);
            this.groupBox3.Location = new System.Drawing.Point(239, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 92);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // b_limpiar_tablas
            // 
            this.b_limpiar_tablas.Location = new System.Drawing.Point(15, 53);
            this.b_limpiar_tablas.Name = "b_limpiar_tablas";
            this.b_limpiar_tablas.Size = new System.Drawing.Size(75, 23);
            this.b_limpiar_tablas.TabIndex = 1;
            this.b_limpiar_tablas.Text = "Limpiar";
            this.b_limpiar_tablas.UseVisualStyleBackColor = true;
            this.b_limpiar_tablas.Click += new System.EventHandler(this.b_limpiar_tablas_Click);
            // 
            // b_cargar
            // 
            this.b_cargar.Location = new System.Drawing.Point(15, 24);
            this.b_cargar.Name = "b_cargar";
            this.b_cargar.Size = new System.Drawing.Size(75, 23);
            this.b_cargar.TabIndex = 0;
            this.b_cargar.Text = "Cargar";
            this.b_cargar.UseVisualStyleBackColor = true;
            this.b_cargar.Click += new System.EventHandler(this.b_cargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_al);
            this.groupBox2.Controls.Add(this.num_del);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de Tablas";
            // 
            // num_al
            // 
            this.num_al.Location = new System.Drawing.Point(139, 27);
            this.num_al.Name = "num_al";
            this.num_al.Size = new System.Drawing.Size(47, 20);
            this.num_al.TabIndex = 3;
            // 
            // num_del
            // 
            this.num_del.Location = new System.Drawing.Point(39, 27);
            this.num_del.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_del.Name = "num_del";
            this.num_del.Size = new System.Drawing.Size(47, 20);
            this.num_del.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Al:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Del:";
            // 
            // b_cerrar_tablas
            // 
            this.b_cerrar_tablas.Location = new System.Drawing.Point(293, 305);
            this.b_cerrar_tablas.Name = "b_cerrar_tablas";
            this.b_cerrar_tablas.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar_tablas.TabIndex = 1;
            this.b_cerrar_tablas.Text = "Cerrar";
            this.b_cerrar_tablas.UseVisualStyleBackColor = true;
            this.b_cerrar_tablas.Click += new System.EventHandler(this.b_cerrar_tablas_Click);
            // 
            // frm_tablas_multiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 333);
            this.Controls.Add(this.b_cerrar_tablas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tablas_multiplicar";
            this.Text = "Tablas de Multiplicar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_al)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_limpiar_tablas;
        private System.Windows.Forms.Button b_cargar;
        private System.Windows.Forms.NumericUpDown num_al;
        private System.Windows.Forms.NumericUpDown num_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_cerrar_tablas;
        private System.Windows.Forms.ComboBox cb_tablas;
        private System.Windows.Forms.ListBox lb_tabla_final;
    }
}