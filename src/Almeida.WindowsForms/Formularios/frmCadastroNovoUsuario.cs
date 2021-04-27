using Almeida.Application.Interfaces;
using Almeida.Application.ViewModels;
using System;
using System.Windows.Forms;

namespace Almeida.WindowsForms.Formularios
{
    public partial class frmCadastroNovoUsuario : Form
    {
        private readonly IPessoaServices _pessoaServices;
        private readonly IAtividadeServices _atividadeServices;
        public frmCadastroNovoUsuario(IPessoaServices pessoaServices, IAtividadeServices atividadeServices)
        {
            _pessoaServices = pessoaServices;
            _atividadeServices = atividadeServices;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }



        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                PessoaViewModel pessoa = new PessoaViewModel();
                pessoa.Nome = txtNome.Text;
                pessoa.Documento = txtCpf.Text.Replace(".", "").Replace("-", "");
                pessoa.Telefone = txtFone.Text.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "");
                var data = DateTime.ParseExact(txtNasc.Text, "dd/MM/yyyy", null);
                var dataConvertida = data.ToString("yyyy-MM-dd  HH:mm:ss");
                pessoa.DataNascimento = Convert.ToDateTime(dataConvertida);
                pessoa.Email = txtEmail.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.DataCriacao = DateTime.Now;
                pessoa.DataAlteracao = DateTime.Now;
                pessoa.Ativo = true;
                pessoa.Peso = Convert.ToDecimal(txtPeso.Text);
                pessoa.Altura = Convert.ToDecimal(txtAltura.Text);


                if (radioF.Checked)
                {
                    pessoa.Sexo = 'F';
                }
                else
                {
                    if (radioM.Checked)
                    {
                        pessoa.Sexo = 'M';
                    }
                }

                AtividadeViewModel atividade = new AtividadeViewModel();
                atividade.Valor = 50;
                atividade.VigenciaInicio = DateTime.Now;
                atividade.VigenciaFim = null;
                atividade.DataCriacao = DateTime.Now;
                atividade.DataAlteracao = null;
                atividade.Ativo = true;


                bool checkList;
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    checkList = true;
                }
                else
                {
                    checkList = false;
                }

                if (txtNome.Text == "" || txtCpf.Text == "" || txtNasc.Text == "" || txtEmail.Text == "" || radioF.Checked == false && radioM.Checked == false || checkList == false)
                {
                    MessageBox.Show("Por Favor. Preencha os campos obrigatórios '*'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    foreach (string lista in checkedListBox1.CheckedItems)
                    {
                        atividade.Descricao = lista;
                        _atividadeServices.SalvarAtividade(atividade);
                    }
                    var result = MessageBox.Show("Tudo certo, deseja prosseguir com o cadastro?", "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _pessoaServices.SalvarPessoa(pessoa);
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {

            }

        }
    }
}