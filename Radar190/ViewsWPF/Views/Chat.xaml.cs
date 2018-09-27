using System;
using Modelos;
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
        private int fkUsuario; // Variável que receberá a ID do usuário

        public Chat()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
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

            MapaForms ChatparaMapaForms = new MapaForms();
            ChatparaMapaForms.Show();
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

            Dicas_de_Seguranca ChatparaDicasDeSeguranca = new Dicas_de_Seguranca();
            ChatparaDicasDeSeguranca.Show();
        }
        #endregion           

        private void btnChatEnviarMensagem_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Chat cht = new Modelos.Chat();
            Controller.ChatController chtController = new Controller.ChatController();

            // fkUsuario recebe o ID do usuário cadastrado
            fkUsuario = chtController.RetornaID(txtChatNome.Text);

            cht.Nome = txtChatNome.Text;
            cht.Mensagem = txtChatMensagem.Text;
            cht.UsuarioIdUsuario = fkUsuario;

            // Validações dos campos para não permitir o cadastro de campos em branco. Caso fkUsuario == 0, não será permitido o envio até que esteja cadastrado
            if (string.IsNullOrWhiteSpace(txtChatNome.Text) || string.IsNullOrWhiteSpace(txtChatMensagem.Text))
            {
                MessageBox.Show("Ambos os campos são obrigatórios.");
            }
            else if(fkUsuario == 0)
            {
                MessageBox.Show("Você não está cadastrado");
            }
            else
            {
                // Ao cadastrar no BD, a DataGrid será atualizada
                chtController.Insert(cht);
                MessageBox.Show("Mensagem enviada");
                dgChatLista.ItemsSource = chtController.ListChat();
            }
        }

        private void wwChat_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.ChatController chtController = new Controller.ChatController();

            // Quando a tela carregar, a DataGrid sera preenchida com a tabela do BD
            dgChatLista.ItemsSource = chtController.ListChat();

        }
    }
}
