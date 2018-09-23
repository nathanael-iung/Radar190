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

        public int fkUsuario;
        //Variável que recebrá o tipo da denpuncia - testemunha e vitima
        private string tip;
        //Variável que receberá o resultado do radio button sexo
        private string sx;
        //Variável que receberá o resultado do radio button B.O.
        private bool bo;
        //Bool's que receberão o true ou false do CheckBox Objs Roubados
        private bool dinheiroBool = false;
        private bool carteiraBool = false;
        private bool documentosBool = false;
        private bool celularBool = false;
        private bool notebookBool = false;
        private bool outEletronicosBool = false;
        private bool motoBool = false;
        private bool veiculoBool = false;
        private bool outrosBool = false;

        #region "Botões de transição de telas"
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

            MapaView DenuncieparaMapa = new MapaView();
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
        #endregion

        #region "RadioButton Sexo"
        private void rbDenuncieFeminino_Checked(object sender, RoutedEventArgs e)
        {
            sx = "fem";
        }

        private void rbDenuncieMasculino_Checked(object sender, RoutedEventArgs e)
        {
            sx = "masc";
        }
        #endregion

        #region "Radiobutton Vítima ou Testemunha"
        private void rbDenuncieVitima_Checked(object sender, RoutedEventArgs e)
        {
            tip = "Vítima";
        }

        private void rbDenuncieTestemunha_Checked(object sender, RoutedEventArgs e)
        {
            tip = "Testemunha";
        }
        #endregion

        #region "Apenas números aceitos nos TextBox indicados"
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
        #endregion

        #region "RadioButton B.O.
        private void rbDenuncieBOsim_Checked(object sender, RoutedEventArgs e)
        {
            bo = true;
        }

        private void rbDenuncieBOnao_Checked(object sender, RoutedEventArgs e)
        {
            bo = false;
        }
        #endregion

        #region "Booleans CheckBox ObjsRoubados
        private void cbDenuncieDinheiro_Checked(object sender, RoutedEventArgs e)
        {
            dinheiroBool = true;
        }

        private void cbDenuncieCarteira_Checked(object sender, RoutedEventArgs e)
        {
            carteiraBool = true;
        }

        private void cbDenuncieDocumentos_Checked(object sender, RoutedEventArgs e)
        {
            documentosBool = true;
        }

        private void cbDenuncieCelular_Checked(object sender, RoutedEventArgs e)
        {
            celularBool = true;
        }

        private void cbDenuncieNotebook_Checked(object sender, RoutedEventArgs e)
        {
            notebookBool = true;
        }

        private void cbDenuncieOutrosEletronicos_Checked(object sender, RoutedEventArgs e)
        {
            outEletronicosBool = true;
        }

        private void cbDenuncieMotocicleta_Checked(object sender, RoutedEventArgs e)
        {
            motoBool = true;
        }

        private void cbDenuncieVeiculo_Checked(object sender, RoutedEventArgs e)
        {
            veiculoBool = true;
        }

        private void cbDenuncieOutros_Checked(object sender, RoutedEventArgs e)
        {
            outrosBool = true;
        }
        #endregion

        private void btnDenuncieDenunciar_Click(object sender, RoutedEventArgs e)
        {
            Controller.DenunciaController denunController = new Controller.DenunciaController();
            Denuncia denun = new Denuncia();

            fkUsuario = denunController.RetornaID(txtDenuncieNome.Text);

            denun.NomeCompleto = txtDenuncieNome.Text;
            denun.Idade = short.Parse(txtDenuncieIdade.Text);
            denun.Tipo = tip; //Bool com o tipo de ocorrência
            denun.Sexo = sx;
            denun.Endereco = txtDenuncieEndereco.Text;
            denun.Numero = short.Parse(txtDenuncieNumero.Text);
            denun.CPF = txtDenuncieCPF.Text;
            denun.Distrito = cbDenuncieBairro.SelectionBoxItem.ToString();
            denun.City = cbDenuncieCidade.SelectionBoxItem.ToString();
            denun.UF = ("PR");
            denun.Data = Convert.ToDateTime(dpDenuncieDataocorrido.SelectedDate.ToString()); //Conversão do DatePicker para DateTime
            denun.Hora = string.Concat(txtDenuncieHorarioHoras.Text, ":", txtDenuncieHorarioMinutos.Text); // Concatenação das strings de Hora e Minutos
            denun.BO = bo; //Bool com a resposta do CheckBox B.O.
            denun.TipoOcorrencia = cbDenuncieTipoOcorrencia.SelectionBoxItem.ToString();
            denun.Prejuizo = txtDenunciePrejuizo.Text;
            denun.Dinheiro = dinheiroBool; //Bool's do CheckBox Objs Roubados 
            denun.Carteira = carteiraBool;
            denun.Documentos = documentosBool;
            denun.Celular = celularBool;
            denun.Notebook = notebookBool;
            denun.OutrosEletronicos = outEletronicosBool;
            denun.Motocicleta = motoBool;
            denun.Veiculo = veiculoBool;
            denun.Outros = outrosBool;
            denun.Descricao = txtDenuncieDetalhes.Text;
            denun.UsuarioIdUsuario = fkUsuario;

            
            denunController.Insert(denun);

        }

        private void wwDenuncie_Loaded(object sender, RoutedEventArgs e)
        {
            //DenuncieNome.Content = cbDenuncieBairro.SelectedItem.ToString();
        }

        private void cbDenuncieBairro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DenuncieNome.Content = cbDenuncieBairro.SelectionBoxItem;
        }
    }
}
