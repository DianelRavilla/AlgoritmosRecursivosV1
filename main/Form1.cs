using System;
using System.Windows.Forms;

namespace PracticoRecursividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            dgvTabla.Rows.Clear();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            bool resultado = int.TryParse(txtNumero.Text, out n);
            if (resultado == true)
                MostrarPares(n);
            else
                MessageBox.Show("Dato Incorrecto");

        }

        void MostrarPares(int n)
        {
            if (n < 2)
                lstResultados.Items.Add("0");
            else
            {
                if (n % 2 == 0)
                {
                    MostrarPares(n - 1);
                    lstResultados.Items.Add(n);                   
                }
                else
                {
                    MostrarPares(n - 1);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            bool resultado = int.TryParse(txtSerie1.Text, out n);
            if (resultado == true)
                SeriePotencias(n);
            else
                MessageBox.Show("Dato Incorrecto");
        }

        void SeriePotencias(int n)
        {
            if (n == 1)
                lstResultados.Items.Add("1");
            else
            {
                SeriePotencias(n - 1);
                lstResultados.Items.Add(n * n);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n;
            int s = 0;
            bool resultado = int.TryParse(txtSerie2.Text, out n);
            if (resultado == true)
                sumarTerminos(n, s);
            else
                MessageBox.Show("Dato Incorrecto");
        }

        void sumarTerminos(int n, int s)
        {
            if (n == 0)
                lstResultados.Items.Add(s);
            else
            {
                if (n % 2 != 0)
                {
                    s = s + (n * 10);
                    sumarTerminos(n - 1, s);
                }
                else
                {
                    s = s + n;
                    sumarTerminos(n - 1, s);
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n, x;
            bool resultado1 = int.TryParse(txtNummul.Text, out n);
            bool resultado2 = int.TryParse(txtMultiplos.Text, out x);
            if (resultado1 == true & resultado2 == true)
                multiplos(n, x);
            else
                MessageBox.Show("Dato Incorrecto");
        }
        void multiplos(int n, int x)
        {
            if (x == 1 || x == 0)
            {
                lstResultados.Items.Add(n);
            }
            else
            {
                multiplos(n, x - 1);
                lstResultados.Items.Add(x * n);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b;
            bool resultado1 = int.TryParse(txtNum1.Text, out a);
            bool resultado2 = int.TryParse(txtNum2.Text, out b);
            if (resultado1 == true & resultado2 == true)
                Minimocomun(a, b);
            else
                MessageBox.Show("Dato Incorrecto");
        }

        void Minimocomun(int a, int b)
        {
            if (a == b)
            {
                lstResultados.Items.Add(a);
            }
            else
            {
                if (b < a)
                {
                    Minimocomun(a - b, b);
                }
                else
                {
                    Minimocomun(a, b - a);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n;
            bool resultado = int.TryParse(txtMultiplo5.Text, out n);
            int[] vec;
            vec = new int[n];
            if (resultado == true)
                Vectormultiplo5(n, vec);
            else
                MessageBox.Show("Dato Incorrecto");
        }

        void Vectormultiplo5(int n, int[] vec)
        {
            if (n == 1)
            {
                vec[0] = n * 5;
                lstResultados.Items.Add(vec[0]);
            }
            else
            {
                Vectormultiplo5(n - 1, vec);
                vec[n - 1] = n * 5;
                lstResultados.Items.Add(vec[n - 1]);
            }
        }

        int[] vecsum;
        int n;
        int b;
        private void button9_Click(object sender, EventArgs e)
        {
            bool resultado = int.TryParse(txt7.Text, out n);
            vecsum = new int[n];
            b = n;
            cargarvector(vecsum, n);
        }

        Random semilla = new Random();
        void cargarvector(int[] vecsum, int n)
        {
            if (n == 1)
            {
                vecsum[0] = semilla.Next(1, 100);
                lstResultados.Items.Add(vecsum[0]);
            }
            else
            {
                cargarvector(vecsum, n - 1);
                vecsum[n - 1] = semilla.Next(1, 100);
                lstResultados.Items.Add(vecsum[n - 1]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int resultado;
            int n = Convert.ToInt32(txt7.Text);
            resultado = sumarvector(n);
            lstResultados.Items.Add("===============");
            lstResultados.Items.Add(resultado);
        }

        private int sumarvector(int n)
        {
            if (n == 1)
                return (vecsum[0]);
            else
            {
                int resultado = sumarvector(n - 1) + vecsum[n - 1];
                return resultado;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt8.Text);
            buscar(x, vecsum, b);
        }

        void buscar(int x, int[] vecsum, int b)
        {
            if (b > 1)
            {
                if (vecsum[b - 1] == x)
                {
                    lstResultados.Items.Add("Si existe y se encuentra en la poscision: " + b);
                }
                else
                {
                    buscar(x, vecsum, b - 1);
                }
            }
            else
            {
                lstResultados.Items.Add("No existe el elemento en el vector");
            }
        }

        int[,] matriz;
        int columnas;
        int filas;
        int MAXIMO = 20;
        private void button11_Click(object sender, EventArgs e)
        {
            fc = 0;
            cc = 0;
            filas = Convert.ToInt32(txtFilas.Text);
            columnas = Convert.ToInt32(txtColumnas.Text);            
            if (filas >= 1 && columnas >= 1 && filas <= MAXIMO && columnas <= MAXIMO)
            {
                matriz = new int[filas, columnas];      //se puede crear una condicion IF antes de declarar la matriz
                Inicializar(matriz, filas, columnas);
                mostrar(matriz, filas, columnas);
            }
        }
        void Inicializar(int[,] mat, int filas, int columnas)
        {

            recorrerPorFilas(mat, filas - 1, columnas - 1);
        }

        private void recorrerPorFilas(int[,] mat, int f, int c)
        {
            if (f >= 0)
            {
                recorrerPorFilas(mat, f - 1, c);
                recorrerPorColumnas(mat, f, c);
            }
        }

        private void recorrerPorColumnas(int[,] mat, int f, int c)
        {
            if (c == 0)
                mat[f, c] = semilla.Next(0, 10);
            else
            {
                recorrerPorColumnas(mat, f, c - 1);
                mat[f, c] = semilla.Next(0, 10);
            }
        }

        void mostrar(int[,] mat, int filas, int columnas)
        {
            dgvTabla.RowCount = filas;
            dgvTabla.ColumnCount = columnas;
            reducirCeldas();
            mostrarPorFilas(mat, filas - 1, columnas - 1);
        }

        void reducirCeldas()
        {
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
            {
                dgvTabla.Columns[i].Width = 30;
            }
        }

        void mostrarPorFilas(int[,] mat, int f, int c)
        {
            if (f >= 0)
            {
                mostrarPorFilas(mat, f - 1, c);
                mostrarPorColumnas(mat, f, c);
            }

        }

        int fc = 0;
        int cc = 0;

        void mostrarPorColumnas(int[,] mat, int f, int c)
        {
            if (c == 0)
            {
                dgvTabla.Rows[f].Cells[c].Value = mat[f, c];
                cc = cc + mat[f, c];                  
            }
            else
            {
                mostrarPorColumnas(mat, f, c - 1);
                dgvTabla.Rows[f].Cells[c].Value = mat[f, c];
                cc = cc + mat[f, c];
            }
            if (matriz[f, c]==0)
            {
                fc++;
            }
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add("hay " + fc + " veces repetidas del numero 0 en la matriz");
        }

        private void button13_Click(object sender, EventArgs e)      
        {
            lstResultados.Items.Add("La suma de los elementos de la matriz es: " + cc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            filas = Convert.ToInt32(txtCuadrada.Text);
            columnas = Convert.ToInt32(txtCuadrada.Text);
            if (filas >= 1 && columnas >= 1 && filas <= MAXIMO && columnas <= MAXIMO)
            {
                matriz = new int[filas, columnas];       
                Diagonal(matriz, filas, columnas);
                mostrard(matriz, filas, columnas);
            }
        }
        void Diagonal(int[,] mat, int filas, int columnas)
        {
            recorrerPorFilasd(mat, filas - 1, columnas - 1);
        }

        private void recorrerPorFilasd(int[,] mat, int f, int c)
        {
            if (f >= 0)
            {
                recorrerPorFilasd(mat, f - 1, c);
                recorrerPorColumnasd(mat, f, c);
            }
        }

        private void recorrerPorColumnasd(int[,] mat, int f, int c)
        {
            if (c == 0)
            {
                if (f == c || f + c == columnas - 1)
                {
                    mat[f, c] = 1;
                }
                else
                {
                    mat[f, c] = 0;
                }
            }
            else
            {
                recorrerPorColumnasd(mat, f, c - 1);
                if (f == c || f + c == columnas - 1)
                {
                    mat[f, c] = 1;
                }
                else
                {
                    mat[f, c] = 0;
                }
            }
        }

        void mostrard(int[,] mat, int filas, int columnas)
        {
            dgvTabla.RowCount = filas;
            dgvTabla.ColumnCount = columnas;
            reducirCeldasd();
            mostrarPorFilasd(mat, filas - 1, columnas - 1);
        }

        void reducirCeldasd()
        {
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
            {
                dgvTabla.Columns[i].Width = 30;
            }
        }

        void mostrarPorFilasd(int[,] mat, int f, int c)
        {
            if (f >= 0)
            {
                mostrarPorFilasd(mat, f - 1, c);
                mostrarPorColumnasd(mat, f, c);
            }

        }

        void mostrarPorColumnasd(int[,] mat, int f, int c)
        {
            if (c == 0)
            {
                dgvTabla.Rows[f].Cells[c].Value = mat[f, c];
            }
            else
            {
                mostrarPorColumnasd(mat, f, c - 1);
                dgvTabla.Rows[f].Cells[c].Value = mat[f, c];
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        int filasuma;
        int sfila;
        private void button15_Click(object sender, EventArgs e)
        {
            filasuma = Convert.ToInt32(txtFsuma.Text);
            sfila = 0;
            if (filasuma <= filas)
            {
                sfilas(matriz, filas - 1, columnas - 1);
                sfila = sfila / filas;
                lstResultados.Items.Add("La sumatoria de la fila " + filasuma + " es : " + sfila);
            }
            else
            {
                MessageBox.Show("Fila fuera de la matriz");
            }
        }
        private void sfilas(int[,] mat, int f, int c)
        {
            if (f >= 0)
            {
                sfilas(mat, f - 1, c);
                scolumna(mat, f, c);
            }
        }
        private void scolumna(int[,] mat, int f, int c)
        {
            if (c == 0)
            {
                sfila = sfila + mat[filasuma - 1, c];
            }

            else
            {
                scolumna(mat, f, c - 1);
                sfila = sfila + mat[filasuma - 1, c];
            }
        }
    }
}
