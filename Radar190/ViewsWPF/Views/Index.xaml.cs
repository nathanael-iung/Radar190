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

            MapaView IndexparaMapa = new MapaView();
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

        private string nomeUsuario; // Armazena o login do usuário para que seja exibido no Label da index antes que o txtLogin seja limpo
        public bool logado; // Verificação se o usuário está logado ou não
        private int id;

        private void wwIndex_Loaded(object sender, RoutedEventArgs e)
        {
            Login welcome = new Login();

            btnIndexLogin.IsEnabled = false;

            if(logado == false)
            {
                btnHomeMapa.IsEnabled = false;
                btnHomeEstatisticas.IsEnabled = false;
                btnHomeChat.IsEnabled = false;
            }
        }

        private void btnIndexEntrar_Click(object sender, RoutedEventArgs e)
        {
            Controller.UsuarioController userController = new Controller.UsuarioController();

            if (userController.VerificaLogin(txtIndexUsuario.Text, pbIndexSenha.Password))
            {
                nomeUsuario = txtIndexUsuario.Text;
                logado = true;
                btnIndexEntrar.IsEnabled = false;
                txtIndexUsuario.Text = "";
                pbIndexSenha.Password = "";
                MessageBox.Show("Login efetuado com sucesso");
                lblIndexOla.Content = ("Olá, " + nomeUsuario);
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha inválido(a)");
                logado = false;
            }
        }

        private void btnIndexMapaForms_Click(object sender, RoutedEventArgs e)
        {
            MapaForms mapa = new MapaForms();
            mapa.Show();
        }

        // Construir queries de estatísticas
    }
}
