using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenesV0.views
{
    public partial class EditMaterial : Form
    {
        List<Station> stations = SQLiteDataAccess.getStations();
        public EditMaterial()
        {
            InitializeComponent();
            displayEstaciones();
        }

        private void displayEstaciones()
        {
            for(int i = 0; i < stations.Count; i++)
            {
                cmbEstacion.Items.Add(stations[i].id + "-" + stations[i].nombre);
            }
        }
        private void displayMateriales(List<Material> materials)
        {
            cmbMaterial.BeginUpdate();
            for (int i = 0; i < materials.Count; i++)
            {
                cmbMaterial.Items.Add(materials[i].id + "-" + materials[i].material);
            }
            cmbMaterial.EndUpdate();
        }
        private void cmbEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaterial.Items.Clear();
            string selectedStation = (string)cmbEstacion.SelectedItem;
            string[] selectedStationSplited = selectedStation.Split('-');
            int stationID;
            int.TryParse(selectedStationSplited[0], out stationID);
            List<Material> materiales = SQLiteDataAccess.getMaterial(stationID);
            displayMateriales(materiales);
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaterial.Enabled = true;
            txtPeso.Enabled = true;
            //ingresar query para agregar material
        }
    }
}
