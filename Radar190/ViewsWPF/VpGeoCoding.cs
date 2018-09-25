using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net;

namespace ViewsWPF
{
    public class VpGeoCoding
    {
        public enum AccurateToTypes : int
        {
            Unknown = 0,
            Country = 1,
            Region = 2,
            SubRegion = 3,
            Town = 4,
            PostCode = 5,
            Street = 6,
            Intersection = 7,
            Address = 8,
            Premises = 9
        }

        public string latitude { get; set; }
        public string longitude { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }

        private AccurateToTypes _latLngAccuracy = 0;
        public AccurateToTypes LatLngAccuracy
        {
            get { return _latLngAccuracy; }
        }

        public void GeoCode()
        {
            StreamReader sr = null;

            string mapskey = ("AIzaSyAY_PbVbpKm_5oqAkplr72yc-QJxMboXwQ");


            if (string.IsNullOrEmpty(mapskey))
            {
                throw new Exception("Não há Key válida");
            }

            //var url = string.Format("http://maps.google.com/geo?q={0}+{1}+{2}+{3}&output=xml&oe=utf8&sensor=false&key={4}", endereco, ", ", numero, ", ", bairro, ", ", cidade, mapskey);
            var url = string.Format("http://maps.google.com/geo?q={0}&output=xml&oe=utf8&sensor=true&key={1}", endereco, mapskey);

            var webClient = new WebClient();

            try
            {
                sr = new StreamReader(webClient.OpenRead(url));
            }
            catch (Exception ex)
            {
                throw new Exception("O erro foi : " + ex.Message);
            }

            try
            {
                var xmlTextReader = new XmlTextReader(sr);

                var coordread = false;
                var accread = false;

                while (xmlTextReader.Read())
                {

                    xmlTextReader.MoveToElement();

                    switch (xmlTextReader.Name)
                    {
                        case "AddressDetails":

                            while (xmlTextReader.MoveToNextAttribute())
                            {
                                switch (xmlTextReader.Name)
                                {
                                    case "Accuracy":

                                        if (!accread)
                                        {
                                            this._latLngAccuracy = (AccurateToTypes)Convert.ToInt32(xmlTextReader.Value);
                                            accread = true;
                                        }

                                        break;
                                }
                            }

                            break;
                        case "coordinates":

                            if (!coordread)
                            {
                                xmlTextReader.Read();

                                string[] coords = xmlTextReader.Value.Split(new char[] { ',' });

                                longitude = coords[0];
                                latitude = coords[1];

                                coordread = true;
                            }
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro foi: " + ex.Message);
            }
        }

    }
}
