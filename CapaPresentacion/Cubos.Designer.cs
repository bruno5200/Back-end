namespace CapaPresentacion
{
    partial class Cubos
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtCubos = new System.Windows.Forms.TextBox();
            this.lstCubos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRun.Location = new System.Drawing.Point(163, 625);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(880, 40);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtCubos
            // 
            this.txtCubos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCubos.Location = new System.Drawing.Point(163, 161);
            this.txtCubos.Multiline = true;
            this.txtCubos.Name = "txtCubos";
            this.txtCubos.Size = new System.Drawing.Size(880, 441);
            this.txtCubos.TabIndex = 4;
            this.txtCubos.Visible = false;
            // 
            // lstCubos
            // 
            this.lstCubos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCubos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCubos.FormattingEnabled = true;
            this.lstCubos.ItemHeight = 37;
            this.lstCubos.Location = new System.Drawing.Point(163, 156);
            this.lstCubos.Name = "lstCubos";
            this.lstCubos.Size = new System.Drawing.Size(880, 411);
            this.lstCubos.TabIndex = 5;
            // 
            // Cubos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1206, 762);
            this.Controls.Add(this.lstCubos);
            this.Controls.Add(this.txtCubos);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cubos";
            this.Text = "Cubos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtCubos;
        private System.Windows.Forms.ListBox lstCubos;
    }
}