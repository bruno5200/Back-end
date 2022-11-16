namespace CapaPresentacion
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.lblAlerta = new System.Windows.Forms.Label();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlerta
            // 
            this.lblAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAlerta.Location = new System.Drawing.Point(113, 593);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 20);
            this.lblAlerta.TabIndex = 42;
            // 
            // btnAgragar
            // 
            this.btnAgragar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgragar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnAgragar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnAgragar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgragar.Location = new System.Drawing.Point(110, 620);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(880, 40);
            this.btnAgragar.TabIndex = 39;
            this.btnAgragar.Tag = "Añade a la Base de Datos la Frase  introducida";
            this.btnAgragar.Text = "AGREGAR";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(28, 104);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(69, 19);
            this.lblIdioma.TabIndex = 45;
            this.lblIdioma.Text = "Idioma:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Frase:";
            this.label2.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1068, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 48;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIdioma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(110, 102);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(880, 27);
            this.cmbIdioma.TabIndex = 50;
            // 
            // txtFrase
            // 
            this.txtFrase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrase.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(110, 157);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(880, 378);
            this.txtFrase.TabIndex = 49;
            this.txtFrase.Visible = false;
            // 
            // btnRebuild
            // 
            this.btnRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRebuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRebuild.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnRebuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnRebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebuild.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebuild.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRebuild.Location = new System.Drawing.Point(110, 573);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(880, 40);
            this.btnRebuild.TabIndex = 52;
            this.btnRebuild.Tag = "Añade a la Base de Datos la Frase  introducida";
            this.btnRebuild.Text = "REBUILD";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(465, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 25);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "AÑADIR FRASES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1100, 694);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRebuild);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.btnAgragar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.Label lblTitulo;
    }
}