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
    /// Interaction logic for Chat.xaml
    /// </summary>
    public partial class Chat : Window
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void btnChatHome_Click(object sender, RoutedEventArgs e)
        {
             
            Chat ChatFechar = new Chat();
           this.Close();

            Index ChatparaHome = new Index();
            ChatparaHome.Show();
        }

        private void btnChatCadastrese_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Cadastro ChatparaCadastro = new Cadastro();
            ChatparaCadastro.Show();
        }

        private void btnChatFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Fale_Conosco ChatparaFaleConosco = new Fale_Conosco();
            ChatparaFaleConosco.Show();
        }

        private void btnChatDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Denuncie ChatparaDenuncie = new Denuncie();
            ChatparaDenuncie.Show();
        }

        private void btnChatMapa_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Mapa ChatparaMapa = new Mapa();
            ChatparaMapa.Show();
        }

        private void btnChatEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Estatisticas ChatparaEstatistica = new Estatisticas();
            ChatparaEstatistica.Show();
        }

        private void btnChatContatosEmergencia_Click(object sender, RoutedEventArgs e)
        {
            Chat ChatFechar = new Chat();
            this.Close();

            Contatos_Emergencias ChatparaContatosEmergencia = new Contatos_Emergencias();
            ChatparaContatosEmergencia.Show();
        }

        private void btnChatDicas_Click(object sender, RoutedEventArgs e)
        {
              Chat ChatFechar = new Chat();
            this.Close();

           Dicas_de_Seguranca ChatparaChatparaDicasDeSeguranca = new Dicas_de_Seguranca();
            ChatparaChatparaDicasDeSeguranca.Show();
        }
    }
}
