namespace PracticoRecursividad1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSerie1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerie2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplos = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNummul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMultiplo5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.txtCuadrada = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFsuma = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(288, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Practico 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.\tUn procedimiento recursivo para mostrar los números pares entre 1 y n.";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(16, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(266, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(675, 9);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(216, 342);
            this.lstResultados.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "2.\tUn procedimiento para mostrar los primeros n términos de la siguiente serie: 1" +
    ", 4, 9, 16, 25, 36,…";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Location = new System.Drawing.Point(288, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSerie1
            // 
            this.txtSerie1.Location = new System.Drawing.Point(16, 113);
            this.txtSerie1.Name = "txtSerie1";
            this.txtSerie1.Size = new System.Drawing.Size(266, 20);
            this.txtSerie1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(638, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "3.\tUna función para calcular la suma de los primeros n términos de la siguiente s" +
    "erie: 10, 2, 30, 4, 50, 6…  ; Ejem. Si n=3, la suma es: 42";
            // 
            // txtSerie2
            // 
            this.txtSerie2.Location = new System.Drawing.Point(16, 161);
            this.txtSerie2.Name = "txtSerie2";
            this.txtSerie2.Size = new System.Drawing.Size(266, 20);
            this.txtSerie2.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Location = new System.Drawing.Point(288, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "4.\tUn procedimiento para mostrar los primeros N múltiplos de X.  Ejemplo: Si N=4 " +
    "y X=7, se mostrará: 7, 14, 21, 28";
            // 
            // txtMultiplos
            // 
            this.txtMultiplos.Location = new System.Drawing.Point(161, 208);
            this.txtMultiplos.Name = "txtMultiplos";
            this.txtMultiplos.Size = new System.Drawing.Size(121, 20);
            this.txtMultiplos.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button5.Location = new System.Drawing.Point(288, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Mostrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNummul
            // 
            this.txtNummul.Location = new System.Drawing.Point(16, 208);
            this.txtNummul.Name = "txtNummul";
            this.txtNummul.Size = new System.Drawing.Size(139, 20);
            this.txtNummul.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Multiplos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(498, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "5.\tPara calcular el máximo común divisor de dos números enteros puedo aplicar el " +
    "algoritmo de Euclides, ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(24, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(480, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "que consiste en ir restando el número más pequeño del más grande hasta que queden" +
    " dos números ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(24, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "iguales, que  serán el máximo común divisor de los dos números. ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(19, 296);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(124, 20);
            this.txtNum1.TabIndex = 22;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(149, 296);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(133, 20);
            this.txtNum2.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button6.Location = new System.Drawing.Point(288, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Mostrar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Numero 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Numero 2";
            // 
            // txtMultiplo5
            // 
            this.txtMultiplo5.Location = new System.Drawing.Point(19, 357);
            this.txtMultiplo5.Name = "txtMultiplo5";
            this.txtMultiplo5.Size = new System.Drawing.Size(263, 20);
            this.txtMultiplo5.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(12, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(412, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "6.\tUn procedimiento para inicializar un vector v de dimensión n, con los múltiplo" +
    "s de 5. ";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button7.Location = new System.Drawing.Point(288, 355);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "Mostrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(13, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "7.\tUna función para sumar los elementos del vector.";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(19, 400);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(182, 20);
            this.txt7.TabIndex = 32;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button8.Location = new System.Drawing.Point(288, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 33;
            this.button8.Text = "Sumar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button9.Location = new System.Drawing.Point(207, 398);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 34;
            this.button9.Text = "Cargar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(16, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(315, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "8.\tUna función para determinar si existe un número X en el vector.";
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(19, 447);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(263, 20);
            this.txt8.TabIndex = 36;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button10.Location = new System.Drawing.Point(288, 447);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 37;
            this.button10.Text = "Buscar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(294, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(315, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "8.\tUna función para determinar si existe un número X en el vector.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(16, 478);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(451, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "9.\tUn procedimiento para contar cuantos elementos cero, tiene una matriz A de dim" +
    "ensión m*n.";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(19, 510);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(83, 20);
            this.txtColumnas.TabIndex = 40;
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(118, 510);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(83, 20);
            this.txtFilas.TabIndex = 41;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button11.Location = new System.Drawing.Point(207, 510);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 42;
            this.button11.Text = "Cargar";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button12.Location = new System.Drawing.Point(287, 510);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 43;
            this.button12.Text = "Contar 0\'s";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 533);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Columnas";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 533);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Filas";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(12, 491);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(421, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "10.\tUn procedimiento para sumar todos los elementos de una matriz A de dimensión " +
    "m*n.";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button13.Location = new System.Drawing.Point(368, 510);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 47;
            this.button13.Text = "Sumar";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(675, 391);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(216, 142);
            this.dgvTabla.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(12, 555);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(718, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "11.\tElaborar un procedimiento para inicializar una matriz cuadrada, donde la diag" +
    "onal principal y secundaria almacenen 1 y las demás celdas con cero.  ";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button14.Location = new System.Drawing.Point(234, 572);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 50;
            this.button14.Text = "Diagonalizar";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtCuadrada
            // 
            this.txtCuadrada.HideSelection = false;
            this.txtCuadrada.Location = new System.Drawing.Point(19, 574);
            this.txtCuadrada.Name = "txtCuadrada";
            this.txtCuadrada.Size = new System.Drawing.Size(83, 20);
            this.txtCuadrada.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(115, 576);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "Dimension cuadrada";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(12, 598);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(410, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "12.\tRealizar una función recursiva para sumar los elementos de la fila k de una m" +
    "atriz. ";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtFsuma
            // 
            this.txtFsuma.HideSelection = false;
            this.txtFsuma.Location = new System.Drawing.Point(19, 621);
            this.txtFsuma.Name = "txtFsuma";
            this.txtFsuma.Size = new System.Drawing.Size(83, 20);
            this.txtFsuma.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(115, 621);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "Dimension cuadrada";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button15.Location = new System.Drawing.Point(234, 618);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 56;
            this.button15.Text = "sumar Fila";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 653);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtFsuma);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCuadrada);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMultiplo5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNummul);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtMultiplos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSerie2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSerie1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSerie1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerie2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNummul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMultiplo5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtCuadrada;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFsuma;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button15;
    }
}

