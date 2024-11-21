using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses
{
    public class RegistrarPedido
    {
        EntidadeAcessoSistema usuarioLogado;
        List<EntidadeProduto> convertProdutoEntidade;
        public void produtos(List<EntidadeProduto> convertProdutoEntidade)
        {
            this.convertProdutoEntidade = convertProdutoEntidade;
        }

        public void usuario(EntidadeAcessoSistema usuarioLogado)
        {
            this.usuarioLogado = usuarioLogado;
        }
        public void registrar()
        {
            RepositorioPedido repo = new RepositorioPedido();
            EntidadePedido pedido = new EntidadePedido();
            pedido.Quantidade = 1;
            pedido.ValorTotal = float.Parse("1.1");
            repo.cadastrarPedido(pedido);
        }
    }
}
