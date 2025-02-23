namespace ARBOL_3
{
    public partial class form1 : Form
    {
        Nodo raiz;
        Nodo seleccionado;

        public form1()
        {
            InitializeComponent();

            treeView1.AfterSelect += vistaArbolSeleccion;

            // Inicializar ListBox de selección de recorrido
            listBoxSeleccion.Items.Add("Preorden");
            listBoxSeleccion.Items.Add("Inorden");
            listBoxSeleccion.Items.Add("Postorden");
            listBoxSeleccion.SelectedIndexChanged += listBoxSeleccion_SelectedIndexChanged;
        }

        private void listBoxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ListBox de resultados
            listBoxResultado.Items.Clear();

            // Realizar el recorrido según la selección
            string recorridoSeleccionado = listBoxSeleccion.SelectedItem.ToString();
            if (recorridoSeleccionado == "Preorden")
            {
                ListarPreOrden(raiz);
            }
            else if (recorridoSeleccionado == "Inorden")
            {
                ListarInOrden(raiz);
            }
            else if (recorridoSeleccionado == "Postorden")
            {
                ListarPostOrden(raiz);
            }
        }

        private void vistaArbolSeleccion(object sender, TreeViewEventArgs arbol)
        {
            Nodo nodoselec = arbol.Node.Tag as Nodo;
            cambiarSeleccion(nodoselec);
        }

        Nodo crearNodo()
        {
            string nombre = textBox1.Text;
            return new Nodo(nombre);
        }

        void ListarPreOrden(Nodo N)
        {
            if (N == null)
                return;

            // Agregar el nodo actual al ListBox
            listBoxResultado.Items.Add(N.Nombre);

            ListarPreOrden(N.Izquierda);
            ListarPreOrden(N.Derecha);
        }

        void ListarInOrden(Nodo N)
        {
            if (N == null)
                return;

            ListarInOrden(N.Izquierda);

            // Agregar el nodo actual al ListBox
            listBoxResultado.Items.Add(N.Nombre);

            ListarInOrden(N.Derecha);
        }

        void ListarPostOrden(Nodo N)
        {
            if (N == null)
                return;

            ListarPostOrden(N.Izquierda);
            ListarPostOrden(N.Derecha);

            // Agregar el nodo actual al ListBox
            listBoxResultado.Items.Add(N.Nombre);
        }

        void cambiarSeleccion(Nodo N)
        {
            seleccionado = N;
            this.label2.Text = "Nodo Seleccionado" + N.Nombre;
        }

        public void listarArbol()
        {
            treeView1.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            treeView1.ExpandAll();
        }

        void MostrarNodo(Nodo N, TreeNode tnpadre, string lado)
        {
            if (N == null)
                return;

            TreeNode nuevo = new TreeNode();

            if (tnpadre == null && lado == string.Empty)
            {
                tnpadre = new TreeNode();
                nuevo.Text = N.Nombre;
                nuevo.Tag = N;
                treeView1.Nodes.Add(nuevo);
            }
            else
            {
                nuevo.Text = $"{lado} - {N.Nombre}";
                nuevo.Tag = N;
                tnpadre.Nodes.Add(nuevo);
            }

            if (N.Derecha != null)
            {
                MostrarNodo(N.Derecha, nuevo, "D");
            }
            if (N.Izquierda != null)
            {
                MostrarNodo(N.Izquierda, nuevo, "I");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void treeView4_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (raiz == null)
                {
                    raiz = crearNodo();
                    textBox1.Clear();
                }
                else
                {
                    if (radioButtonDerecha.Checked || radioButtonIzquierda.Checked)
                    {
                        if (seleccionado != null)
                        {
                            if (radioButtonDerecha.Checked)
                                seleccionado.Derecha = crearNodo();
                            if (radioButtonIzquierda.Checked)
                                seleccionado.Izquierda = crearNodo();

                            textBox1.Clear();
                            listarArbol();
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un Nodo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un lado");
                    }
                }

                cambiarSeleccion(raiz);
                listarArbol();
                EvaluarArbol();
            }
            else
            {
                MessageBox.Show("Debe ingresar el valor del Nodo");
                textBox1.Focus();
            }
        }

        void EvaluarArbol()
        {
            this.label3.Text = $"Altura: {Alto(raiz)}";
            int inicio = 0;
            this.label4.Text = $"Ancho: {Ancho(raiz, ref inicio)}";
        }

        int Alto(Nodo N)
        {
            if (N == null)
                return 0;
            int izqu = Alto(N.Izquierda) + 1;
            int der = Alto(N.Derecha) + 1;
            return Math.Max(izqu, der);
        }

        int Ancho(Nodo N, ref int ancho)
        {
            if (N == null) return ancho;
            Ancho(N.Izquierda, ref ancho);
            Ancho(N.Derecha, ref ancho);
            return ancho + 1;
        }
    }
}
