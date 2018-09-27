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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        } 

        public string senhaUsuario;

        private void btnLoginEntrar_Click(object sender, RoutedEventArgs e)
        {
            Index ind = new Index();
            Controller.UsuarioController userController = new Controller.UsuarioController();
            senhaUsuario = pbLoginSenha.Password;
            //Caso o resultado de VerificaLogin seja true, o 1° Message box é exibido indicando o sucesso do Login
            if (userController.VerificaLogin(txtLoginNome.Text, senhaUsuario))
            {
                MessageBox.Show("Login efetuado com sucesso");
                this.Close();
                ind.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha inválido(a)");
            }
        }

        private void btnLoginCadastre_Click(object sender, RoutedEventArgs e)
        {
            Login lgn = new Login();
            this.Close();

            ViewsNLogado.CadastroNLogado loginParaCadastroNLogado = new ViewsNLogado.CadastroNLogado();
            loginParaCadastroNLogado.Show();
        }

        private void btnLoginAcessar_Click(object sender, RoutedEventArgs e)
        {
            Login lgn = new Login();
            this.Close();

            ViewsNLogado.IndexNLogado loginParaIndexNLogado = new ViewsNLogado.IndexNLogado();
            loginParaIndexNLogado.Show();
        }
    }
}
