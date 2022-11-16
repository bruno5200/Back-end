using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Frases : Form
    {
        public Frases()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bartittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(49, 66, 92)); //45; 125; 154 o 64;64;64 o 49; 66; 92
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.DeepSkyBlue, sizeGripRectangle); // or color.Transparent
        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si el Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Agregar"] == null)
                btnAgregar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Consultar_Frases"] == null)
                btnFrases.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Jugar"] == null)
                btnJugar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Cubos"] == null)
                btnCubos.BackColor = Color.FromArgb(4, 41, 68);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Agregar>();
        }
        private void btnFrases_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Consultar_Frases>();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Jugar>();
        }

        private void btnCubos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Cubos>();
        }
    }
}
