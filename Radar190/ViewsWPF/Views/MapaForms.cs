using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ViewsWPF.Views
{
    public partial class MapaForms : Form
    {

        private List<PointLatLng> points;

        public MapaForms()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
        }

        private void MapaForms_Load(object sender, EventArgs e)
        {
            /*
            gmMapa.DragButton = MouseButtons.Left;
            gmMapa.MapProvider = GMapProviders.GoogleMap;
            gmMapa.Position = new PointLatLng(-25.4284, -49.2733);
            gmMapa.MinZoom = 5;
            gmMapa.MaxZoom = 100;
            gmMapa.Zoom = 10;
            */

            //Utilizando Google Maps
            gmMapa.MapProvider = GMapProviders.GoogleMap;
            //double lat = Convert.ToDouble(txtLatitude.Text);
            //double lon = Convert.ToDouble(txtLongitude.Text);
            gmMapa.Position = new PointLatLng(-25.4284, -49.2733);
            gmMapa.MinZoom = 5;
            gmMapa.MaxZoom = 100;
            gmMapa.Zoom = 10;

            gmMapa.DragButton = MouseButtons.Left;

            points.Add(new PointLatLng(Convert.ToDouble(-25), Convert.ToDouble(-50)));
            points.Add(new PointLatLng(Convert.ToDouble(-26), Convert.ToDouble(-51)));
            points.Add(new PointLatLng(Convert.ToDouble(-27), Convert.ToDouble(-53)));
            

            GMapMarker marcacoes1 = new GMarkerGoogle(points[0], GMarkerGoogleType.red_dot);
            GMapMarker marcacoes2 = new GMarkerGoogle(points[1], GMarkerGoogleType.red_dot);
            GMapMarker marcacoes3 = new GMarkerGoogle(points[2], GMarkerGoogleType.red_dot);


            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(points[0]);
            markers.Markers.Add(marcacoes2);
            markers.Markers.Add(marcacoes3);

            gmMapa.Overlays.Add(markers);

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Utilizando Google Maps
            gmMapa.MapProvider = GMapProviders.GoogleMap;
            //double lat = Convert.ToDouble(txtLatitude.Text);
            //double lon = Convert.ToDouble(txtLongitude.Text);
            gmMapa.Position = new PointLatLng(-25.4284, -49.2733);
            gmMapa.MinZoom = 5;
            gmMapa.MaxZoom = 100;
            gmMapa.Zoom = 10;

            gmMapa.DragButton = MouseButtons.Left;

            /*
            IList points = new List<PointLatLng>();
            points.Add(new PointLatLng(-25, -50));
            points.Add(new PointLatLng(-26, -51));
            points.Add(new PointLatLng(-27, -53));
            */


            PointLatLng mark1 = new PointLatLng(-28, -45);
            PointLatLng mark2 = new PointLatLng(-29, -44);
            PointLatLng mark3 = new PointLatLng(-30, -46);
            PointLatLng mark4 = new PointLatLng(-27, -43);
            GMapMarker marcacoes1 = new GMarkerGoogle(mark1, GMarkerGoogleType.red_dot);
            GMapMarker marcacoes2 = new GMarkerGoogle(mark2, GMarkerGoogleType.red_dot);
            GMapMarker marcacoes3 = new GMarkerGoogle(mark3, GMarkerGoogleType.red_dot);
            GMapMarker marcacoes4 = new GMarkerGoogle(mark4, GMarkerGoogleType.red_dot);
          
            
            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marcacoes1);
            markers.Markers.Add(marcacoes2);
            markers.Markers.Add(marcacoes3);
            markers.Markers.Add(marcacoes4);

            gmMapa.Overlays.Add(markers);
            
        }
    }
}
