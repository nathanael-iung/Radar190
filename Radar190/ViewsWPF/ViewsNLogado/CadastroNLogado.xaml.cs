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
    }
}
