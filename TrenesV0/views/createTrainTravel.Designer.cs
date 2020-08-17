namespace TrenesV0.views
{
    partial class createTrainRide
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.cmbLocomotora = new System.Windows.Forms.ComboBox();
            this.cmbEstacionOrigen = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbEstacionDestino = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.listAñadidos = new System.Windows.Forms.ListBox();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listDisponibles = new System.Windows.Forms.ListBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Locomotora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Origen";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(107, 374);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(116, 23);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // cmbLocomotora
            // 
            this.cmbLocomotora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocomotora.FormattingEnabled = true;
            this.cmbLocomotora.Location = new System.Drawing.Point(47, 146);
            this.cmbLocomotora.Name = "cmbLocomotora";
            this.cmbLocomotora.Size = new System.Drawing.Size(121, 21);
            this.cmbLocomotora.TabIndex = 10;
            this.cmbLocomotora.SelectedIndexChanged += new System.EventHandler(this.cmbLocomotora_SelectedIndexChanged);
            // 
            // cmbEstacionOrigen
            // 
            this.cmbEstacionOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacionOrigen.FormattingEnabled = true;
            this.cmbEstacionOrigen.Location = new System.Drawing.Point(47, 101);
            this.cmbEstacionOrigen.Name = "cmbEstacionOrigen";
            this.cmbEstacionOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbEstacionOrigen.TabIndex = 9;
            this.cmbEstacionOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbEstacionOrigen_SelectedIndexChanged);
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(47, 57);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 20);
            this.datePick.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Destino";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(368, 101);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(121, 21);
            this.cmbPrioridad.TabIndex = 23;
            // 
            // cmbEstacionDestino
            // 
            this.cmbEstacionDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacionDestino.FormattingEnabled = true;
            this.cmbEstacionDestino.Location = new System.Drawing.Point(368, 57);
            this.cmbEstacionDestino.Name = "cmbEstacionDestino";
            this.cmbEstacionDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbEstacionDestino.TabIndex = 22;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(402, 374);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(116, 23);
            this.btnQuitar.TabIndex = 26;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // listAñadidos
            // 
            this.listAñadidos.FormattingEnabled = true;
            this.listAñadidos.Location = new System.Drawing.Point(368, 234);
            this.listAñadidos.Name = "listAñadidos";
            this.listAñadidos.Size = new System.Drawing.Size(184, 134);
            this.listAñadidos.TabIndex = 27;
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstacion.Enabled = false;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.Location = new System.Drawing.Point(81, 207);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(121, 21);
            this.cmbEstacion.TabIndex = 28;
            this.cmbEstacion.SelectedIndexChanged += new System.EventHandler(this.cmbEstacion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estacion";
            // 
            // listDisponibles
            // 
            this.listDisponibles.FormattingEnabled = true;
            this.listDisponibles.Location = new System.Drawing.Point(81, 234);
            this.listDisponibles.Name = "listDisponibles";
            this.listDisponibles.Size = new System.Drawing.Size(184, 134);
            this.listDisponibles.TabIndex = 30;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(467, 423);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(85, 29);
            this.btnCrear.TabIndex = 31;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // createTrainRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 464);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.listDisponibles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstacion);
            this.Controls.Add(this.listAñadidos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbEstacionDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cmbLocomotora);
            this.Controls.Add(this.cmbEstacionOrigen);
            this.Name = "createTrainRide";
            this.Text = "createTrainRide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ComboBox cmbLocomotora;
        private System.Windows.Forms.ComboBox cmbEstacionOrigen;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbEstacionDestino;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox listAñadidos;
        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listDisponibles;
        private System.Windows.Forms.Button btnCrear;
    }
}