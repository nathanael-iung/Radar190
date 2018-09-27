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
    /// Interaction logic for Contatos_Emergencias.xaml
    /// </summary>
    public partial class Contatos_Emergencias : Window
    {
        public Contatos_Emergencias()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
        private void btnContatosHome_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Index ChatparaHome = new Index();
            ChatparaHome.Show();
        }

        private void btnContatosCadastro_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Cadastro ContatosEmergenciasparaCadastro = new Cadastro();
            ContatosEmergenciasparaCadastro.Show();
        }

        private void btnContatosDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Denuncie ContatosEmergenciasparaDenuncie = new Denuncie();
            ContatosEmergenciasparaDenuncie.Show();
        }

        private void btnContatosMapa_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            MapaForms ContatosEmergenciasparaMapaForms = new MapaForms();
            ContatosEmergenciasparaMapaForms.Show();
        }

        private void btnContatosEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Estatisticas ContatosEmergenciasparaEstatisticas = new Estatisticas();
            ContatosEmergenciasparaEstatisticas.Show();
        }

        private void btnContatosChat_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Chat ContatosEmergenciasparaChat = new Chat();
            ContatosEmergenciasparaChat.Show();
        }

        private void btnContatosDicas_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Dicas_de_Seguranca ContatosEmergenciasparaDicas = new Dicas_de_Seguranca();
            ContatosEmergenciasparaDicas.Show();
        }

        private void btnContatosFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Contatos_Emergencias ContatosEmergenciaisFechar = new Contatos_Emergencias();
            this.Close();

            Fale_Conosco ContatosEmergenciasparaFaleConosco = new Fale_Conosco();
            ContatosEmergenciasparaFaleConosco.Show();
        }
        #endregion

        private void wwContatosEmergenciais_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.ContatosEmergenciaisController contatosController = new Controller.ContatosEmergenciaisController();

            // Quando a tela carregar, a DataGrid será preenchida com os dados do BD
            dgContatosEmergenciaisLista.ItemsSource = contatosController.ListContatosEmergenciais();
        }
    }
}
