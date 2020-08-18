using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrenesV0.controllers;

namespace TrenesV0.views
{
    public partial class AddMaterial : Form
    {
        List<Station> stations = SQLiteDataAccess.getStations();
        public AddMaterial()
        {
            InitializeComponent();
            display();
        }

        private void display()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacion.Items.Add(stations[i].nroEstacion + "-" + stations[i].nombre);
            }
            comboBox1.Items.Add("Locomotora");
            comboBox1.Items.Add("Carro");
            comboBox1.SelectedItem = "Locomotora";
        }

        private void cmbEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStation = (string)cmbEstacion.SelectedItem;
            string[] selectedStationSplited = selectedStation.Split('-');
            for ( int i=0; i< stations.Count; i++)
            {
                if(stations[i].nroEstacion.ToString() == selectedStationSplited[0])
                {
                    label6.Text = "Espacio disponible : " + stations[i].espacio;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((string)comboBox1.SelectedItem == "Locomotora")
            {
                if (txtPeso==null || txtMarca == null || txtFuerza == null)
                {
                    
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaterialRodante = (string)comboBox1.SelectedItem;
            if(selectedMaterialRodante == "Carro")
            {
                txtFuerza.Hide();
                label5.Hide();
            }
            if (selectedMaterialRodante == "Locomotora")
            {
                txtFuerza.Show();
                label5.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
