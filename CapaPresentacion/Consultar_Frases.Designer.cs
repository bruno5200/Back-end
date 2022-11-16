namespace CapaPresentacion
{
    partial class Consultar_Frases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Frases));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tblFrases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFrases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1071, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 47;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.lblMensaje);
            this.pnlSuperior.Controls.Add(this.btnActualizar);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1100, 76);
            this.pnlSuperior.TabIndex = 49;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Lime;
            this.lblMensaje.Location = new System.Drawing.Point(277, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 23);
            this.lblMensaje.TabIndex = 49;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnActualizar.Location = new System.Drawing.Point(12, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(250, 50);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Editar Frase";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tblFrases);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 76);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1100, 618);
            this.pnlData.TabIndex = 50;
            // 
            // tblFrases
            // 
            this.tblFrases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblFrases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFrases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFrases.Location = new System.Drawing.Point(0, 0);
            this.tblFrases.Margin = new System.Windows.Forms.Padding(0);
            this.tblFrases.Name = "tblFrases";
            this.tblFrases.Size = new System.Drawing.Size(1100, 618);
            this.tblFrases.TabIndex = 49;
            // 
            // Consultar_Frases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1100, 694);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_Frases";
            this.Text = "Consultar_Frases";
            this.Load += new System.EventHandler(this.Consultar_Frases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblFrases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView tblFrases;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMensaje;
    }
}