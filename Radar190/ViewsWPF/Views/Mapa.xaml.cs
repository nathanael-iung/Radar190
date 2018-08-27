using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ViewsWPF.Views
{
    /// <summary>
    /// Lógica interna para Mapa.xaml
    /// </summary>
    public partial class Mapa : Window
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void wbMaps_Initialized(object sender, EventArgs e)
        {
            wbMaps.Source = new Uri("https://www.google.com.br/maps/place/R.+Alferes+%C3%82ngelo+Sampaio,+2300+-+Bigorrilho,+Curitiba+-+PR,+80730-460/@-25.4345076,-49.2894074,18z/data=!4m5!3m4!1s0x94dce3f4853685a3:0x19cf87634c35047a!8m2!3d-25.4344228!4d-49.2886188");
        }
    }
}
