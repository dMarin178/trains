namespace TrenesV0.views
{
    partial class Menu
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
            this.bntCrearViaje = new System.Windows.Forms.Button();
            this.btnAddMaterialRodante = new System.Windows.Forms.Button();
            this.btnEditMaterialRodante = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.imgEstaciones = new System.Windows.Forms.PictureBox();
            this.viajesActuales_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bntCrearViaje
            // 
            this.bntCrearViaje.Location = new System.Drawing.Point(12, 256);
            this.bntCrearViaje.Name = "bntCrearViaje";
            this.bntCrearViaje.Size = new System.Drawing.Size(131, 49);
            this.bntCrearViaje.TabIndex = 0;
            this.bntCrearViaje.Text = "Crear Viaje";
            this.bntCrearViaje.UseVisualStyleBackColor = true;
            this.bntCrearViaje.Click += new System.EventHandler(this.bntCrearViaje_Click);
            // 
            // btnAddMaterialRodante
            // 
            this.btnAddMaterialRodante.Location = new System.Drawing.Point(149, 256);
            this.btnAddMaterialRodante.Name = "btnAddMaterialRodante";
            this.btnAddMaterialRodante.Size = new System.Drawing.Size(131, 49);
            this.btnAddMaterialRodante.TabIndex = 6;
            this.btnAddMaterialRodante.Text = "Agregar Material Rodante";
            this.btnAddMaterialRodante.UseVisualStyleBackColor = true;
            this.btnAddMaterialRodante.Click += new System.EventHandler(this.btnAddMaterialRodante_Click);
            // 
            // btnEditMaterialRodante
            // 
            this.btnEditMaterialRodante.Location = new System.Drawing.Point(286, 256);
            this.btnEditMaterialRodante.Name = "btnEditMaterialRodante";
            this.btnEditMaterialRodante.Size = new System.Drawing.Size(131, 49);
            this.btnEditMaterialRodante.TabIndex = 7;
            this.btnEditMaterialRodante.Text = "Editar Material Rodante";
            this.btnEditMaterialRodante.UseVisualStyleBackColor = true;
            this.btnEditMaterialRodante.Click += new System.EventHandler(this.btnEditMaterialRodante_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(216, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(423, 256);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(131, 49);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Gestionar Usuarios";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // imgEstaciones
            // 
            this.imgEstaciones.Image = global::TrenesV0.Properties.Resources.placeholder_estaciones;
            this.imgEstaciones.Location = new System.Drawing.Point(12, 43);
            this.imgEstaciones.Name = "imgEstaciones";
            this.imgEstaciones.Size = new System.Drawing.Size(197, 162);
            this.imgEstaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstaciones.TabIndex = 12;
            this.imgEstaciones.TabStop = false;
            // 
            // viajesActuales_label
            // 
            this.viajesActuales_label.AutoSize = true;
            this.viajesActuales_label.Location = new System.Drawing.Point(274, 43);
            this.viajesActuales_label.Name = "viajesActuales_label";
            this.viajesActuales_label.Size = new System.Drawing.Size(82, 13);
            this.viajesActuales_label.TabIndex = 13;
            this.viajesActuales_label.Text = "Viajes Actuales:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 422);
            this.Controls.Add(this.viajesActuales_label);
            this.Controls.Add(this.imgEstaciones);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditMaterialRodante);
            this.Controls.Add(this.btnAddMaterialRodante);
            this.Controls.Add(this.bntCrearViaje);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgEstaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCrearViaje;
        private System.Windows.Forms.Button btnAddMaterialRodante;
        private System.Windows.Forms.Button btnEditMaterialRodante;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.PictureBox imgEstaciones;
        private System.Windows.Forms.Label viajesActuales_label;
    }
}