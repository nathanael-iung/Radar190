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

namespace ViewsWPF.ViewsNLogado
{
    /// <summary>
    /// Interaction logic for CadastroNLogado.xaml
    /// </summary>
    public partial class CadastroNLogado : Window
    {
        public CadastroNLogado()
        {
            InitializeComponent();
        }

        //variável que receberá a decisão do RadioButton experiência
        private bool? dec = null;

        private void btnCadastroHomeNLogado_Click(object sender, RoutedEventArgs e)
        {
            CadastroNLogado cadastroNLogadoFechar = new CadastroNLogado();
            this.Close();

            IndexNLogado cadastroParaIndexNLogado = new IndexNLogado();
            cadastroParaIndexNLogado.Show();
        }

        private void btnCadastroCadastroNLogado_Click(object sender, RoutedEventArgs e)
        {
            CadastroNLogado cadastroNLogadoFechar = new CadastroNLogado();
            this.Close();

            cadastroNLogadoFechar.Show();
        }

        private void btnCadastroDenuncieNLogado_Click(object sender, RoutedEventArgs e)
        {
            CadastroNLogado cadastroNLogadoFechar = new CadastroNLogado();
            this.Close();

            DenuncieNLogado cadastroParaDenuncieNLogado = new DenuncieNLogado();
            cadastroParaDenuncieNLogado.Show();
        }

        private void btnCadastroContatosEmergenciaisNLogado_Click(object sender, RoutedEventArgs e)
        {
            CadastroNLogado cadastroNLogadoFechar = new CadastroNLogado();
            this.Close();

            Contatos_EmergenciaisNLogado cadastroParaContatosNLogado = new Contatos_EmergenciaisNLogado();
            cadastroParaContatosNLogado.Show();
        }

        private void btnCadastroDicasNLogado_Click(object sender, RoutedEventArgs e)
        {
            CadastroNLogado cadastroNLogadoFechar = new CadastroNLogado();
            this.Close();

            Dicas_de_SegurancaNLogado cadastroParaDicasNLogado = new Dicas_de_SegurancaNLogado();
            cadastroParaDicasNLogado.Show();
        }

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
