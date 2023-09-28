namespace Tarea2_Joseph_Granados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            tx_impar = new TextBox();
            tx_par = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tx_resultado_impares = new TextBox();
            tx_resultado_pares = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tx_limite = new TextBox();
            groupBox2 = new GroupBox();
            b_limpiar = new Button();
            b_calcular = new Button();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            b_limpiar_resultados = new Button();
            b_ver_resultado = new Button();
            rb_todas_columnas = new RadioButton();
            tx_columna = new TextBox();
            tx_fila_num = new TextBox();
            rb_todasfilas = new RadioButton();
            rb_columna_num = new RadioButton();
            rb_fila_num = new RadioButton();
            label8 = new Label();
            tx_result4 = new TextBox();
            tx_result3 = new TextBox();
            tx_result2 = new TextBox();
            tx_result1 = new TextBox();
            tx_c3 = new TextBox();
            tx_a4 = new TextBox();
            tx_b4 = new TextBox();
            tx_resultc = new TextBox();
            tx_resultb = new TextBox();
            tx_c4 = new TextBox();
            tx_a3 = new TextBox();
            tx_b3 = new TextBox();
            tx_resulta = new TextBox();
            tx_c2 = new TextBox();
            tx_a2 = new TextBox();
            tx_b2 = new TextBox();
            tx_c1 = new TextBox();
            tx_b1 = new TextBox();
            tx_a1 = new TextBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            rb_num_impar = new RadioButton();
            rb_ambos = new RadioButton();
            rb_num_par = new RadioButton();
            label17 = new Label();
            bo_limpiar = new Button();
            b_llenar = new Button();
            ckb_no_impar = new CheckBox();
            label6 = new Label();
            tx_lim_random = new TextBox();
            tabPage3 = new TabPage();
            groupBox6 = new GroupBox();
            tx_contenido = new TextBox();
            label11 = new Label();
            groupBox7 = new GroupBox();
            b_descendente = new Button();
            b_ascendente = new Button();
            b_limpiarr = new Button();
            b_llenar_arreglo = new Button();
            ckb_no_pares = new CheckBox();
            tx_limite_random = new TextBox();
            tx_tamanio_arreglo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            groupBox8 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            groupBox9 = new GroupBox();
            tx_resultado_tabla = new TextBox();
            b_limpiar_timer = new Button();
            b_detener = new Button();
            b_iniciar = new Button();
            tx_intervalo = new TextBox();
            tx_al = new TextBox();
            tx_del = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            b_salir = new Button();
            timer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(629, 468);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(621, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sumatoria";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tx_impar);
            groupBox1.Controls.Add(tx_par);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tx_resultado_impares);
            groupBox1.Controls.Add(tx_resultado_pares);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tx_limite);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(16, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pares e Impares";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tx_impar
            // 
            tx_impar.Location = new Point(295, 109);
            tx_impar.Multiline = true;
            tx_impar.Name = "tx_impar";
            tx_impar.ScrollBars = ScrollBars.Vertical;
            tx_impar.Size = new Size(100, 140);
            tx_impar.TabIndex = 11;
            // 
            // tx_par
            // 
            tx_par.Location = new Point(88, 109);
            tx_par.Multiline = true;
            tx_par.Name = "tx_par";
            tx_par.ScrollBars = ScrollBars.Vertical;
            tx_par.Size = new Size(100, 140);
            tx_par.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(17, 258);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Sumatoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(220, 258);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Sumatorio:";
            // 
            // tx_resultado_impares
            // 
            tx_resultado_impares.Location = new Point(295, 255);
            tx_resultado_impares.Name = "tx_resultado_impares";
            tx_resultado_impares.ReadOnly = true;
            tx_resultado_impares.Size = new Size(100, 23);
            tx_resultado_impares.TabIndex = 7;
            // 
            // tx_resultado_pares
            // 
            tx_resultado_pares.Location = new Point(88, 255);
            tx_resultado_pares.Name = "tx_resultado_pares";
            tx_resultado_pares.ReadOnly = true;
            tx_resultado_pares.Size = new Size(100, 23);
            tx_resultado_pares.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(237, 109);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Impares:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Pares:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Número Límite:";
            // 
            // tx_limite
            // 
            tx_limite.Location = new Point(113, 42);
            tx_limite.MaxLength = 30000;
            tx_limite.Name = "tx_limite";
            tx_limite.Size = new Size(75, 23);
            tx_limite.TabIndex = 1;
            tx_limite.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(b_limpiar);
            groupBox2.Controls.Add(b_calcular);
            groupBox2.ForeColor = SystemColors.Highlight;
            groupBox2.Location = new Point(220, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 53);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones";
            // 
            // b_limpiar
            // 
            b_limpiar.ForeColor = SystemColors.ControlText;
            b_limpiar.Location = new Point(108, 20);
            b_limpiar.Name = "b_limpiar";
            b_limpiar.Size = new Size(75, 23);
            b_limpiar.TabIndex = 1;
            b_limpiar.Text = "Limpiar";
            b_limpiar.UseVisualStyleBackColor = true;
            b_limpiar.Click += b_limpiar_Click;
            // 
            // b_calcular
            // 
            b_calcular.ForeColor = SystemColors.ControlText;
            b_calcular.Location = new Point(17, 20);
            b_calcular.Name = "b_calcular";
            b_calcular.Size = new Size(75, 23);
            b_calcular.TabIndex = 0;
            b_calcular.Text = "Calcular";
            b_calcular.UseVisualStyleBackColor = true;
            b_calcular.Click += b_calcular_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(621, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "RadioButton";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(tx_result4);
            groupBox3.Controls.Add(tx_result3);
            groupBox3.Controls.Add(tx_result2);
            groupBox3.Controls.Add(tx_result1);
            groupBox3.Controls.Add(tx_c3);
            groupBox3.Controls.Add(tx_a4);
            groupBox3.Controls.Add(tx_b4);
            groupBox3.Controls.Add(tx_resultc);
            groupBox3.Controls.Add(tx_resultb);
            groupBox3.Controls.Add(tx_c4);
            groupBox3.Controls.Add(tx_a3);
            groupBox3.Controls.Add(tx_b3);
            groupBox3.Controls.Add(tx_resulta);
            groupBox3.Controls.Add(tx_c2);
            groupBox3.Controls.Add(tx_a2);
            groupBox3.Controls.Add(tx_b2);
            groupBox3.Controls.Add(tx_c1);
            groupBox3.Controls.Add(tx_b1);
            groupBox3.Controls.Add(tx_a1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(609, 428);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(b_limpiar_resultados);
            groupBox5.Controls.Add(b_ver_resultado);
            groupBox5.Controls.Add(rb_todas_columnas);
            groupBox5.Controls.Add(tx_columna);
            groupBox5.Controls.Add(tx_fila_num);
            groupBox5.Controls.Add(rb_todasfilas);
            groupBox5.Controls.Add(rb_columna_num);
            groupBox5.Controls.Add(rb_fila_num);
            groupBox5.Location = new Point(23, 309);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(420, 113);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Opciones Resultados";
            // 
            // b_limpiar_resultados
            // 
            b_limpiar_resultados.Location = new Point(257, 76);
            b_limpiar_resultados.Name = "b_limpiar_resultados";
            b_limpiar_resultados.Size = new Size(116, 23);
            b_limpiar_resultados.TabIndex = 7;
            b_limpiar_resultados.Text = "Limpiar Resultado";
            b_limpiar_resultados.UseVisualStyleBackColor = true;
            b_limpiar_resultados.Click += b_limpiar_resultados_Click;
            // 
            // b_ver_resultado
            // 
            b_ver_resultado.Location = new Point(257, 47);
            b_ver_resultado.Name = "b_ver_resultado";
            b_ver_resultado.Size = new Size(116, 23);
            b_ver_resultado.TabIndex = 6;
            b_ver_resultado.Text = "Ver Resultado";
            b_ver_resultado.UseVisualStyleBackColor = true;
            b_ver_resultado.Click += b_ver_resultado_Click;
            // 
            // rb_todas_columnas
            // 
            rb_todas_columnas.AutoSize = true;
            rb_todas_columnas.Location = new Point(257, 22);
            rb_todas_columnas.Name = "rb_todas_columnas";
            rb_todas_columnas.Size = new Size(155, 19);
            rb_todas_columnas.TabIndex = 5;
            rb_todas_columnas.TabStop = true;
            rb_todas_columnas.Text = "Para todas las columnas:";
            rb_todas_columnas.UseVisualStyleBackColor = true;
            // 
            // tx_columna
            // 
            tx_columna.Location = new Point(167, 47);
            tx_columna.MaxLength = 4;
            tx_columna.Name = "tx_columna";
            tx_columna.Size = new Size(37, 23);
            tx_columna.TabIndex = 4;
            // 
            // tx_fila_num
            // 
            tx_fila_num.Location = new Point(167, 18);
            tx_fila_num.MaxLength = 3;
            tx_fila_num.Name = "tx_fila_num";
            tx_fila_num.Size = new Size(37, 23);
            tx_fila_num.TabIndex = 3;
            // 
            // rb_todasfilas
            // 
            rb_todasfilas.AutoSize = true;
            rb_todasfilas.Location = new Point(5, 72);
            rb_todasfilas.Name = "rb_todasfilas";
            rb_todasfilas.Size = new Size(121, 19);
            rb_todasfilas.TabIndex = 2;
            rb_todasfilas.TabStop = true;
            rb_todasfilas.Text = "Para todas las filas";
            rb_todasfilas.UseVisualStyleBackColor = true;
            // 
            // rb_columna_num
            // 
            rb_columna_num.AutoSize = true;
            rb_columna_num.Location = new Point(6, 47);
            rb_columna_num.Name = "rb_columna_num";
            rb_columna_num.Size = new Size(141, 19);
            rb_columna_num.TabIndex = 1;
            rb_columna_num.TabStop = true;
            rb_columna_num.Text = "Por columna número:";
            rb_columna_num.UseVisualStyleBackColor = true;
            // 
            // rb_fila_num
            // 
            rb_fila_num.AutoSize = true;
            rb_fila_num.Location = new Point(6, 22);
            rb_fila_num.Name = "rb_fila_num";
            rb_fila_num.Size = new Size(113, 19);
            rb_fila_num.TabIndex = 0;
            rb_fila_num.TabStop = true;
            rb_fila_num.Text = "Por fila  número:";
            rb_fila_num.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 264);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 21;
            label8.Text = "Resultados:";
            // 
            // tx_result4
            // 
            tx_result4.Location = new Point(239, 261);
            tx_result4.Name = "tx_result4";
            tx_result4.ReadOnly = true;
            tx_result4.Size = new Size(36, 23);
            tx_result4.TabIndex = 20;
            // 
            // tx_result3
            // 
            tx_result3.Location = new Point(180, 261);
            tx_result3.Name = "tx_result3";
            tx_result3.ReadOnly = true;
            tx_result3.Size = new Size(36, 23);
            tx_result3.TabIndex = 19;
            // 
            // tx_result2
            // 
            tx_result2.Location = new Point(123, 261);
            tx_result2.Name = "tx_result2";
            tx_result2.ReadOnly = true;
            tx_result2.Size = new Size(36, 23);
            tx_result2.TabIndex = 18;
            // 
            // tx_result1
            // 
            tx_result1.Location = new Point(67, 261);
            tx_result1.Name = "tx_result1";
            tx_result1.ReadOnly = true;
            tx_result1.Size = new Size(36, 23);
            tx_result1.TabIndex = 17;
            // 
            // tx_c3
            // 
            tx_c3.Location = new Point(180, 218);
            tx_c3.Name = "tx_c3";
            tx_c3.ReadOnly = true;
            tx_c3.Size = new Size(36, 23);
            tx_c3.TabIndex = 16;
            // 
            // tx_a4
            // 
            tx_a4.Location = new Point(239, 145);
            tx_a4.Name = "tx_a4";
            tx_a4.ReadOnly = true;
            tx_a4.Size = new Size(36, 23);
            tx_a4.TabIndex = 15;
            // 
            // tx_b4
            // 
            tx_b4.Location = new Point(239, 180);
            tx_b4.Name = "tx_b4";
            tx_b4.ReadOnly = true;
            tx_b4.Size = new Size(36, 23);
            tx_b4.TabIndex = 14;
            // 
            // tx_resultc
            // 
            tx_resultc.Location = new Point(307, 218);
            tx_resultc.Name = "tx_resultc";
            tx_resultc.ReadOnly = true;
            tx_resultc.Size = new Size(67, 23);
            tx_resultc.TabIndex = 13;
            // 
            // tx_resultb
            // 
            tx_resultb.Location = new Point(307, 180);
            tx_resultb.Name = "tx_resultb";
            tx_resultb.ReadOnly = true;
            tx_resultb.Size = new Size(67, 23);
            tx_resultb.TabIndex = 12;
            // 
            // tx_c4
            // 
            tx_c4.Location = new Point(239, 218);
            tx_c4.Name = "tx_c4";
            tx_c4.ReadOnly = true;
            tx_c4.Size = new Size(36, 23);
            tx_c4.TabIndex = 11;
            // 
            // tx_a3
            // 
            tx_a3.Location = new Point(180, 145);
            tx_a3.Name = "tx_a3";
            tx_a3.ReadOnly = true;
            tx_a3.Size = new Size(36, 23);
            tx_a3.TabIndex = 10;
            // 
            // tx_b3
            // 
            tx_b3.Location = new Point(180, 180);
            tx_b3.Name = "tx_b3";
            tx_b3.ReadOnly = true;
            tx_b3.Size = new Size(36, 23);
            tx_b3.TabIndex = 9;
            // 
            // tx_resulta
            // 
            tx_resulta.Location = new Point(307, 145);
            tx_resulta.Name = "tx_resulta";
            tx_resulta.ReadOnly = true;
            tx_resulta.Size = new Size(67, 23);
            tx_resulta.TabIndex = 8;
            // 
            // tx_c2
            // 
            tx_c2.Location = new Point(123, 218);
            tx_c2.Name = "tx_c2";
            tx_c2.ReadOnly = true;
            tx_c2.Size = new Size(36, 23);
            tx_c2.TabIndex = 7;
            // 
            // tx_a2
            // 
            tx_a2.Location = new Point(123, 145);
            tx_a2.Name = "tx_a2";
            tx_a2.ReadOnly = true;
            tx_a2.Size = new Size(36, 23);
            tx_a2.TabIndex = 6;
            // 
            // tx_b2
            // 
            tx_b2.Location = new Point(123, 180);
            tx_b2.Name = "tx_b2";
            tx_b2.ReadOnly = true;
            tx_b2.Size = new Size(36, 23);
            tx_b2.TabIndex = 5;
            // 
            // tx_c1
            // 
            tx_c1.Location = new Point(67, 218);
            tx_c1.Name = "tx_c1";
            tx_c1.ReadOnly = true;
            tx_c1.Size = new Size(36, 23);
            tx_c1.TabIndex = 4;
            // 
            // tx_b1
            // 
            tx_b1.Location = new Point(67, 180);
            tx_b1.Name = "tx_b1";
            tx_b1.ReadOnly = true;
            tx_b1.Size = new Size(36, 23);
            tx_b1.TabIndex = 3;
            // 
            // tx_a1
            // 
            tx_a1.Location = new Point(67, 145);
            tx_a1.Name = "tx_a1";
            tx_a1.ReadOnly = true;
            tx_a1.Size = new Size(36, 23);
            tx_a1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 127);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 1;
            label7.Text = "Resultados:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rb_num_impar);
            groupBox4.Controls.Add(rb_ambos);
            groupBox4.Controls.Add(rb_num_par);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(bo_limpiar);
            groupBox4.Controls.Add(b_llenar);
            groupBox4.Controls.Add(ckb_no_impar);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(tx_lim_random);
            groupBox4.Location = new Point(6, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(597, 102);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opciones";
            // 
            // rb_num_impar
            // 
            rb_num_impar.AutoSize = true;
            rb_num_impar.Location = new Point(248, 51);
            rb_num_impar.Name = "rb_num_impar";
            rb_num_impar.Size = new Size(143, 19);
            rb_num_impar.TabIndex = 8;
            rb_num_impar.TabStop = true;
            rb_num_impar.Text = "Solo números impares";
            rb_num_impar.UseVisualStyleBackColor = true;
            // 
            // rb_ambos
            // 
            rb_ambos.AutoSize = true;
            rb_ambos.Location = new Point(113, 77);
            rb_ambos.Name = "rb_ambos";
            rb_ambos.Size = new Size(63, 19);
            rb_ambos.TabIndex = 7;
            rb_ambos.TabStop = true;
            rb_ambos.Text = "Ambos";
            rb_ambos.UseVisualStyleBackColor = true;
            // 
            // rb_num_par
            // 
            rb_num_par.AutoSize = true;
            rb_num_par.Location = new Point(113, 52);
            rb_num_par.Name = "rb_num_par";
            rb_num_par.Size = new Size(129, 19);
            rb_num_par.TabIndex = 6;
            rb_num_par.TabStop = true;
            rb_num_par.Text = "Solo números pares";
            rb_num_par.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 57);
            label17.Name = "label17";
            label17.Size = new Size(65, 15);
            label17.TabIndex = 5;
            label17.Text = "Llenar con:";
            // 
            // bo_limpiar
            // 
            bo_limpiar.Location = new Point(516, 51);
            bo_limpiar.Name = "bo_limpiar";
            bo_limpiar.Size = new Size(75, 23);
            bo_limpiar.TabIndex = 4;
            bo_limpiar.Text = "Limpiar";
            bo_limpiar.UseVisualStyleBackColor = true;
            bo_limpiar.Click += bo_limpiar_Click;
            // 
            // b_llenar
            // 
            b_llenar.Location = new Point(516, 22);
            b_llenar.Name = "b_llenar";
            b_llenar.Size = new Size(75, 23);
            b_llenar.TabIndex = 3;
            b_llenar.Text = "Llenar";
            b_llenar.UseVisualStyleBackColor = true;
            b_llenar.Click += b_llenar_Click;
            // 
            // ckb_no_impar
            // 
            ckb_no_impar.AutoSize = true;
            ckb_no_impar.Location = new Point(248, 27);
            ckb_no_impar.Name = "ckb_no_impar";
            ckb_no_impar.Size = new Size(251, 19);
            ckb_no_impar.TabIndex = 2;
            ckb_no_impar.Text = "No incluir valores en las columnas impares";
            ckb_no_impar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 25);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 1;
            label6.Text = "Límite del Random:";
            // 
            // tx_lim_random
            // 
            tx_lim_random.Location = new Point(133, 22);
            tx_lim_random.Name = "tx_lim_random";
            tx_lim_random.Size = new Size(100, 23);
            tx_lim_random.TabIndex = 0;
            tx_lim_random.TextChanged += tx_lim_random_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(621, 440);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CheckBox";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tx_contenido);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(b_limpiarr);
            groupBox6.Controls.Add(b_llenar_arreglo);
            groupBox6.Controls.Add(ckb_no_pares);
            groupBox6.Controls.Add(tx_limite_random);
            groupBox6.Controls.Add(tx_tamanio_arreglo);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label9);
            groupBox6.Location = new Point(6, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(598, 361);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Arreglo";
            // 
            // tx_contenido
            // 
            tx_contenido.Location = new Point(143, 261);
            tx_contenido.Multiline = true;
            tx_contenido.Name = "tx_contenido";
            tx_contenido.ReadOnly = true;
            tx_contenido.ScrollBars = ScrollBars.Vertical;
            tx_contenido.Size = new Size(438, 80);
            tx_contenido.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 264);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 8;
            label11.Text = "Contenido Arreglo:";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(b_descendente);
            groupBox7.Controls.Add(b_ascendente);
            groupBox7.Location = new Point(6, 161);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(263, 64);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "Opciones de Ordenamiento";
            // 
            // b_descendente
            // 
            b_descendente.Location = new Point(148, 22);
            b_descendente.Name = "b_descendente";
            b_descendente.Size = new Size(94, 23);
            b_descendente.TabIndex = 1;
            b_descendente.Text = "Descendente";
            b_descendente.UseVisualStyleBackColor = true;
            b_descendente.Click += b_descendente_Click;
            // 
            // b_ascendente
            // 
            b_ascendente.Location = new Point(23, 22);
            b_ascendente.Name = "b_ascendente";
            b_ascendente.Size = new Size(94, 23);
            b_ascendente.TabIndex = 0;
            b_ascendente.Text = "Ascendente";
            b_ascendente.UseVisualStyleBackColor = true;
            b_ascendente.Click += b_ascendente_Click;
            // 
            // b_limpiarr
            // 
            b_limpiarr.Location = new Point(292, 118);
            b_limpiarr.Name = "b_limpiarr";
            b_limpiarr.Size = new Size(100, 23);
            b_limpiarr.TabIndex = 6;
            b_limpiarr.Text = "Limpiar";
            b_limpiarr.UseVisualStyleBackColor = true;
            b_limpiarr.Click += b_limpiarr_Click;
            // 
            // b_llenar_arreglo
            // 
            b_llenar_arreglo.Location = new Point(169, 118);
            b_llenar_arreglo.Name = "b_llenar_arreglo";
            b_llenar_arreglo.Size = new Size(100, 23);
            b_llenar_arreglo.TabIndex = 5;
            b_llenar_arreglo.Text = "Llenar Arreglo";
            b_llenar_arreglo.UseVisualStyleBackColor = true;
            b_llenar_arreglo.Click += b_llenar_arreglo_Click;
            // 
            // ckb_no_pares
            // 
            ckb_no_pares.AutoSize = true;
            ckb_no_pares.Location = new Point(292, 72);
            ckb_no_pares.Name = "ckb_no_pares";
            ckb_no_pares.Size = new Size(227, 19);
            ckb_no_pares.TabIndex = 4;
            ckb_no_pares.Text = "No incluir números pares en el arreglo";
            ckb_no_pares.UseVisualStyleBackColor = true;
            // 
            // tx_limite_random
            // 
            tx_limite_random.Location = new Point(169, 70);
            tx_limite_random.Name = "tx_limite_random";
            tx_limite_random.Size = new Size(100, 23);
            tx_limite_random.TabIndex = 3;
            // 
            // tx_tamanio_arreglo
            // 
            tx_tamanio_arreglo.Location = new Point(169, 28);
            tx_tamanio_arreglo.Name = "tx_tamanio_arreglo";
            tx_tamanio_arreglo.Size = new Size(100, 23);
            tx_tamanio_arreglo.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 70);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 1;
            label10.Text = "Límite del Random:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 31);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 0;
            label9.Text = "Tamaño Arreglo:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(621, 440);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Timer";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label16);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Controls.Add(b_limpiar_timer);
            groupBox8.Controls.Add(b_detener);
            groupBox8.Controls.Add(b_iniciar);
            groupBox8.Controls.Add(tx_intervalo);
            groupBox8.Controls.Add(tx_al);
            groupBox8.Controls.Add(tx_del);
            groupBox8.Controls.Add(label14);
            groupBox8.Controls.Add(label13);
            groupBox8.Controls.Add(label12);
            groupBox8.Location = new Point(6, 6);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(530, 320);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Tablas de Multiplicar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(298, 122);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(242, 121);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 10;
            label15.Text = "Tiempo:";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tx_resultado_tabla);
            groupBox9.Location = new Point(17, 74);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(200, 181);
            groupBox9.TabIndex = 9;
            groupBox9.TabStop = false;
            groupBox9.Text = "Resultado Tabla";
            // 
            // tx_resultado_tabla
            // 
            tx_resultado_tabla.Location = new Point(6, 22);
            tx_resultado_tabla.Multiline = true;
            tx_resultado_tabla.Name = "tx_resultado_tabla";
            tx_resultado_tabla.Size = new Size(188, 154);
            tx_resultado_tabla.TabIndex = 0;
            // 
            // b_limpiar_timer
            // 
            b_limpiar_timer.Location = new Point(404, 151);
            b_limpiar_timer.Name = "b_limpiar_timer";
            b_limpiar_timer.Size = new Size(75, 23);
            b_limpiar_timer.TabIndex = 8;
            b_limpiar_timer.Text = "Limpiar";
            b_limpiar_timer.UseVisualStyleBackColor = true;
            b_limpiar_timer.Click += b_limpiar_timer_Click;
            // 
            // b_detener
            // 
            b_detener.Location = new Point(404, 122);
            b_detener.Name = "b_detener";
            b_detener.Size = new Size(75, 23);
            b_detener.TabIndex = 7;
            b_detener.Text = "Detener";
            b_detener.UseVisualStyleBackColor = true;
            b_detener.Click += b_detener_Click;
            // 
            // b_iniciar
            // 
            b_iniciar.Location = new Point(404, 93);
            b_iniciar.Name = "b_iniciar";
            b_iniciar.Size = new Size(75, 23);
            b_iniciar.TabIndex = 6;
            b_iniciar.Text = "Iniciar";
            b_iniciar.UseVisualStyleBackColor = true;
            b_iniciar.Click += b_iniciar_Click;
            // 
            // tx_intervalo
            // 
            tx_intervalo.Location = new Point(408, 31);
            tx_intervalo.MaxLength = 60;
            tx_intervalo.Name = "tx_intervalo";
            tx_intervalo.Size = new Size(71, 23);
            tx_intervalo.TabIndex = 5;
            // 
            // tx_al
            // 
            tx_al.Location = new Point(179, 31);
            tx_al.Name = "tx_al";
            tx_al.Size = new Size(71, 23);
            tx_al.TabIndex = 4;
            // 
            // tx_del
            // 
            tx_del.Location = new Point(50, 31);
            tx_del.Name = "tx_del";
            tx_del.Size = new Size(71, 23);
            tx_del.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(267, 34);
            label14.Name = "label14";
            label14.Size = new Size(135, 15);
            label14.TabIndex = 2;
            label14.Text = "Intervalo de Generación:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(152, 34);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 1;
            label13.Text = "Al:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 34);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 0;
            label12.Text = "Del:";
            // 
            // b_salir
            // 
            b_salir.Location = new Point(556, 482);
            b_salir.Name = "b_salir";
            b_salir.Size = new Size(75, 23);
            b_salir.TabIndex = 1;
            b_salir.Text = "Salir";
            b_salir.UseVisualStyleBackColor = true;
            b_salir.Click += b_salir_Click;
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 523);
            Controls.Add(b_salir);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = " Controles";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button b_salir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button b_limpiar;
        private Button b_calcular;
        private Label label1;
        private TextBox tx_limite;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox tx_resultado_impares;
        private TextBox tx_resultado_pares;
        private Label label3;
        private TextBox tx_impar;
        private TextBox tx_par;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox ckb_no_impar;
        private Label label6;
        private TextBox tx_lim_random;
        private Button b_llenar;
        private Button bo_limpiar;
        private TextBox tx_b1;
        private TextBox tx_a1;
        private Label label7;
        private TextBox tx_c3;
        private TextBox tx_a4;
        private TextBox tx_b4;
        private TextBox tx_resultc;
        private TextBox tx_resultb;
        private TextBox tx_c4;
        private TextBox tx_a3;
        private TextBox tx_b3;
        private TextBox tx_resulta;
        private TextBox tx_c2;
        private TextBox tx_a2;
        private TextBox tx_b2;
        private TextBox tx_c1;
        private TextBox tx_result4;
        private TextBox tx_result3;
        private TextBox tx_result2;
        private TextBox tx_result1;
        private Label label8;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox tx_limite_random;
        private TextBox tx_tamanio_arreglo;
        private Label label10;
        private Label label9;
        private Label label11;
        private GroupBox groupBox7;
        private Button b_descendente;
        private Button b_ascendente;
        private Button b_limpiarr;
        private Button b_llenar_arreglo;
        private CheckBox ckb_no_pares;
        private TextBox tx_contenido;
        private GroupBox groupBox8;
        private Button b_limpiar_timer;
        private Button b_detener;
        private Button b_iniciar;
        private TextBox tx_intervalo;
        private TextBox tx_al;
        private TextBox tx_del;
        private Label label14;
        private Label label13;
        private Label label12;
        private GroupBox groupBox9;
        private TextBox tx_resultado_tabla;
        private System.Windows.Forms.Timer timer;
        private Label label16;
        private Label label15;
        private Label label17;
        private RadioButton rb_todasfilas;
        private RadioButton rb_columna_num;
        private RadioButton rb_fila_num;
        private TextBox tx_fila_num;
        private TextBox tx_columna;
        private RadioButton rb_todas_columnas;
        private Button b_limpiar_resultados;
        private Button b_ver_resultado;
        private RadioButton rb_num_impar;
        private RadioButton rb_ambos;
        private RadioButton rb_num_par;
    }
}