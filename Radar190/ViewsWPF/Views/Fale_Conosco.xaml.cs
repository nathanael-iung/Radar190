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
    /// Interaction logic for Fale_Conosco.xaml
    /// </summary>
    public partial class Fale_Conosco : Window
    {
        private int fkUsuario;

        public Fale_Conosco()
        {
            InitializeComponent();
        }

        #region "Botões de transição de telas"
        private void btnFaleConoscoHome_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Index FaleConoscoparaIndex = new Index();
            FaleConoscoparaIndex.Show();
        }

        private void btnFaleConoscoCadastro_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Cadastro FaleConoscoparaCadastro = new Cadastro();
            FaleConoscoparaCadastro.Show();
        }

        private void btnFaleConoscoDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Denuncie FaleConoscoparaDenuncie = new Denuncie();
            FaleConoscoparaDenuncie.Show();
        }

        private void btnFaleConoscoMapa_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            MapaForms FaleConoscoparaMapaForms = new MapaForms();
            FaleConoscoparaMapaForms.Show();
        }

        private void btnFaleConoscoEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Estatisticas FaleConoscoparaEstatisticas = new Estatisticas();
            FaleConoscoparaEstatisticas.Show();
        }

        private void btnFaleConoscoChat_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Chat FaleConoscoparaChat = new Chat();
            FaleConoscoparaChat.Show();
        }

        private void btnFaleConoscoContatosEmergenciais_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Contatos_Emergencias FaleConoscoparaContatosEmergencias = new Contatos_Emergencias();
            FaleConoscoparaContatosEmergencias.Show();
        }

        private void btnFaleConoscoDicas_Click(object sender, RoutedEventArgs e)
        {
            Fale_Conosco FaleConoscoFechar = new Fale_Conosco();
            this.Close();

            Dicas_de_Seguranca FaleConoscoparaDicas = new Dicas_de_Seguranca();
            FaleConoscoparaDicas.Show();
        }
        #endregion

        private void btnFaleConoscoEnviarMensagem_Click(object sender, RoutedEventArgs e)
        {
            FaleConosco feedback = new FaleConosco();
            Controller.FaleConoscoController feedController = new Controller.FaleConoscoController();

            // fkUsuario receberá  a ID do usuário cadastrado. Caso fkUsuario == 0, o mesmo não possui cadastro
            fkUsuario = feedController.RetornaID(txtFaleConoscoNome.Text);

            feedback.Nome = txtFaleConoscoNome.Text;
            feedback.Email = txtFaleConoscoEmail.Text;
            feedback.Assunto = txtFaleConoscoAssunto.Text;
            feedback.Mensagem = txtFaleConoscoMensagem.Text;
            feedback.UsuarioIdUsuario = fkUsuario;

            // Validação de campos em branco e permite apenas usuário cadastrados enviarem o feedback
            if (string.IsNullOrWhiteSpace(txtFaleConoscoNome.Text) || string.IsNullOrWhiteSpace(txtFaleConoscoEmail.Text) || string.IsNullOrWhiteSpace(txtFaleConoscoAssunto.Text) || string.IsNullOrWhiteSpace(txtFaleConoscoMensagem.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios");
            } 
            else if(fkUsuario != 0)
            {
                feedController.Insert(feedback);
                MessageBox.Show("Agradecemos a sua colaboração");
            } else 
            {
                MessageBox.Show("Não possui cadastro");
            }
        }
    }
}
