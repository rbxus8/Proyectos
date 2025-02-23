namespace ARBOL_3
{
    partial class form1
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
            groupBox1 = new GroupBox();
            radioButtonIzquierda = new RadioButton();
            radioButtonDerecha = new RadioButton();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            treeView1 = new TreeView();
            buttonAgregar = new Button();
            Salir = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBoxSeleccion = new ListBox();
            listBoxResultado = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonIzquierda);
            groupBox1.Controls.Add(radioButtonDerecha);
            groupBox1.Location = new Point(171, 62);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rama";
            // 
            // radioButtonIzquierda
            // 
            radioButtonIzquierda.AutoSize = true;
            radioButtonIzquierda.Location = new Point(25, 59);
            radioButtonIzquierda.Margin = new Padding(3, 2, 3, 2);
            radioButtonIzquierda.Name = "radioButtonIzquierda";
            radioButtonIzquierda.Size = new Size(73, 19);
            radioButtonIzquierda.TabIndex = 1;
            radioButtonIzquierda.TabStop = true;
            radioButtonIzquierda.Text = "Izquierda";
            radioButtonIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioButtonDerecha
            // 
            radioButtonDerecha.AutoSize = true;
            radioButtonDerecha.Location = new Point(25, 27);
            radioButtonDerecha.Margin = new Padding(3, 2, 3, 2);
            radioButtonDerecha.Name = "radioButtonDerecha";
            radioButtonDerecha.Size = new Size(68, 19);
            radioButtonDerecha.TabIndex = 0;
            radioButtonDerecha.TabStop = true;
            radioButtonDerecha.Text = "Derecha";
            radioButtonDerecha.UseVisualStyleBackColor = true;
            radioButtonDerecha.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(171, 211);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(230, 119);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 64);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Ancho";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 49);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Altura";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 27);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 0;
            label2.Text = "Nodo seleccionado";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(21, 9);
            treeView1.Margin = new Padding(3, 2, 3, 2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(132, 302);
            treeView1.TabIndex = 2;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(293, 28);
            buttonAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(108, 22);
            buttonAgregar.TabIndex = 3;
            buttonAgregar.Text = "Agregar Nodo";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(171, 169);
            Salir.Margin = new Padding(3, 2, 3, 2);
            Salir.Name = "Salir";
            Salir.Size = new Size(82, 22);
            Salir.TabIndex = 4;
            Salir.Text = "SALIR";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "NODO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 28);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 6;
            // 
            // listBoxSeleccion
            // 
            listBoxSeleccion.FormattingEnabled = true;
            listBoxSeleccion.ItemHeight = 15;
            listBoxSeleccion.Location = new Point(544, 28);
            listBoxSeleccion.Name = "listBoxSeleccion";
            listBoxSeleccion.Size = new Size(120, 49);
            listBoxSeleccion.TabIndex = 13;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.ItemHeight = 15;
            listBoxResultado.Location = new Point(544, 89);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(120, 229);
            listBoxResultado.TabIndex = 14;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 375);
            Controls.Add(listBoxResultado);
            Controls.Add(listBoxSeleccion);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Salir);
            Controls.Add(buttonAgregar);
            Controls.Add(treeView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "form1";
            Text = "Form1";
            Load += Agregar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TreeView treeView1;
        private Button buttonAgregar;
        private Button Salir;
        private RadioButton radioButtonIzquierda;
        private RadioButton radioButtonDerecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBoxSeleccion;
        private ListBox listBoxResultado;
    }
}
