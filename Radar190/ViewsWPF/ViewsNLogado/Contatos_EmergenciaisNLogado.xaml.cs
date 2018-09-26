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
    /// Interaction logic for Contatos_EmergenciaisNLogado.xaml
    /// </summary>
    public partial class Contatos_EmergenciaisNLogado : Window
    {
        public Contatos_EmergenciaisNLogado()
        {
            InitializeComponent();
        }

        private void btnContatosHomeNLogado_Click(object sender, RoutedEventArgs e)
        {
            Contatos_EmergenciaisNLogado contatosNLogadoFechar = new Contatos_EmergenciaisNLogado();
            this.Close();

            IndexNLogado contatosParaIndexNLogado = new IndexNLogado();
            contatosParaIndexNLogado.Show();
        }

        private void btnContatosCadastroNLogado_Click(object sender, RoutedEventArgs e)
        {
            Contatos_EmergenciaisNLogado contatosNLogadoFechar = new Contatos_EmergenciaisNLogado();
            this.Close();

            CadastroNLogado contatosParaCadastroNLogado = new CadastroNLogado();
            contatosParaCadastroNLogado.Show();
        }

        private void btnContatosDenuncieNLogado_Click(object sender, RoutedEventArgs e)
        {
            Contatos_EmergenciaisNLogado contatosNLogadoFechar = new Contatos_EmergenciaisNLogado();
            this.Close();

            DenuncieNLogado contatosParaDenuncieNLogado = new DenuncieNLogado();
            contatosParaDenuncieNLogado.Show();
        }

        private void btnContatosContatosEmergenciaisNLogado_Click(object sender, RoutedEventArgs e)
        {
            Contatos_EmergenciaisNLogado contatosNLogadoFechar = new Contatos_EmergenciaisNLogado();
            this.Close();

            contatosNLogadoFechar.Show();
        }

        private void btnContatosDicasNLogado_Click(object sender, RoutedEventArgs e)
        {
            Contatos_EmergenciaisNLogado contatosNLogadoFechar = new Contatos_EmergenciaisNLogado();
            this.Close();

            Dicas_de_SegurancaNLogado contatosParaDicasNLogado = new Dicas_de_SegurancaNLogado();
            contatosParaDicasNLogado.Show();
        }

        private void wwContatosNLogado_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.ContatosEmergenciaisController contatosController = new Controller.ContatosEmergenciaisController();

            dgContatosEmergenciaisLista.ItemsSource = contatosController.ListContatosEmergenciais();
        }
    }
}
