
using SkyFarmClasses;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System.Collections.Generic;

namespace SkyFarm
{
    public partial class FormPrincipal : Form
    {
        private EntidadeAcessoSistema usuarioLogado;
        public FormPrincipal()
        {
            InitializeComponent();
            FormLogin novo = new FormLogin(this);
            novo.Show();
            usuarioLogado = null;
            painelLogado.Visible = false;
            boxLogo.Image = ImageProcessador.ResizeImage(boxLogo.Image,new Size(127,72));
            btCliente.Visible = false;
        }

        internal void setUsuarioLogado(EntidadeAcessoSistema entidadeAcessoSistema)
        {
            this.usuarioLogado = entidadeAcessoSistema;
            painelLogado.Show();
            EntidadeFuncionario entidadeFuncionario = carregaFuncionario();
            lbIdentificaUsuario.Text = "Seja bem vindo " + entidadeFuncionario.Pessoa.Nome;
            //btProduto.Visible = false;
        }

        private EntidadeFuncionario carregaFuncionario()
        {
            RepositorioFuncionario repo = new RepositorioFuncionario();
            return repo.carregarFuncionario(usuarioLogado);
        }

       

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            new FormGerenciarFuncionarios().Show();
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            new GerenciarProduto().Show();
        }
    }
}
