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

        public string user, senha;

        private void btnLoginEntrar_Click(object sender, RoutedEventArgs e)
        {
            user = txtLoginNome.Text;
            senha = pbLoginSenha.Password;

            Controller.UsuarioController userController = new Controller.UsuarioController();

            if (userController.VerificaLogin(user, senha))
            {
                MessageBox.Show("Login efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha inválido(a)");
            }
            this.Close();
        }
    }
}
