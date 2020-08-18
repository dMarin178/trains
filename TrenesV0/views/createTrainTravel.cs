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
    public partial class createTrainRide : Form
    {
        //carga los datos de los menus.
        List<Station> stations = SQLiteDataAccess.getStations();
        public createTrainRide()
        {
            InitializeComponent();
            displayEstacionOrigen();
            displayDestino();
            displayEstacion();
            displayPrioridad();

        }
        //desplega todas las estaciones para elegir la estacion de origen
        private void displayEstacionOrigen()
        {
            for(int i=0; i < stations.Count; i++)
            {
                cmbEstacionOrigen.Items.Add(stations[i].id + "-" + stations[i].nombre);
            }
        }
        //desplega todas las estaciones para mostrar sus carros
        private void displayEstacion()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacion.Items.Add(stations[i].id + "-" + stations[i].nombre);
            }
        }
        //despliega todas las estaciones, para seleccionar el destino
        private void displayDestino()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacionDestino.Items.Add(stations[i].id + "-" + stations[i].nombre);
            }
        }
        //despliega las prioridades
        private void displayPrioridad()
        {
            cmbPrioridad.Items.Add("Baja");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Muy alta");
        }
        //despliega la informacion de las locomotoras en la lista
        private void displayLocomotoras(List<Locomotive> locomotives)
        {
            cmbLocomotora.BeginUpdate();
            for (int i = 0; i < locomotives.Count; i++)
            {
                cmbLocomotora.Items.Add(locomotives[i].id +"-"+ locomotives[i].locomotora);
            }
            cmbLocomotora.EndUpdate();
        }
        //despliega toda la informacion de los carros, tanto locomotoras como materiales rodantes
        private void displayListDisponibles(List<Locomotive> locomotives, List<Material> materials)
        {
            listDisponibles.BeginUpdate();
            for (int i = 0; i < locomotives.Count; i++)
            {
                listDisponibles.Items.Add(locomotives[i].id +"-"+ locomotives[i].locomotora);
            }
            for (int j = 0; j < materials.Count; j++)
            {
                listDisponibles.Items.Add(materials[j].id +"-"+ materials[j].material);
            }
            listDisponibles.Items.Remove(cmbLocomotora.SelectedItem);
            listDisponibles.EndUpdate();
        }
        //Muestra las locomotoras disponibles al seleccionar una estacion de origen
        private void cmbEstacionOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLocomotora.Items.Clear();
            string selectedStation = (string) cmbEstacionOrigen.SelectedItem;
            string[] selectedStationSplited = selectedStation.Split('-');
            int stationID;
            int.TryParse(selectedStationSplited[0], out stationID);
            List<Locomotive> locos = SQLiteDataAccess.getLocomotives(stationID);
            displayLocomotoras(locos);
        }
        //Muestra todos los carros en la estacion seleccionada
        private void cmbEstacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDisponibles.Items.Clear();
            string selectedStation = (string)cmbEstacion.SelectedItem;
            string[] selectedStationSplited = selectedStation.Split('-');
            int stationID;
            int.TryParse(selectedStationSplited[0], out stationID);
            List<Locomotive> locos = SQLiteDataAccess.getLocomotives(stationID);
            List<Material> materiales = SQLiteDataAccess.getMaterial(stationID);
            displayListDisponibles(locos, materiales);
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            listAñadidos.Items.Add(listDisponibles.SelectedItem);
            listDisponibles.Items.Remove(listDisponibles.SelectedItem);
        }

        private void cmbLocomotora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstacion.Enabled = true;

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            listDisponibles.Items.Add(listAñadidos.SelectedItem);
            listAñadidos.Items.Remove(listAñadidos.SelectedItem);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var fecha = datePick.Value;
            var origen = cmbEstacionOrigen.SelectedItem;
            var locomotora = cmbLocomotora.SelectedItem;
            var destino = cmbEstacionDestino.SelectedItem;
            var prioridad = cmbPrioridad.SelectedItem;
            var carros = listAñadidos.Items;
            if(origen!=null&&locomotora!=null&&destino!=null&& prioridad != null)
            {
                //Query
            }
            else
            {
                //saltar mensaje de error
            }
        }
    }
}
