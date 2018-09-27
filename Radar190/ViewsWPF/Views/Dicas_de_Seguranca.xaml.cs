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
    /// Interaction logic for Dicas_de_Seguranca.xaml
    /// </summary>
    public partial class Dicas_de_Seguranca : Window
    {
        public Dicas_de_Seguranca()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
        private void btnDicasHome_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Index DicasparaHome = new Index();
            DicasparaHome.Show();
        }

        private void btnDicasCadastro_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Cadastro DicasparaCadastro = new Cadastro();
            DicasparaCadastro.Show();
        }

        private void btnDicasDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Denuncie DicasparaDenuncie = new Denuncie();
            DicasparaDenuncie.Show();
        }

        private void btnDicasMapa_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            MapaForms DicasparaMapaForms = new MapaForms();
            DicasparaMapaForms.Show();
        }

        private void btnDicasEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Estatisticas DicasparaEstatisticas = new Estatisticas();
            DicasparaEstatisticas.Show();
        }

        private void btnDicasChat_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Chat DicasparaChat = new Chat();
            DicasparaChat.Show();
        }

        private void btnDicasContatosEmergenciais_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Contatos_Emergencias DicasparaContatosEmergenciais = new Contatos_Emergencias();
            DicasparaContatosEmergenciais.Show();
        }

        private void btnDicasFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_Seguranca DicasFechar = new Dicas_de_Seguranca();
            this.Close();

            Fale_Conosco DicasparaFaleConosco = new Fale_Conosco();
            DicasparaFaleConosco.Show();
        }
        #endregion

        private void wwDicasDeSeguranca_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.DicasSegurancaController dicasController = new Controller.DicasSegurancaController();
            
            // Ao carregar a tela, a DataGrid será preenchida com a tabela do BD
            dgDicasSegurancaLista.ItemsSource = dicasController.ListDicasSeguranca();
        }
    }
}
