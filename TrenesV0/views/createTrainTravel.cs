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
                cmbEstacionOrigen.Items.Add(stations[i].nroEstacion + "-" + stations[i].nombre);
            }
        }
        //desplega todas las estaciones para mostrar sus carros
        private void displayEstacion()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacion.Items.Add(stations[i].nroEstacion + "-" + stations[i].nombre);
            }
        }
        //despliega todas las estaciones, para seleccionar el destino
        private void displayDestino()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                cmbEstacionDestino.Items.Add(stations[i].nroEstacion + "-" + stations[i].nombre);
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
                cmbLocomotora.Items.Add("Locomotora: " + locomotives[i].idMaterialR + " marca: " + locomotives[i].marca + " fuerza: " + locomotives[i].fuerza); ;
            }
            cmbLocomotora.EndUpdate();
        }
        //despliega toda la informacion de los carros, tanto locomotoras como materiales rodantes
        private void displayListDisponibles(List<Locomotive> locomotives, List<Carro> carro)
        {
            listDisponibles.BeginUpdate();
            if (locomotives != null)
            {
                for (int i = 0; i < locomotives.Count; i++)
                {
                    listDisponibles.Items.Add("Locomotora: " + locomotives[i].idMaterialR + " marca: " + locomotives[i].marca + " fuerza: " + locomotives[i].fuerza);
                }
            }
            if (carro != null)
            {

                for (int j = 0; j < carro.Count; j++)
                {
                    listDisponibles.Items.Add("Carro: " + carro[j].idMaterialR + " marca: " + carro[j].marca + " peso: " + carro[j].peso + " lleva: " + carro[j].idProducto);
                }
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
            List<Carro> materiales = SQLiteDataAccess.getCarro(stationID);
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
            var origencmb = cmbEstacionOrigen.SelectedItem;
            var locomotoracmb = cmbLocomotora.SelectedItem;
            var destinocmb = cmbEstacionDestino.SelectedItem;
            var prioridadcmb = cmbPrioridad.SelectedItem;
            var carros = listAñadidos.Items;
            var rutCreador = Login.SetValueFortxtUsuario;
            if (origencmb!=null&&locomotoracmb!=null&&destinocmb!=null&& prioridadcmb!= null)
            {
                string locomotora = ((string)locomotoracmb).Split()[1];
                long.TryParse(locomotora, out long locomotoraid);
                long trenid = SQLiteDataAccess.getLastTrain() + 1;
                var tren = new Tren(trenid,locomotoraid,rutCreador);
                SQLiteDataAccess.setTren(tren);
                string origen = ((string)origencmb).Trim().Split('-')[0];
                long.TryParse(origen, out long origenEstacion);
                string destino = ((string)destinocmb).Trim().Split('-')[0];
                long.TryParse(destino, out long destinoEstacion);
                long viajeid = SQLiteDataAccess.getLastViaje() + 1;
                var viaje = new Viaje(viajeid, trenid, origenEstacion, destinoEstacion, rutCreador, fecha);
                SQLiteDataAccess.setViaje(viaje);
                for (int i = 0; i < carros.Count; i++)
                {
                    string carro = ((string)carros[i]).Split()[1];
                    long carroid;
                    long.TryParse(carro, out carroid);
                    SQLiteDataAccess.setTrenMaterialRodante(trenid, carroid);
                }

            }
            else
            {
                //saltar mensaje de error, agregar un errorprovider a la vista
            }
        }
    }
}
