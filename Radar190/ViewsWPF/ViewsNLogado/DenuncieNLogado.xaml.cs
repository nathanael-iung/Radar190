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

namespace ViewsWPF.ViewsNLogado
{
    /// <summary>
    /// Interaction logic for DenuncieNLogado.xaml
    /// </summary>
    public partial class DenuncieNLogado : Window
    {
        public DenuncieNLogado()
        {
            InitializeComponent();
        }

        public int? fkUsuario; // Recebrá o ID do usuário cadastrado
        
        private string tip; // Variável que recebrá o tipo da denpuncia - testemunha e vitima
        
        private string sx; // Variável que receberá o resultado do radio button sexo
        
        private bool bo; // Variável que receberá o resultado do radio button B.O.

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
        private void btnDenuncieHomeNLogado_Click(object sender, RoutedEventArgs e)
        {
            DenuncieNLogado denuncieNLogadoFechar = new DenuncieNLogado();
            this.Close();

            IndexNLogado denuncieParaIndexNLogado = new IndexNLogado();
            denuncieParaIndexNLogado.Show();
        }

        private void btnDenuncieCadastroNLogado_Click(object sender, RoutedEventArgs e)
        {
            DenuncieNLogado denuncieNLogadoFechar = new DenuncieNLogado();
            this.Close();

            CadastroNLogado denuncieParaCadastroNLogado = new CadastroNLogado();
            denuncieParaCadastroNLogado.Show();
        }

        private void btnDenuncieDenuncieNLogado_Click(object sender, RoutedEventArgs e)
        {
            DenuncieNLogado denuncieNLogadoFechar = new DenuncieNLogado();
            this.Close();

            denuncieNLogadoFechar.Show();
        }

        private void btnDenuncieContatosEmergenciaisNLogado_Click(object sender, RoutedEventArgs e)
        {
            DenuncieNLogado denuncieNLogadoFechar = new DenuncieNLogado();
            this.Close();

            Contatos_EmergenciaisNLogado denuncieParaContatosNLogado = new Contatos_EmergenciaisNLogado();
            denuncieParaContatosNLogado.Show();
        }

        private void btnDenuncieDicasNLogado_Click(object sender, RoutedEventArgs e)
        {
            DenuncieNLogado denuncieNLogadoFechar = new DenuncieNLogado();
            this.Close();

            Dicas_de_SegurancaNLogado denuncieParaDicasNLogado = new Dicas_de_SegurancaNLogado();
            denuncieParaDicasNLogado.Show();
        }
        #endregion

        #region "RadioButton Sexo"
        // sx recebe o valor que foi Checkado
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
        // tip recebe o valor que foi Checkado
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
        // bo recebe o valor que for Checkado
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
        // Bool's que forem marcado receberão true
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

            // fkUsuario receberá o Id do usuário cadastrado
            fkUsuario = denunController.RetornaID(txtDenuncieNome.Text);

            if (denunController.RetornaID(txtDenuncieNome.Text) == 0)
            {
                //Caso o retorno de ResultaID seja 0, fkUsuario será null
                fkUsuario = null;
            }

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

            // Validações para não permitir o cadastro de campos em branco
            if (string.IsNullOrWhiteSpace(txtDenuncieNome.Text) || (rbDenuncieTestemunha.IsChecked == false && rbDenuncieVitima.IsChecked == false) || string.IsNullOrWhiteSpace(txtDenuncieEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtDenuncieNumero.Text) || string.IsNullOrWhiteSpace(txtDenuncieCPF.Text) || cbDenuncieBairro.SelectionBoxItem.ToString().Equals("") || cbDenuncieCidade.SelectionBoxItem.ToString().Equals("") ||
                dpDenuncieDataocorrido.SelectedDate == null || cbDenuncieTipoOcorrencia.SelectionBoxItem.ToString().Equals("") || string.IsNullOrWhiteSpace(txtDenuncieHorarioHoras.Text) || string.IsNullOrWhiteSpace(txtDenuncieHorarioMinutos.Text))
            {
                MessageBox.Show("Campos obrigatórios não preenchidos. (marcados com *)");
            }
            else
            {
                denunController.Insert(denun);
                MessageBox.Show("Denúncia cadastrada com sucesso.");
            }
        }
    }
}
