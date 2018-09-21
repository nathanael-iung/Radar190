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
    /// Interaction logic for Estatisticas.xaml
    /// </summary>
    public partial class Estatisticas : Window
    {
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void btnEstatisticaHome_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Index EstatisticaparaHome = new Index();
            EstatisticaparaHome.Show();
        }

        private void btnEstatisticaCadastro_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Cadastro EstatisticaparaCadastro = new Cadastro();
            EstatisticaparaCadastro.Show();
        }

        private void btnEstatisticaDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Denuncie EstatisticaparaDenuncie = new Denuncie();
            EstatisticaparaDenuncie.Show();
        }

        private void btnEstatisticaMapa_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            MapaView EstatisticaparaMapa = new MapaView();
            EstatisticaparaMapa.Show();
        }

        private void btnEstatisticaChat_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Chat EstatisticaparaChat = new Chat();
            EstatisticaparaChat.Show();
        }

        private void btnEstatisticaContatosEmergencia_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Contatos_Emergencias EstatisticaparaContatosEmergenciais = new Contatos_Emergencias();
            EstatisticaparaContatosEmergenciais.Show();
        }

        private void btnEstatisticaDicas_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Dicas_de_Seguranca EstatisticaparaDicasDeSeguranca = new Dicas_de_Seguranca();
            EstatisticaparaDicasDeSeguranca.Show();
        }

        private void btnEstatisticaFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Estatisticas EstatisticasFechar = new Estatisticas();
            this.Close();

            Fale_Conosco EstatisticaparaFaleConosco = new Fale_Conosco();
            EstatisticaparaFaleConosco.Show();
        }
    }
    
}
