using SkyFarmApi.entity;
using SkyFarmClasses;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System.Collections.Generic;

namespace SkyFarmApi.Dto
{
    public class DtoProduto
    {
        public List<Produto> listaProduto()
        {
            List<Produto> lista= new List<Produto>();
            
            foreach (EntidadeProduto item in new RepositorioProduto().carregarProdutos()){
                lista.Add(converterEntidade(item));
            }
            return lista;
        }
        private Produto converterEntidade(EntidadeProduto entity)
        {
            Produto novo = new Produto();
            novo.Nome = entity.Nome;
            novo.Codigo = entity.Codigo;
            novo.Quantidade = entity.Quantidade;
            novo.Medida = entity.Medida;
            novo.Valor = entity.Valor;
            novo.Descricao = entity.Descricao;
            novo.Quantidade = entity.Quantidade;
            if(entity.Bitmap != null) novo.Bitmap = ImageProcessador.CopyImageToByteArray(entity.Bitmap).ToString();
            return novo;
        }

      
    }
}
