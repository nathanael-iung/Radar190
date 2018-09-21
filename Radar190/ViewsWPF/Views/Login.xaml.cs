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

        public bool logado;
        public string nomeUsuario;
        public string senhaUsuario;

        private void btnLoginEntrar_Click(object sender, RoutedEventArgs e)
        {
            Index ind = new Index();
            Controller.UsuarioController userController = new Controller.UsuarioController();
            senhaUsuario = pbLoginSenha.Password;
            //Caso o resultado de VerificaLogin seja true, o 1° Message box é exibido indicando o sucesso do Login
            if (userController.VerificaLogin(txtLoginNome.Text, senhaUsuario))
            {
                nomeUsuario = txtLoginNome.Text;
                logado = true;
                MessageBox.Show("Login efetuado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha inválido(a)");
                logado = false;
            }
        }
    }
}
