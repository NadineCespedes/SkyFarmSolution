using SkyFarmClasses;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyFarm
{
    public partial class GerenciarProduto : Form
    {
        EntidadeProduto produtoSelecionado;
        Size boxImageSize;
        public GerenciarProduto()
        {
            produtoSelecionado = new EntidadeProduto();
            
            InitializeComponent();
            boxImageSize = new Size(216, 111);
            Image image = bxImage.Image;            
            produtoSelecionado.Bitmap = image;
            setImageBox(image);
            carregaListaProduto();
        }

        private void carregaListaProduto()
        {
            boxProdutos.Items.Clear();

            RepositorioProduto repo = new RepositorioProduto();
            List<EntidadeProduto> entidadeAcessoSistemas = repo.carregarProdutos();

            object[] k = new object[entidadeAcessoSistemas.Count];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = new ItemBoxProduto(entidadeAcessoSistemas[i]);
            }
            boxProdutos.Items.AddRange(k);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bxImage_Click(object sender, EventArgs e)
        {
            dgAberturaImage.Title = "Imagem do produto";
            dgAberturaImage.ShowDialog();
            try {
                Stream stream = dgAberturaImage.OpenFile();
                Image mg = new Bitmap(stream);
                setImageBox(mg);
                produtoSelecionado.Bitmap = ImageProcessador.ResizeImage(mg, new System.Drawing.Size(169, 88));
            }
            catch(Exception ex){}
            
        }




        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            produtoSelecionado.Nome = txNome.Text;
            produtoSelecionado.Descricao = txDescricao.Text;
            produtoSelecionado.Codigo = txCodigo.Text;
            try
            {
                produtoSelecionado.Valor = float.Parse(txPreco.Text);
            }
            catch (Exception ex)
            {
                new BoxMessage("Houve um erro", "O valor [" + produtoSelecionado.Valor + "] deve ser número");
            }
            try
            {
                produtoSelecionado.Quantidade = Convert.ToInt32(txQuantidade.Text);
            }
            catch (Exception ex)
            {
                new BoxMessage("Houve um erro", "O Quantidade [" + produtoSelecionado.Quantidade + "] deve ser número");
                return;
            }
            if (produtoSelecionado.Id == null)
            {
                RepositorioProduto produto = new RepositorioProduto();
                produto.cadastrarNovo(produtoSelecionado);
                new BoxMessage("Sucesso no cadastro", " Novo produto cadastrado sem problemas!");
            }
            else
            {

                RepositorioProduto produto = new RepositorioProduto();
                produto.atualizar(produtoSelecionado);
                new BoxMessage("Sucesso na atualização", " Produto atualizado sem problemas!");
            }
            produtoSelecionado = new EntidadeProduto();
            populaCamposParaEditar(produtoSelecionado);
            carregaListaProduto();

        }

        private void boxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox bo = (ListBox)sender;
            object? selectedItem = bo.SelectedItem;
            if (selectedItem.GetType() == typeof(ItemBoxProduto))
            {
                ItemBoxProduto u = (ItemBoxProduto)selectedItem;
                RepositorioProduto rpFun = new RepositorioProduto();
                EntidadeProduto fun = rpFun.carregarProduto(u.Acesso);
                populaCamposParaEditar(fun);
                produtoSelecionado = fun;
            }
            else
            {
                new BoxMessage("Algo saiu errado", "Houve um problema ao carregar dados deste funcionario");
            }
        }
        private void populaCamposParaEditar(EntidadeProduto produto)
        {
            txNome.Text = produto.Nome;
            setImageBox(produto.Bitmap);
            txDescricao.Text = produto.Descricao;
            txPreco.Text = "" + produto.Valor;
            txQuantidade.Text = "" + produto.Quantidade;
            txCodigo.Text = produto.Codigo;
        }

        private void setImageBox(Image mg)
        {
            bxImage.Image = ImageProcessador.ResizeImage(mg, boxImageSize);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            produtoSelecionado = new EntidadeProduto();
            populaCamposParaEditar(produtoSelecionado);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            RepositorioProduto produto = new RepositorioProduto();
            produto.remover(produtoSelecionado);
            produtoSelecionado = new EntidadeProduto();
            populaCamposParaEditar(produtoSelecionado);
            carregaListaProduto();
        }
    }
}
