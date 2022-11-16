using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class Consultar_Frases : Form
    {
        public Consultar_Frases()
        {
            InitializeComponent();
        }
        private void Consultar_Frases_Load(object sender, EventArgs e)
        {
            MostrarFrases();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarFrases()
        {
            CN_Frases DG = new CN_Frases();
            tblFrases.DataSource = DG.ListarFrases();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblFrases.SelectedRows.Count > 0)
                {
                    CE_Frases ObjetoCE = new CE_Frases();
                    CN_Frases ObjetoCN = new CN_Frases();
                    ObjetoCE.Ids = tblFrases.CurrentRow.Cells["ID"].Value.ToString();
                    ObjetoCE.Frase = tblFrases.CurrentRow.Cells["FRASE"].Value.ToString();
                    ObjetoCE.Fuente = tblFrases.CurrentRow.Cells["FUENTE"].Value.ToString();
                    ObjetoCE.Idioma = tblFrases.CurrentRow.Cells["IDIOMA"].Value.ToString();

                    ObjetoCN.EditarFrase(ObjetoCE);
                    lblMensaje.ForeColor = Color.LightGreen;
                    lblMensaje.Text = "Frase Actualizada Satisfactoriamente";
                    MostrarFrases();
                }
                else
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Modifique la frase que desea actualizar, y luego presione el botón \"Actualizar Frase\"";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, por favor comunique a su administrado de sistema:" + ex.Message);
            }
        }
    }
}
