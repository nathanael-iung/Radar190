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
            wbMaps.Source = new Uri("https://www.google.com/maps/d/embed?mid=1gj8Wq6BxLFdqX8luXh5pj-HxudMkxNfx");
        }

        private void btnMapaHome_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Index MapaparaHome = new Index();
            MapaparaHome.Show();
        }

        private void btnMapaCadastro_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Cadastro MapaparaCadastro = new Cadastro();
            MapaparaCadastro.Show();
        }

        private void btnMapaDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Denuncie MapaparaDenuncie = new Denuncie();
            MapaparaDenuncie.Show();
        }

        private void btnMapaEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Estatisticas MapaparaEstatisticas = new Estatisticas();
            MapaparaEstatisticas.Show();
        }

        private void btnMapaChat_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Chat MapaparaChat = new Chat();
            MapaparaChat.Show();
        }

        private void btnMapaContatosEmergenciais_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Contatos_Emergencias MapaparaContatosEmergenciais = new Contatos_Emergencias();
            MapaparaContatosEmergenciais.Show();
        }

        private void btnMapaDicas_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Dicas_de_Seguranca MapaparaDicas = new Dicas_de_Seguranca();
            MapaparaDicas.Show();
        }

        private void btnMapaFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Mapa MapaFechar = new Mapa();
            this.Close();

            Fale_Conosco MapaparaFaleConosco = new Fale_Conosco();
            MapaparaFaleConosco.Show();
        }
    }
}
