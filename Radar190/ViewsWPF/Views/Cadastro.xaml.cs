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

            MapaView CadastroparaMapaView = new MapaView();
            CadastroparaMapaView.Show();
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

        private void btnCadastroCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario user = new Usuario();

            //DtNasc recebe o valor de um TextBox invisível para que seja convertido
            //Variável bool dec que recebe a decisão do rabio button
            //senha é a string em que o passwordBox foi armazenado para possibilitar a conversão
            //CidadeIdCidade Recebe a variável que será utilizada como FK da cidade dentro de Cadastro

            //user.CidadeIdCidade = int.Parse(cbCadastroCidade.SelectedValue.ToString()); -- Teste de FK

            user.NomeCompleto = txtCadastroNome.Text;
            user.DtNasc = Convert.ToDateTime(txtCadastroData.Text);
            user.Experiencia = dec;
            user.Descricao = txtCadastroDescricao.Text;
            user.User = txtCadastroUsuario.Text;
            user.Senha = (txtCadastroSenha.Password.ToString());
            user.CidadeIdCidade = 1;

            //Verificação - campos senha e Confirmação de Senha são iguais e se a Captcha está correta
            if (txtCadastroCaptcha.Text.Equals("8") && txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()))
            {
                Controller.UsuarioController userController = new Controller.UsuarioController();
                userController.Insert(user);
                MessageBox.Show("Cadastrado com sucesso");
            }
            else if (!txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()) && txtCadastroCaptcha.Text.Equals("8"))
            {
                MessageBox.Show("Campo Confirmação de Senha difere do campo Senha");
            }
            else if (!txtCadastroCaptcha.Text.Equals("8") && txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()))
            {
                MessageBox.Show("Captcha incorreta");
            }
            else 
            {
                MessageBox.Show("Campo Confirmação de Senha difere do campo Senha e Captcha incorreta");
            }
        }
    }
}
