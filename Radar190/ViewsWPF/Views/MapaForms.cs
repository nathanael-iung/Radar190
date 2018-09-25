using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleDirections;
using GoogleMaps.LocationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ViewsWPF.Views
{
    public partial class MapaForms : Form
    {

        //GeoCoder geocoder = new GeoCoder("AIzaSyDkfKw-EFex5x_bUqPV1JfGiQAlssQCmUk");

        //private List<PointLatLng> points;
        private string convertEndereco, convertBairro, convertCidade;
        private int convertNumero;
        private string enderecoCompleto;

        private int teste1, teste2;


        public MapaForms()
        {
            InitializeComponent();
            //points = new List<PointLatLng>();
        }

        private void MapaForms_Load(object sender, EventArgs e)
        {
            /*
            var locationService = new GoogleLocationService();
            List<PointLatLng> localLatitudeLongitude = new List<PointLatLng>();
            var markOverlay = new GMapOverlay("markOverlay");
            */

            //Utilizando Google Maps
            gmMapa.MapProvider = GMapProviders.GoogleMap;
            gmMapa.Position = new PointLatLng(-25.4284, -49.2733);
            gmMapa.MinZoom = 5;
            gmMapa.MaxZoom = 100;
            gmMapa.Zoom = 10;

            gmMapa.DragButton = MouseButtons.Left;

            Controller.DenunciaController denunController = new Controller.DenunciaController();

            /*
            foreach (var denun in denunController.ListDenuncia())
            {
                
                convertEndereco = denun.Endereco;
                convertNumero = denun.Numero;
                convertBairro = denun.Distrito;
                convertCidade = denun.City;
                

                teste1 = Convert.ToInt16(denun.Idade);
                teste2 = Convert.ToInt16(denun.CPF);

                */



            /*
            enderecoCompleto = string.Concat(convertEndereco, ", ", convertNumero, ", ", convertBairro, ", ", convertCidade);
            var local = locationService.GetLatLongFromAddress(enderecoCompleto);
            var latitude = local.Latitude;
            var longitude = local.Longitude;
            localLatitudeLongitude.Add(new PointLatLng(latitude, longitude));


            localLatitudeLongitude.Add(new PointLatLng(teste1, teste2));

            }

            foreach(PointLatLng ptLatLong in localLatitudeLongitude)
            {
                var marcacao = new GMarkerGoogle(ptLatLong, GMarkerGoogleType.red_dot);
                markOverlay.Markers.Add(marcacao);
            }

            gmMapa.Overlays.Add(markOverlay);

            */

            /*
            //var endereco = "R. Alferes Ângelo Sampaio, 2300, Bigorrilho, Curitiba";
            // var endereco = "R. Salvador Ferrante, 2380, Boqueirão, Curitiba";
            //var endereco = "Rua Barão do Serro Azul, 316, Centro, Curitiba";
            var locationService = new GoogleLocationService();
            //Conversão do endereço informado em latitude e longitude
            var ponto = locationService.GetLatLongFromAddress(endereco);
            var lat = ponto.Latitude;
            var lon = ponto.Longitude;
            */

            /*
            //Adicionando endereço a ctba
            PointLatLng ctba = new PointLatLng(-28, -48);
            //PointLatLng ctba = new PointLatLng(lat, lon);

            //Local e estilo da marcação
            GMapMarker m1 = new GMarkerGoogle(ctba, GMarkerGoogleType.red_dot);
            //Criando uma camada p/ o mapa
            GMapOverlay markers = new GMapOverlay("markers");
            //Adicionando o(s) endereços a essa camada
            markers.Markers.Add(m1);
            //Adicionando a camada ao mapa
            gmMapa.Overlays.Add(markers);
            */

            //var geo = new ViewsWPF.VpGeoCoding();
            /*
            geo.endereco = "R. Alferes Ângelo Sampaio";
            geo.numero = 2300;
            geo.bairro = "Bigorrilho";
            geo.cidade = "Curitiba";
            */
            //geo.endereco = "30 Frank Lloyd Wright Drive";

            //geo.GeoCode();

            var geocoder = new Geocoder("AIzaSyAY_PbVbpKm_5oqAkplr72yc - QJxMboXwQ");
            //new System.Collections.Generic.Mscorlib_CollectionDebugView<GoogleDirections.Location>(locations).Items[0].LatLng.Longitude

            var locations = geocoder.Geocode("Rua Alferes Ângelo Sampaio, 2300, Bigorrilho, Curitba");
            //GoogleDirections.LatLng lat = geocoder.Geocode("R. Salvador Ferrante, 2380, Boqueirão");

            var result = string.Join("-", locations);
           
            label1.Text = result;
            txtLatitude.Text = result.ToString();
            
            
            #region "Exmplo código Lista de PointLatLng"
            /*
            var markers = new GMapOverlay("markers");
            List<PointLatLng> pointLatLngs = new List<PointLatLng>()
            {
                new PointLatLng(18.5204, 73.8567),
                new PointLatLng(19.0760, 72.8777)
            };
            foreach (PointLatLng pt in pointLatLngs)
            {
                var marker = new GMarkerGoogle(pt, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker); // Adding multiple markers to the single overlay "markers"
            }
            gmMapa.Overlays.Add(markers);
            */
            #endregion
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            /*
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

            /*
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
            */

        }
    }
}
