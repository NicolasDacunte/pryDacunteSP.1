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

namespace pryDacunteSP._1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("miArchivito", false);
                MessageBox.Show("Archivo Creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal Error:" +ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("miArchivito", true);
                swManejoArchivo.WriteLine(txtDatos.Text);
                swManejoArchivo.Close();

                MessageBox.Show("Almacenado");
                txtDatos.Text = " ";
                txtDatos.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader swManejoArchivo = new StreamReader("miArchivito");
                while (swManejoArchivo.EndOfStream == false)
                {
                    txtDatos.Text += swManejoArchivo.ReadLine() + Environment.NewLine;
                }
                swManejoArchivo.Close();
                txtDatos.Text = " ";
                txtDatos.Focus();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Fatal Error" + ex.Message);
            }
            
        }
    }
}
