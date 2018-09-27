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
    /// Lógica interna para Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
        private void btnHomeCadastro_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Cadastro IndexparaCadastro = new Cadastro();
            IndexparaCadastro.Show();
        }

        private void btnHomeDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Denuncie IndexparaDenuncie = new Denuncie();
            IndexparaDenuncie.Show();
        }

        private void btnHomeMapa_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            MapaForms IndexparaMapa = new MapaForms();
            IndexparaMapa.Show();
        }

        private void btnHomeEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Estatisticas IndexparaEstatisticas = new Estatisticas();
            IndexparaEstatisticas.Show();
        }

        private void btnHomeChat_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Chat IndexparaChat = new Chat();
            IndexparaChat.Show();
        }

        private void btnHomeContatosEmergenciais_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Contatos_Emergencias IndexparaConstatosEmergenciais = new Contatos_Emergencias();
            IndexparaConstatosEmergenciais.Show();
        }

        private void btnHomeDicas_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Dicas_de_Seguranca IndexparaDicas = new Dicas_de_Seguranca();
            IndexparaDicas.Show();
        }

        private void btnHomeFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Index IndexFechar = new Index();
            this.Close();

            Fale_Conosco IndexparaFaleConosco = new Fale_Conosco();
            IndexparaFaleConosco.Show();
        }

        private void btnIndexLogin_Click(object sender, RoutedEventArgs e)
        {
            Login abrirLogin = new Login();
            abrirLogin.Show();

        }
        #endregion

        private void wwIndex_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnIndexMapaForms_Click(object sender, RoutedEventArgs e)
        {
            MapaForms mapa = new MapaForms();
            mapa.Show();
        }

        // Construir queries de estatísticas
    }
}
