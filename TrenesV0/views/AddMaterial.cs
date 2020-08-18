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
            displayEstaciones();
        }

        private void displayEstaciones()
        {

            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacion.Items.Add(stations[i].nroEstacion + "-" + stations[i].nombre);
            }
        }

        private void cmbEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedStation = (string)cmbEstacion.SelectedItem;
            string[] selectedStationSplited = selectedStation.Split('-');
            int stationID;
            int.TryParse(selectedStationSplited[0], out stationID);
            List<Material> materiales = SQLiteDataAccess.getMaterial(stationID);
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
