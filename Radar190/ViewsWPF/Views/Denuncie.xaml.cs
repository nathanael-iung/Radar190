using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica interna para Denuncie.xaml
    /// </summary>
    public partial class Denuncie : Window
    {
        public Denuncie()
        {
            InitializeComponent();
        }

        //Variável que receberá o conteúdo do TextBox idade
        private string idade;
        //Variável que receberá o resultado do radio button sexo
        private string sx;
        //Variável que receberá o conteúdo de Endereço
        private string numEndereco;
        //Variável que recebrá o valor do ComboBox bairro
        private string cbBairro;
        //variável que receberá o valor do ComboBox cidade;
        private string cbCidade;
        //Variáveis que recebrão a data e hora do ocorrido
        private string dt, hr, min, DataHora;
        //Variável que receberá o resultado do radio button B.O.
        private bool bo;
        //variável que receberá o valor do ComboBox TipoOcorrência
        private string cbTipoOcorrencia;
        //Variável que recebrá o valor do prejuízo
        private string preju;
        //Variável que recebrá o tipo da denpuncia - testemunha e vitima
        private string tip;
        

        private void btnDenuncieHome_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Index DenuncieparaHome = new Index();
            DenuncieparaHome.Show();
        }

        private void btnDenuncieCadastro_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Cadastro DenuncieparaCadastro = new Cadastro();
            DenuncieparaCadastro.Show();
        }

        private void btnDenuncieDenuncie_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Denuncie DenuncieparaDenuncie = new Denuncie();
            DenuncieparaDenuncie.Show();
        }

        private void btnDenuncieMapa_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Mapa DenuncieparaMapa = new Mapa();
            DenuncieparaMapa.Show();
        }

        private void btnDenuncieEstatisticas_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Estatisticas DenuncieparaEstatistica = new Estatisticas();
            DenuncieparaEstatistica.Show();
        }

        private void btnDenuncieChat_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Chat DenuncieparaChat = new Chat();
            DenuncieparaChat.Show();
        }

        private void btnDenuncieContatosEmergencias_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Contatos_Emergencias DenuncieparaContatosEmergenciais = new Contatos_Emergencias();
            DenuncieparaContatosEmergenciais.Show();
        }

        private void btnDenuncieDicas_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Dicas_de_Seguranca DenuncieparaDicas = new Dicas_de_Seguranca();
            DenuncieparaDicas.Show();
        }

        private void btnDenuncieFaleConosco_Click(object sender, RoutedEventArgs e)
        {
            Denuncie DenuncieFechar = new Denuncie();
            this.Close();

            Fale_Conosco DenuncieparaFaleConosco = new Fale_Conosco();
            DenuncieparaFaleConosco.Show();
        }

        private void rbDenuncieFeminino_Checked(object sender, RoutedEventArgs e)
        {
            sx = "fem";
        }

        private void rbDenuncieMasculino_Checked(object sender, RoutedEventArgs e)
        {
            sx = "masc";
        }

        private void rbDenuncieVitima_Checked(object sender, RoutedEventArgs e)
        {
            tip = "Vítima";
        }

        private void rbDenuncieTestemunha_Checked(object sender, RoutedEventArgs e)
        {
            tip = "Testemunha";
        }

        private void txtDenuncieNumero_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtDenuncieCPF_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtDenuncieIdade_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtDenuncieHorarioHoras_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtDenuncieHorarioMinutos_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtDenunciePrejuizo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);

        }

        /*
        private void cbDenuncieBairro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbBairro = cbDenuncieBairro.SelectedValue.ToString();
        }
        */

        private void rbDenuncieBOsim_Checked(object sender, RoutedEventArgs e)
        {
            bo = true;
        }

        private void rbDenuncieBOnao_Checked(object sender, RoutedEventArgs e)
        {
            bo = false;
        }

        private void cbDenuncieTipoOcorrencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbTipoOcorrencia = cbDenuncieTipoOcorrencia.SelectionBoxItem.ToString();
        }


        private void cbDenuncieCidade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbCidade = cbDenuncieCidade.SelectedValue.ToString();
        }

        private void dpDenuncieDataocorrido_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dt = dpDenuncieDataocorrido.ToString();
        }


        private void btnDenuncieDenunciar_Click(object sender, RoutedEventArgs e)
        {
            idade = txtDenuncieIdade.Text;
            numEndereco = txtDenuncieEndereco.Text;
            hr = txtDenuncieHorarioHoras.Text;
            min = txtDenuncieHorarioMinutos.Text;

            Denuncia denun = new Denuncia();
            Mapa maps = new Mapa();
            Bairro bairro = new Bairro();
            Cidade city = new Cidade();
            //Concatenação das strings de Data, Hora e minutos
            string Hora = string.Concat(txtDenuncieHorarioHoras.Text,":",txtDenuncieHorarioMinutos.Text);

            denun.NomeCompleto = txtDenuncieNome.Text;
            denun.Idade = Convert.ToInt16(idade);
            denun.Sexo = sx;
            denun.Tipo = tip;
            //maps.Endereco = txtDenuncieEndereco.Text;
            //maps.Numero = Convert.ToInt16(numEndereco);
            denun.CPF = txtDenuncieCPF.Text;
            //bairro.Distrito = cbBairro;
            //city.City = int.Parse(cbDenuncieCidade.SelectedValue.ToString());
            denun.Data = Convert.ToDateTime(dt);
            denun.Hora = Hora;
            denun.BO = bo;
            denun.TipoOcorrencia = cbTipoOcorrencia;
            denun.Prejuizo = txtDenunciePrejuizo.Text;
            denun.Descricao = txtDenuncieDetalhes.Text;

            Controller.DenunciaController denunController = new Controller.DenunciaController();
            denunController.Insert(denun);

            //Controller.MapaController mapController = new Controller.MapaController();
            //mapController.Insert(maps);

            //Controller.BairroController baiController = new Controller.BairroController();
            //baiController.Insert(bairro);

            //Controller.CidadeController cidController = new Controller.CidadeController();
            //cidController.Insert(city);

        }
    }
}
