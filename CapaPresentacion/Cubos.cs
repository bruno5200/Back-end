using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Cubos : Form
    {
        private CN_Cubos ObjetoCN = new CN_Cubos();
        public Cubos()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            CE_Cubos c = new CE_Cubos();
            c = ObjetoCN.Decodifcar(c);
            string Cubos = string.Empty;
            for (int i = 0; i < (c.Cubos.Length / 8); i++)
            {
                lstCubos.Items.Add($"{c.Cubos[i,0]} {c.Cubos[i,1]} {c.Cubos[i,2]} {c.Cubos[i,3]} {c.Cubos[i,4]} {c.Cubos[i,5]} {c.Cubos[i,6]} {c.Cubos[i,7]}");
            }

        }
    }
}
