using SkyFarmClasses;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SkyFarm
{
    public partial class FormGerenciarFuncionarios : Form
    {
        public FormGerenciarFuncionarios()
        {
            InitializeComponent();
            carregaListaFuncionario();
            carregaComboEscolariedade();
            carregaComboEstadoCivil();
            formularioTravado();
        }

        private void formularioTravado()
        {
            txRG.Enabled = false;
            txCPF.Enabled = false;
            txDataNascimento.Enabled = false;
            txNome.Enabled = false;
            txFiliacao.Enabled = false;
            txUsuario.Enabled = false;
            txEmail.Enabled = false;
            txSenha.Enabled = false;
            cbEscola.Enabled = false;
            cbCivil.Enabled = false;
            btConfirma.Cursor = Cursors.No;
        }
        private void formularioHabilitado()
        {
            txRG.Enabled = true;
            txCPF.Enabled = true;
            txDataNascimento.Enabled = true;
            txNome.Enabled = true;
            txFiliacao.Enabled = true;
            txUsuario.Enabled = true;
            txEmail.Enabled = true;
            txSenha.Enabled = true;
            cbEscola.Enabled = true;
            cbCivil.Enabled = true;
            btConfirma.Cursor = Cursors.Default;
        }

        private void carregaListaFuncionario()
        {
            listFuncionario.Items.Clear();

            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            List<EntidadeAcessoSistema> entidadeAcessoSistemas = repo.carregarUsuarios();

            object[] k = new object[entidadeAcessoSistemas.Count];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new ItemBoxFuncionario(entidadeAcessoSistemas[i]);
            }
            listFuncionario.Items.AddRange(k);
        }

        private void listFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            formularioHabilitado();
            ListBox bo = (ListBox)sender;
            object? selectedItem = bo.SelectedItem;
            if (selectedItem.GetType() == typeof(ItemBoxFuncionario))
            {
                ItemBoxFuncionario u = (ItemBoxFuncionario)selectedItem;
                RepositorioFuncionario rpFun = new RepositorioFuncionario();
                EntidadeFuncionario fun = rpFun.carregarFuncionario(u.Acesso);
                populaCamposParaEditar(fun);
                funcionarioSelecionado = fun;
            }
            else
            {
                new BoxMessage("Algo saiu errado", "Houve um problema ao carregar dados deste funcionario");
            }
        }

        private void populaCamposParaEditar(EntidadeFuncionario funcionario)
        {
            if (funcionario.Pessoa is null) funcionario.Pessoa = new EntidadePessoa();
            txRG.Text = funcionario.Pessoa.RG;
            txCPF.Text = funcionario.Pessoa.Cpf;
            txDataNascimento.Text = funcionario.Pessoa.Data_nascimento;
            txNome.Text = funcionario.Pessoa.Nome;
            txFiliacao.Text = funcionario.Pessoa.Filiacao;

            txUsuario.Text = funcionario.Sistema.Login;
            txEmail.Text = funcionario.Sistema.Email;

            selecionaEstadoCivil(funcionario);
            selecionaEscolariedade(funcionario);
        }

        private void selecionaEstadoCivil(EntidadeFuncionario funcionario)
        {
            for (int i = 0; i < cbCivil.Items.Count; i++)
            {
                ItemBoxEstadoCivil? v = (ItemBoxEstadoCivil?)cbCivil.Items[i];
                if (v == null) { continue; }
                if (v.Acesso.Id == funcionario.Pessoa.EstadoCivil.Id)
                {

                    cbCivil.SelectedItem = v;
                    return;
                }
            }
            cbCivil.SelectedIndex = -1;
        }

        private void selecionaEscolariedade(EntidadeFuncionario funcionario)
        {
            for (int i = 0; i < cbEscola.Items.Count; i++)
            {
                ItemBoxEscolariedade? v = (ItemBoxEscolariedade?)cbEscola.Items[i];
                if (v == null) { continue; }
                if (v.Acesso.Id == funcionario.Pessoa.Escolariedade.Id)
                {

                    cbEscola.SelectedItem = v;
                    return;
                }
            }
            cbEscola.SelectedIndex = -1;
        }

        private void carregaComboEstadoCivil()
        {
            cbCivil.Items.Clear();
            RepositorioEstadoCivil repo = new RepositorioEstadoCivil();
            List<EntidadeEstadoCivil> entidadeAcessoSistemas = repo.carregarUsuarios();

            object[] k = new object[entidadeAcessoSistemas.Count];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new ItemBoxEstadoCivil(entidadeAcessoSistemas[i]);
            }
            cbCivil.Items.AddRange(k);
        }

        private void carregaComboEscolariedade()
        {
            cbEscola.Items.Clear();
            RepositorioEscolariedade repo = new RepositorioEscolariedade();
            List<EntidadeEscolariedade> entidadeAcessoSistemas = repo.carregarUsuarios();

            object[] k = new object[entidadeAcessoSistemas.Count];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new ItemBoxEscolariedade(entidadeAcessoSistemas[i]);
            }
            cbEscola.Items.AddRange(k);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        EntidadeFuncionario funcionarioSelecionado;
        private void btNovoFuncionario_Click(object sender, EventArgs e)
        {
            formularioHabilitado();
            CadastrarFuncionario cadastro = new CadastrarFuncionario();
            populaCamposParaEditar(cadastro.NovoFuncionario);
            funcionarioSelecionado = cadastro.NovoFuncionario;
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if (btConfirma.Cursor == Cursors.No) return;



            funcionarioSelecionado.Pessoa.RG = txRG.Text;
            funcionarioSelecionado.Pessoa.Cpf = txCPF.Text;
            funcionarioSelecionado.Pessoa.Data_nascimento = txDataNascimento.Text;
            funcionarioSelecionado.Pessoa.Nome = txNome.Text;
            funcionarioSelecionado.Pessoa.Filiacao = txFiliacao.Text;

            funcionarioSelecionado.Sistema.Login = txUsuario.Text;
            funcionarioSelecionado.Sistema.Senha = txSenha.Text;
            funcionarioSelecionado.Sistema.Email = txEmail.Text;


            ItemBoxEstadoCivil? v = (ItemBoxEstadoCivil?)cbCivil.SelectedItem;
            funcionarioSelecionado.Pessoa.EstadoCivil = v.Acesso;
            ItemBoxEscolariedade? cbesc = (ItemBoxEscolariedade?)cbEscola.SelectedItem;
            funcionarioSelecionado.Pessoa.Escolariedade = cbesc != null ? cbesc.Acesso : new EntidadeEscolariedade();
            CadastrarFuncionario cadastro = new CadastrarFuncionario();
            populaCamposParaEditar(cadastro.NovoFuncionario);
            try
            {
                if (funcionarioSelecionado.Id is not null)
                {

                    cadastro.NovoFuncionario = funcionarioSelecionado;
                    cadastro.atualizar();
                    new BoxMessage("Atualização com sucesso", "Dados do funcionario atualizados!");
                }
                else
                {
                    cadastro.NovoFuncionario = funcionarioSelecionado;
                    cadastro.registrar();
                    new BoxMessage("Registro com sucesso", "Dados do funcionario registrados!");
                }

            }
            catch (Exception ex)
            {
                new BoxMessage("Houve um erro no cadastramento", "Verifique com o administrador do sistema");
            }


            formularioTravado();
            carregaListaFuncionario();


        }

        private void btRemoverFuncionario_Click(object sender, EventArgs e)
        {
            if(funcionarioSelecionado == null || funcionarioSelecionado.Id == null)
            {
                new BoxMessage("Erro ao remover funcionario", "Selecione um funcionario já cadastrado para remover");
                return;
            }

            CadastrarFuncionario cadastro = new CadastrarFuncionario();
            populaCamposParaEditar(cadastro.NovoFuncionario);
            //try
            //{
               
                cadastro.NovoFuncionario = funcionarioSelecionado;
                cadastro.remover();
                new BoxMessage("Atualização com sucesso", "Dados do funcionario removido com sucesso!");
                
            //}
            //catch (Exception ex)
            //{
            //    new BoxMessage("Houve um erro no cadastramento", "Verifique com o administrador do sistema");
            //}


            formularioTravado();
            carregaListaFuncionario();
        }
    }
}
