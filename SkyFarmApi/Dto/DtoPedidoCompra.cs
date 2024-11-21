using SkyFarmApi.entity;
using SkyFarmClasses;
using SkyFarmClasses.entidades;

namespace SkyFarmApi.Dto
{
    public class DtoPedidoCompra
    {
        
        public List<Produto> ListaProdutos { get; set; }
        public EntidadeAcessoSistema UsuarioLogado { get; set; }

        public List<EntidadeProduto> convertProdutoEntidade()
        {
            List<EntidadeProduto> lista= new List<EntidadeProduto>();
            foreach (Produto item in ListaProdutos)
            {
                EntidadeProduto novo = new EntidadeProduto();
                try
                {
                    novo.Nome = item.Nome;
                    novo.Valor = item.Valor;
                    novo.Quantidade = item.Quantidade;
                    novo.Medida = item.Medida;
                    
                    //novo.Bitmap = ImageProcessador.GetImageFromByteArray(item.Bitmap.);
                    novo.Codigo = item.Codigo;
                    novo.Descricao = item.Descricao;
                    lista.Add(novo);
                }
                catch (Exception e) { }
            }
            return lista;
        }
    }
}
