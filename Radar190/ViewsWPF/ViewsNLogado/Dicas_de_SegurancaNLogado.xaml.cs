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
    /// Interaction logic for Dicas_de_SegurancaNLogado.xaml
    /// </summary>
    public partial class Dicas_de_SegurancaNLogado : Window
    {
        public Dicas_de_SegurancaNLogado()
        {
            InitializeComponent();
        }

        private void btnHomeHomeNLogado_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_SegurancaNLogado dicasNLogadoFechar = new Dicas_de_SegurancaNLogado();
            this.Close();

            IndexNLogado dicasParaIndexNLogado = new IndexNLogado();
            dicasParaIndexNLogado.Show();
        }

        private void btnHomeCadastroNLogado_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_SegurancaNLogado dicasNLogadoFechar = new Dicas_de_SegurancaNLogado();
            this.Close();

            CadastroNLogado dicasParaCadastroNLogado = new CadastroNLogado();
            dicasParaCadastroNLogado.Show();
        }

        private void btnHomeDenuncieNLogado_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_SegurancaNLogado dicasNLogadoFechar = new Dicas_de_SegurancaNLogado();
            this.Close();

            DenuncieNLogado dicasParaDenuncieNLogado = new DenuncieNLogado();
            dicasParaDenuncieNLogado.Show();
        }

        private void btnHomeContatosEmergenciaisNLogado_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_SegurancaNLogado dicasNLogadoFechar = new Dicas_de_SegurancaNLogado();
            this.Close();

            Contatos_EmergenciaisNLogado dicasParaContatosNLogado = new Contatos_EmergenciaisNLogado();
            dicasParaContatosNLogado.Show();
        }

        private void btnHomeDicasNLogado_Click(object sender, RoutedEventArgs e)
        {
            Dicas_de_SegurancaNLogado dicasNLogadoFechar = new Dicas_de_SegurancaNLogado();
            this.Close();

            dicasNLogadoFechar.Show();
        }

        private void wwDicasSeguracaNLogado_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.DicasSegurancaController dicasController = new Controller.DicasSegurancaController();

            dgDicasSegurancaLista.ItemsSource = dicasController.ListDicasSeguranca();
        }
    }
}
