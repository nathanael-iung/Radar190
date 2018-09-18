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

        private void btnCadastroCadastrar_Click(object sender, RoutedEventArgs e)
        {
            /*

            //Exemplo de cadastro no Banco de Dados. Nome completo, Descrição e Captcha da tela Cadastro estão jogando os dados
            //respectivamente em Nome, Usuário e Senha da tabela Administador do BD apenas como exemplo de teste
            Administrador admin = new Administrador();
            admin.Nome = txtCadastroNome.Text;
            admin.Usuario = txtCadastroDescricao.Text;
            admin.Senha = txtCadastroCaptcha.Text;

            using (BDRadarContainer contexto = new BDRadarContainer())
            {
                //Função da classe controller. Adição do objeto e salvamento das mudanças
                contexto.AdministradorSet.Add(admin);
                contexto.SaveChanges();
            }

            */

            //Converter o PasswordBox em String
            string senha = txtCadastroSenha.Password;
            //Boolean para Sim ou Não
            bool dec;

            if (cbCadastroCidade.Items.Equals("Sim"))
            {
                dec = true;
            }
            else if (cbCadastroCidade.Items.Equals("Não"))
            {
                dec = false;
            }
            else
            {
                dec = false;
            }

            Usuario user = new Usuario();
            Cidade city = new Cidade();
            user.NomeCompleto = txtCadastroNome.Text;
            user.DtNasc = Convert.ToDateTime(txtCadastroData.Text);
            user.Experiencia = dec;
            user.Descricao = txtCadastroDescricao.Text;
            user.User = txtCadastroUsuario.Text;
            user.Senha = Convert.ToInt16(senha);
            user.CidadeIdCidade = city.IdCidade;

            Controller.UsuarioController dt = new Controller.UsuarioController();
            dt.Insert(user);

            using (BDRadarContainer contexto = new BDRadarContainer())
            {
                //Função da classe controller. Como chamar o UsuarioController??
                contexto.UsuarioSet.Add(user);
                contexto.SaveChanges();
            }
             
           
            
        }

        
    }
}
