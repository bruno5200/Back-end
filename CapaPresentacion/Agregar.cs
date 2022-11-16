using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            ListarIdiomas();
        }

        private  void ListarIdiomas()
        {
            CN_Frases objetoCN = new CN_Frases();
            cmbIdioma.DataSource = objetoCN.ListarIdiomas();
            cmbIdioma.DisplayMember = "idioma";
            cmbIdioma.ValueMember = "idioma_id";
        }

        private void btnRebuild_Click(object sender, EventArgs e)
        {
            CN_Frases objetoCN = new CN_Frases();
            CE_Frases f = new CE_Frases();
            f.IdiomaID = Convert.ToInt32(cmbIdioma.SelectedValue);
            for (int i = 1; i <= 1000; i++)
            {
                f.Idi = i;
                f = objetoCN.CargarFrase(f);
                objetoCN.Rebuild(f);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Frases objetoCN = new CN_Frases();
            CE_Frases f = new CE_Frases();
            f.IdiomaID = Convert.ToInt32(cmbIdioma.SelectedValue);
            objetoCN.Frases(f);
            /* // Éste solamente funciona con el Text Box
            if (txtFrase.Text != String.Empty)
            {
                int idioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                objetoCN.InsertarFrases(idioma, txtFrase.Text);
                txtFrase.Clear();
            }
            else
                lblAlerta.Text = "Alerta: debe introducir la frase que desee añadir";*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
