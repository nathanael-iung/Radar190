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
    /// Interaction logic for Mapa.xaml
    /// </summary>
    public partial class Mapa : Window
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void WebBrowser_Initialized(object sender, EventArgs e)
        {
            //Abertura do MyMaps direto na tela com as marcações locais
            wbMaps.Source = new Uri("https://www.google.com/maps/d/embed?mid=1qqtQqSmTczMvEoBiuduaQE4uDY2U4RBi");
        }
    }
}
