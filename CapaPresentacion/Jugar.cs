using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Jugar : Form
    {
        CN_Frases ObjetoCN = new CN_Frases();
        CE_Frases ObjetoCE = new CE_Frases();
        private CE_Frases f = new CE_Frases();
        private int n = 0;
        private int C = 0, x = 0, y = 0;
        private string[] casillas = new string[120];
        public Jugar()
        {
            InitializeComponent();
            ListarIdiomas();
            ListarFrases();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListarIdiomas()
        {
            cmbIdioma.DataSource = ObjetoCN.ListarIdiomas();
            cmbIdioma.DisplayMember = "idioma";
            cmbIdioma.ValueMember = "idioma_id";
        }
        private void ListarFrases()
        {
            ObjetoCE.IdiomaID = 1;
            cmbFrase.DataSource = ObjetoCN.ListarFrasesIdioma(ObjetoCE);
            cmbFrase.DisplayMember = "frase_id";
            cmbFrase.ValueMember = "frase_id";
            cmbFrase.Enabled = true;
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            f.IdiomaID = cmbIdioma.SelectedIndex + 1;
            f.Idi = cmbFrase.SelectedIndex + 1;
            f = ObjetoCN.CargarFrase(f);
            Reiniciar();
            IniciarJuego(f);
        }
        private void IniciarJuego(CE_Frases f)
        {
            lblNum.Text = Convert.ToString(f.Idi);
            txtFrase.Text = f.Frase;
            txtFuente.Text = f.Fuente;
            n = 0;
            int l = f.Frase.Length, c = f.Fuente.Length, T = 0, t = 0;
            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 11; j++)
                {
                    foreach (Control tmpControl in pnl.Controls)
                    {
                        if ((tmpControl.Name == $"txt{i}x12" || tmpControl.Name == $"txt0{i}x12" || tmpControl.Name == $"txt{i}x13" || tmpControl.Name == $"txt0{i}x13") && ((t < l) || ((t - l) < c)))
                        {
                            tmpControl.Visible = true;
                        }
                        if (tmpControl.Name == $"txt0{i}x0{j}" || tmpControl.Name == $"txt0{i}x{j}" || tmpControl.Name == $"txt{i}x0{j}" || tmpControl.Name == $"txt{i}x{j}")
                        {
                            if (t < l)
                            {
                                tmpControl.Text = f.Frase[t].ToString();
                                if (f.Frase[t] == ' ' || f.Frase[t] == '.' || f.Frase[t] == ',' || f.Frase[t] == '\'' || f.Frase[t] == '"' || f.Frase[t] == '“' || f.Frase[t] == '”' || f.Frase[t] == '-' || f.Frase[t] == '–' || f.Frase[t] == '´' || f.Frase[t] == '‘' || f.Frase[t] == '’' || f.Frase[t] == ';' || f.Frase[t] == ':' || f.Frase[t] == '¿' || f.Frase[t] == '?' || f.Frase[t] == '¡' || f.Frase[t] == '!')
                                {
                                    tmpControl.BackColor = Color.Yellow/*FromArgb(252, 255, 0)*/;
                                }
                                else
                                {
                                    casillas[T] = tmpControl.Name;
                                    T++;
                                    //tmpControl.ForeColor = Color.White;
                                }
                                tmpControl.Visible = true;
                            }
                            else if ((t - l) < c)
                            {
                                tmpControl.Text = f.Fuente[(t - l)].ToString();
                                if (f.Fuente[(t - l)] == ' ' || f.Fuente[(t - l)] == '.' || f.Fuente[(t - l)] == ',' || f.Fuente[(t - l)] == '\'' || f.Fuente[(t - l)] == '"' || f.Fuente[(t - l)] == '“' || f.Fuente[(t - l)] == '”' || f.Fuente[(t - l)] == '-' || f.Fuente[(t - l)] == '–' || f.Fuente[(t - l)] == '´' || f.Frase[(t - l)] == '‘' || f.Frase[(t - l)] == '’' || f.Fuente[(t - l)] == ';' || f.Fuente[(t - l)] == ':' || f.Fuente[(t - l)] == '¿' || f.Fuente[(t - l)] == '?' || f.Fuente[(t - l)] == '¡' || f.Fuente[(t - l)] == '!')
                                {
                                    tmpControl.BackColor = Color.Blue;
                                    tmpControl.ForeColor = Color.White;
                                }
                                else
                                {
                                    tmpControl.BackColor = Color.Blue;
                                    tmpControl.ForeColor = Color.White;
                                }
                                if (tmpControl.Text == "-")
                                    tmpControl.Text = "–";
                                tmpControl.Visible = true;
                            }
                        }
                        else
                        {
                            for (int k = 0; k < f.Letras.Length; k++)
                            {
                                if (tmpControl.Name == $"btn{f.Letras[k]}")
                                {
                                    tmpControl.Enabled = true;
                                }
                                // hay que poner la funcion que deshabilite las letras del teclado
                            }
                        }
                    }
                    t++;
                }
            }
            monkeyOne.Visible = true;
            monkeyTwo.Visible = true;
            monkeyThree.Visible = true;
        }
        private void Reiniciar()
        {
            for (int i = 0; i <= 13; i++)
            {
                for (int j = 0; j <= 11; j++)
                {
                    foreach (Control tmpControl in pnl.Controls)
                    {
                        if (tmpControl.Name == $"txt0{i}x0{j}" || tmpControl.Name == $"txt0{i}x{j}" || tmpControl.Name == $"txt{i}x0{j}" || tmpControl.Name == $"txt{i}x{j}")
                        {
                            tmpControl.BackColor = Color.White;
                            tmpControl.ForeColor = Color.Black;
                            tmpControl.Text = string.Empty;
                            tmpControl.Visible = false;
                        }
                        else if (tmpControl.Name == $"txt{i}x12" || tmpControl.Name == $"txt0{i}x12" || tmpControl.Name == $"txt{i}x13" || tmpControl.Name == $"txt0{i}x13")
                        {
                            tmpControl.Visible = false;
                        }
                    }
                }
            }
            x = 0; y = 0; C = 0;
            monkeyOne.Visible = true;
            monkeyTwo.Visible = true;
            monkeyThree.Visible = true;
        }
        private void letras(string letra)
        {

            if (y == 12)
            {
                y = 0; ++x;
            }
            else
                ++y;
            foreach (Control tmpControl in pnl.Controls)
            {
                if (tmpControl.Name == casillas[n])
                {
                    if (tmpControl.Text == letra)
                    {
                        tmpControl.ForeColor = Color.Black;
                        n++;
                        break;
                    }
                    else if (letra == "A")
                    {
                        if (tmpControl.Text == "Á" || tmpControl.Text == "Â" || tmpControl.Text == "Ä" || tmpControl.Text == "À" || tmpControl.Text == "Ã" || tmpControl.Text == "Ӕ")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "E")
                    {
                        if (tmpControl.Text == "É" || tmpControl.Text == "Ê" || tmpControl.Text == "Ë" || tmpControl.Text == "È" || tmpControl.Text == "Ӕ")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "I")
                    {
                        if (tmpControl.Text == "Í" || tmpControl.Text == "Î" || tmpControl.Text == "Ï" || tmpControl.Text == "Ì")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "O")
                    {
                        if (tmpControl.Text == "Ó" || tmpControl.Text == "Ô" || tmpControl.Text == "Ö" || tmpControl.Text == "Ò" || tmpControl.Text == "Ø")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "U")
                    {
                        if (tmpControl.Text == "Ú" || tmpControl.Text == "Û" || tmpControl.Text == "Ü" || tmpControl.Text == "Ù")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "S") // para el alemám poner la ß
                    {
                        if (tmpControl.Text == "ß")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "C") // para el portugués poner la C
                    {
                        if (tmpControl.Text == "Ç")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else if (letra == "N") // para el español
                    {
                        if (tmpControl.Text == "Ñ")
                        {
                            tmpControl.ForeColor = Color.Black;
                            break;
                        }
                    }
                    else
                    {
                        if (C < 3)
                        {
                            C++;
                        }
                        else
                        {
                            monkeyThree.Visible = false;
                            MessageBox.Show("Has perdido a todos tus monitos.");
                        }
                    }
                    if (C == 1)
                    {
                        monkeyOne.Visible = false;
                    }
                    else if (C == 2)
                    {
                        monkeyTwo.Visible = false;
                    }
                    else if (C == 2)
                    {
                        monkeyThree.Visible = false;
                    }
                }
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            f.Frase = txtFrase.Text;
            f.Fuente = txtFuente.Text;
            ObjetoCN.ModificarBin(f);
            //Reiniciar();
        }
        private void btnq_Click(object sender, EventArgs e)
        {
            letras(btnq.Text);
        }
        private void btnw_Click(object sender, EventArgs e)
        {
            letras(btnw.Text);
        }
        private void btne_Click(object sender, EventArgs e)
        {
            letras(btne.Text);
        }
        private void btnr_Click(object sender, EventArgs e)
        {
            letras(btnr.Text);
        }
        private void btnt_Click(object sender, EventArgs e)
        {
            letras(btnt.Text);
        }
        private void btny_Click(object sender, EventArgs e)
        {
            letras(btny.Text);
        }
        private void btnu_Click(object sender, EventArgs e)
        {
            letras(btnu.Text);
        }
        private void btni_Click(object sender, EventArgs e)
        {
            letras(btni.Text);
        }
        private void btno_Click(object sender, EventArgs e)
        {
            letras(btno.Text);
        }
        private void btnp_Click(object sender, EventArgs e)
        {
            letras(btnp.Text);
        }
        private void btna_Click(object sender, EventArgs e)
        {
            letras(btna.Text);
        }
        private void btns_Click(object sender, EventArgs e)
        {
            letras(btns.Text);
        }
        private void btnd_Click(object sender, EventArgs e)
        {
            letras(btnd.Text);
        }
        private void btnf_Click(object sender, EventArgs e)
        {
            letras(btnf.Text);
        }
        private void btng_Click(object sender, EventArgs e)
        {
            letras(btng.Text);
        }
        private void btnh_Click(object sender, EventArgs e)
        {
            letras(btnh.Text);
        }
        private void btnj_Click(object sender, EventArgs e)
        {
            letras(btnj.Text);
        }
        private void btnk_Click(object sender, EventArgs e)
        {
            letras(btnk.Text);
        }
        private void btnl_Click(object sender, EventArgs e)
        {
            letras(btnl.Text);
        }
        private void btnz_Click(object sender, EventArgs e)
        {
            letras(btnz.Text);
        }
        private void btnx_Click(object sender, EventArgs e)
        {
            letras(btnx.Text);
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            letras(btnc.Text);
        }
        private void btnv_Click(object sender, EventArgs e)
        {
            letras(btnv.Text);
        }
        private void btnb_Click(object sender, EventArgs e)
        {
            letras(btnb.Text);
        }
        private void btnn_Click(object sender, EventArgs e)
        {
            letras(btnn.Text);
        }
        private void btnm_Click(object sender, EventArgs e)
        {
            letras(btnm.Text);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reiniciar();
            IniciarJuego(f);
        }
    }
}

