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
    /// Interaction logic for IndexNLogado.xaml
    /// </summary>
    public partial class IndexNLogado : Window
    {
        public IndexNLogado()
        {
            InitializeComponent();
        }

        private void btnHomeHomeNLogado_Click(object sender, RoutedEventArgs e)
        {
            IndexNLogado IndexNLogadoFechar = new IndexNLogado();
            this.Close();

            IndexNLogadoFechar.Show();
        }

        private void btnHomeCadastroNLogado_Click(object sender, RoutedEventArgs e)
        {
            IndexNLogado IndexNLogadoFechar = new IndexNLogado();
            this.Close();

            CadastroNLogado IndexNLogadoParaCadastroNLogado = new CadastroNLogado();
            IndexNLogadoParaCadastroNLogado.Show();
        }

        private void btnHomeDenuncieNLogado_Click(object sender, RoutedEventArgs e)
        {
            IndexNLogado IndexNLogadoFechar = new IndexNLogado();
            this.Close();

            DenuncieNLogado IndexNLogadoParaDenuncieNLogado = new DenuncieNLogado();
            IndexNLogadoParaDenuncieNLogado.Show();
        }

        private void btnHomeContatosEmergenciaisNLogado_Click(object sender, RoutedEventArgs e)
        {
            IndexNLogado IndexNLogadoFechar = new IndexNLogado();
            this.Close();

            Contatos_EmergenciaisNLogado IndexNLogadoParaContatosNLogado = new Contatos_EmergenciaisNLogado();
            IndexNLogadoParaContatosNLogado.Show();
        }

        private void btnHomeDicasNLogado_Click(object sender, RoutedEventArgs e)
        {
            IndexNLogado IndexNLogadoFechar = new IndexNLogado();
            this.Close();

            Dicas_de_SegurancaNLogado IndexNLogadoParaDicasNLogado = new Dicas_de_SegurancaNLogado();
            IndexNLogadoParaDicasNLogado.Show();

        }
    }
}
