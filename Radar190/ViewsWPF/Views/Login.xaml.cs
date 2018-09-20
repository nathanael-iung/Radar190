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

        private void btnLoginEntrar_Click(object sender, RoutedEventArgs e)
        {
            Controller.UsuarioController userController = new Controller.UsuarioController();

            //Caso o resultado de VerificaLogin seja true, o 1° Message box é exibido indicando o sucesso do Login
            if (userController.VerificaLogin(txtLoginNome.Text, pbLoginSenha.Password))
            {
                MessageBox.Show("Login efetuado com sucesso");
                this.Close();
                logado = true;
                nomeUsuario = txtLoginNome.Text;
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha inválido(a)");
                logado = false;
            }
        }
    }
}
