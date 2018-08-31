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
    /// Lógica interna para Denuncie.xaml
    /// </summary>
    public partial class Denuncie : Window
    {
        public Denuncie()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnDenuncieHome_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Index DenuncieparaHome = new Index();
            DenuncieparaHome.Show();
        }

        private void btnDenuncieCadastro_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Cadastro DenuncieparaCadastro = new Cadastro();
            DenuncieparaCadastro.Show();
        }

        private void btnDenuncieDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Denuncie DenuncieparaDenuncie = new Denuncie();
            DenuncieparaDenuncie.Show();
        }

        private void btnDenuncieMapa_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Mapa DenuncieparaMapa = new Mapa();
            DenuncieparaMapa.Show();
        }

        private void btnDenuncieEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Estatisticas DenuncieparaEstatistica = new Estatisticas();
            DenuncieparaEstatistica.Show();
        }

        private void btnDenuncieChat_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Chat DenuncieparaChat = new Chat();
            DenuncieparaChat.Show();
        }

        private void btnDenuncieContatosEmergencias_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Contatos_Emergencias DenuncieparaContatosEmergenciais = new Contatos_Emergencias();
            DenuncieparaContatosEmergenciais.Show();
        }

        private void btnDenuncieDicas_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Dicas_de_Seguranca DenuncieparaDicas = new Dicas_de_Seguranca();
            DenuncieparaDicas.Show();
        }

        private void btnDenuncieFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Denuncie ChatFechar = new Denuncie();
            this.Close();

            Fale_Conosco DenuncieparaFaleConosco = new Fale_Conosco();
            DenuncieparaFaleConosco.Show();
        }
    }
}
