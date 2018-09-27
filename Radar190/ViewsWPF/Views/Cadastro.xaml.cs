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
        private bool? dec = null;

        public Cadastro()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
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

            MapaForms CadastroparaMapaForms = new MapaForms();
            CadastroparaMapaForms.Show();
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
        #endregion

        private void dpCadastroDataNascimento_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //Armazenamento da data em um TextBox invisível para que haja a conversão para DateTime ao pressionar o botão
            txtCadastroData.Text = dpCadastroDataNascimento.ToString();
        }

        private void rbCadastroExperienciaSim_Checked(object sender, RoutedEventArgs e)
        {
            //dec recebe true caso Sim seja Checkado
            dec = true;
        }

        private void rbCadastroExperienciaNao_Checked(object sender, RoutedEventArgs e)
        {
            //dec rece false caso Não seja Checkado
            dec = false;
        }

        private void btnCadastroCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario user = new Usuario();

            user.NomeCompleto = txtCadastroNome.Text;
            user.DtNasc = Convert.ToDateTime(txtCadastroData.Text); // txtCadastroData é uma TextBox invisível que recebe o valor do DatePicker para que haja a conversão
            user.Experiencia = dec; //Variável bool dec que recebe a decisão do rabio button
            user.Cidade = cbCadastroCidade.SelectionBoxItem.ToString();
            user.Descricao = txtCadastroDescricao.Text;
            user.User = txtCadastroUsuario.Text;
            user.Senha = (txtCadastroSenha.Password.ToString());

            #region "Validação teste"
            /*
            //Verificação - campos senha e Confirmação de Senha são iguais e se a Captcha está correta
            if (txtCadastroCaptcha.Text.Equals("8") && txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()))
            {
                Controller.UsuarioController userController = new Controller.UsuarioController();
                userController.Insert(user);
                MessageBox.Show("Cadastrado com sucesso");
            }
            */
            #endregion

            // Validação para não permitir o cadastro de campos em branco
            if (string.IsNullOrWhiteSpace(txtCadastroNome.Text) || dpCadastroDataNascimento.SelectedDate == null || cbCadastroCidade.SelectionBoxItem.ToString().Equals("") || string.IsNullOrWhiteSpace(txtCadastroUsuario.Text) || string.IsNullOrWhiteSpace(txtCadastroSenha.Password))
            {
                MessageBox.Show("Campos obrigatórios não preenchidos. (marcados com *)");
            }
            else if (!txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()) && txtCadastroCaptcha.Text.Equals("8"))
            {
                MessageBox.Show("Campo Confirmação de Senha difere do campo Senha");
            }
            else if (!txtCadastroCaptcha.Text.Equals("8") && txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()))
            {
                MessageBox.Show("Captcha incorreta");
            }
            else if (!txtCadastroSenha.Password.ToString().Equals(txtCadastroConfirmarSenha.Password.ToString()) && !txtCadastroCaptcha.Text.Equals("8"))
            {
                MessageBox.Show("Campo Confirmação de Senha difere do campo Senha e Captcha incorreta");
            }
            else
            {
                Controller.UsuarioController userController = new Controller.UsuarioController();
                userController.Insert(user);
                MessageBox.Show("Cadastrado com sucesso");
            }
        }
    }
}
