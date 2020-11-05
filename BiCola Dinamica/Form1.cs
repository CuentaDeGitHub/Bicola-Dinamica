using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BiCola_Dinamica
{
    public partial class Form1 : Form
    {
        Nodo n;
        Cola MiCola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolarIzq_Click(object sender, EventArgs e)
        {
            try
            {
                n = new Nodo();
                n.Dato = int.Parse(txtDato.Text);
                MiCola.EncolarPorFrente(n);
                lblCola.Text = MiCola.ToString();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Dato no valido");
                txtDato.Clear();
            }
        }

        private void btnEncolarDer_Click(object sender, EventArgs e)
        {
            try
            {
                n = new Nodo();
                n.Dato = int.Parse(txtDato.Text);
                MiCola.EncolarPorFinal(n);
                lblCola.Text = MiCola.ToString();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Dato no valido");
                txtDato.Clear();
            }
        }

        private void btnDesencolarIzq_Click(object sender, EventArgs e)
        {
            MiCola.DesencolarPorFrente();
            lblCola.Text = MiCola.ToString();

        }

        private void btnDesencolarDer_Click(object sender, EventArgs e)
        {
            MiCola.DesencolarPorFinal();
            lblCola.Text = MiCola.ToString();
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dato en el frente: " + MiCola.Front());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            try
            {
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblCola.Text;
                    string nombreDelArchivo;
                    if(txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
                    }
                    else
                    {
                        nombreDelArchivo = txtArchivo.Text;
                    }
                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo "+ nombreDelArchivo + ".txt");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    MiCola.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        MiCola.EncolarPorFinal(n);
                        lblCola.Text = MiCola.ToString();
                        contador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar el archivo");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
