using Modelos;
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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        //variável que receberá a decisão do RadioButton experiência
        private bool dec;
        //variável que receberá o número da FK da cidade na página cadastro
        private int fkCidade;
        //variável que receberá o conteúdo do PasswordBox
        private string senha;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cadastre_se_Click(object sender, RoutedEventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            Cadastro.Close();
        }


        private void btnCadastroHome_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Index CadastroparaHome = new Index();
            CadastroparaHome.Show();
        }

        private void btnCadastroDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Denuncie CadastroparaDenuncie = new Denuncie();
            CadastroparaDenuncie.Show();
        }

        private void btnCadastroMapa_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Mapa CadastroparaMapa = new Mapa();
            CadastroparaMapa.Show();
        }

        private void btnCadastroEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Estatisticas CadastroparaEstatisticas = new Estatisticas();
            CadastroparaEstatisticas.Show();
        }

        private void btnCadastroChat_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Chat CadastroparaChat = new Chat();
            CadastroparaChat.Show();
        }

        private void btnCadastroContatosEmergencia_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Contatos_Emergencias CadastroparaContatosEmergenciais = new Contatos_Emergencias();
            CadastroparaContatosEmergenciais.Show();
        }

        private void btnCadastroDicas_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Dicas_de_Seguranca CadastroparaDicasSeguranca = new Dicas_de_Seguranca();
            CadastroparaDicasSeguranca.Show();
        }

        private void btnCadastroFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Cadastro CadastroFechar = new Cadastro();
            this.Close();

            Fale_Conosco CadastroparaFaleConosco = new Fale_Conosco();
            CadastroparaFaleConosco.Show();
        }

        private void dpCadastroDataNascimento_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //Armazenamento da data em um TextBox invisível para que haja a conversão para DateTime ao pressionar o botão
            txtCadastroData.Text = dpCadastroDataNascimento.ToString();

        }

        private void rbCadastroExperienciaSim_Checked(object sender, RoutedEventArgs e)
        {
            dec = true;
        }

        private void rbCadastroExperienciaNao_Checked(object sender, RoutedEventArgs e)
        {
            dec = false;
        }

        private void txtCadastroSenha_PasswordChanged(object sender, RoutedEventArgs e)
        {
            senha = txtCadastroSenha.Password;
        }

        private void btnCadastroCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario user = new Usuario();
            Cidade city = new Cidade();

            user.NomeCompleto = txtCadastroNome.Text;
            //DtNasc recebe o valor de um TextBox invisível para que seja convertido
            user.DtNasc = Convert.ToDateTime(txtCadastroData.Text);
            //Variável bool que recebe a decisão do rabio button
            user.Experiencia = dec;
            user.Descricao = txtCadastroDescricao.Text;
            user.User = txtCadastroUsuario.Text;
            //Recebe a String em que o PasswordBox foi armazenado
            user.Senha = Convert.ToInt16(senha);
            //Recebe a variável que será utilizada como FK da cidade dentro de Cadastro
            //user.CidadeIdCidade = int.Parse(cbCadastroCidade.SelectedValue.ToString());
            user.CidadeIdCidade = 1;

            Controller.UsuarioController userController = new Controller.UsuarioController();
            userController.Insert(user);

        }

    }
}
