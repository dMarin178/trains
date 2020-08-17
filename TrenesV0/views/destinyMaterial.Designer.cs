namespace TrenesV0.views
{
    partial class destinyMaterial
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
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(41, 84);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 0;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(85, 45);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 2;
            this.lblMaterial.Text = "Material ";
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(65, 139);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(81, 39);
            this.btnListo.TabIndex = 3;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            // 
            // destinyMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 239);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmbDestino);
            this.Name = "destinyMaterial";
            this.Text = "destinyMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnListo;
    }
}