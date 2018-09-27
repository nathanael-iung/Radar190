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
using System.Globalization;
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
        #region "Variáveis para conversão de endereço em latitude e longitude - Nâo Funcional"
        /*
        private string convertEndereco, convertBairro, convertCidade;
        private int convertNumero;
        private string enderecoCompleto;
        */
        #endregion
        double latitude, longitude; // Variáveis que receberão os valores do BD

        public MapaForms()
        {
            InitializeComponent();
        }

        private void btnMapaIndex_Click(object sender, EventArgs e)
        {
            MapaForms mapaFechar = new MapaForms();
            this.Close();

            Index mapaParaIndex = new Index();
            mapaParaIndex.Show();
        }

        private void MapaForms_Load(object sender, EventArgs e)
        {
            List<PointLatLng> localLatitudeLongitude = new List<PointLatLng>(); // Criação de uma Lista  do tipo PointLatLng para o recebimento de coordenadas
            var markOverlay = new GMapOverlay("markOverlay"); // Camada de marcações que será adicionada ao mapa
            Controller.DenunciaController denunController = new Controller.DenunciaController();

            
            gmMapa.MapProvider = GMapProviders.GoogleMap; //Utilizando Google Maps p/ fornecer o mapa
            gmMapa.Position = new PointLatLng(-25.4284, -49.2733); // Posição inicial do mapa (Curitiba)
            gmMapa.MinZoom = 5; 
            gmMapa.MaxZoom = 100;
            gmMapa.Zoom = 10;

            gmMapa.DragButton = MouseButtons.Left; // Botão esquerdo para movimentar o mapa

            foreach (var denun in denunController.ListDenuncia())
            {
                #region "Armazenamento do endereço completo das denúncias para concatenação e conversão em latitude e longitude - Não Funcional"
                /*
                var locationService = new GoogleLocationService();
                convertEndereco = denun.Endereco;
                convertNumero = denun.Numero;
                convertBairro = denun.Distrito;
                convertCidade = denun.City;
                enderecoCompleto = string.Concat(convertEndereco, ", ", convertNumero, ", ", convertBairro, ", ", convertCidade);
                enderecoCompleto = string.Concat(convertEndereco, ", ", convertNumero, ", ", convertBairro, ", ", convertCidade);
                var local = locationService.GetLatLongFromAddress(enderecoCompleto);
                var latitude = local.Latitude;
                var longitude = local.Longitude;
                localLatitudeLongitude.Add(new PointLatLng(latitude, longitude));
                */
                #endregion

                latitude = double.Parse(denun.Latitude, CultureInfo.InvariantCulture);
                longitude = double.Parse(denun.Longitude, CultureInfo.InvariantCulture);
                localLatitudeLongitude.Add(new PointLatLng(latitude, longitude)); // Adição das coordenadas de todas as denúncias do BD em uma lista
            
             }

            foreach (PointLatLng ptLatLong in localLatitudeLongitude)
            {
                var marcacao = new GMarkerGoogle(ptLatLong, GMarkerGoogleType.red_dot);
                markOverlay.Markers.Add(marcacao); // Adição de todas as marcações a camada
            }

            gmMapa.Overlays.Add(markOverlay); // Adição da camada ao mapa

            #region "Conversão de endereço em coordenas via Geocode - Não Funcional"
            /*
            var geocoder = new Geocoder("AIzaSyAY_PbVbpKm_5oqAkplr72yc - QJxMboXwQ");
            //new System.Collections.Generic.Mscorlib_CollectionDebugView<GoogleDirections.Location>(locations).Items[0].LatLng.Longitude

            var locations = geocoder.Geocode("Rua Ângelo Sampaio, 2300");
         
            var result = string.Join("-", locations);

            label1.Text = result;
            */
            #endregion

            #region "Adição de coordenadas teste"
            /*
            localLatitudeLongitude.Add(new PointLatLng(-28, -45));
            localLatitudeLongitude.Add(new PointLatLng(-29, -44));
            localLatitudeLongitude.Add(new PointLatLng(-27, -43));
            localLatitudeLongitude.Add(new PointLatLng(-30, -45));
            localLatitudeLongitude.Add(new PointLatLng(-29, -45));
            */
            #endregion

            #region "GoogleLocationService"
            /*
            //var endereco = "R. Alferes Ângelo Sampaio, 2300, Bigorrilho, Curitiba";
            // var endereco = "R. Salvador Ferrante, 2380, Boqueirão, Curitiba";
            //var endereco = "Rua Barão do Serro Azul, 316, Centro, Curitiba";
            var locationService = new GoogleLocationService();
            //Conversão do endereço informado em latitude e longitude
            var ponto = locationService.GetLatLongFromAddress(endereco);
            var lat = ponto.Latitude;
            var lon = ponto.Longitude;
            
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
            #endregion

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
    }
}
