using Microsoft.Data.SqlClient;
using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.repositorios
{
    public class RepositorioPedidoItens :Repositorio
    {
        private string[] colunas = {
            "id",
            "id_produto",
            "id_pedido"};


        public void cadastrarPedido(EntidadePedido sistema)
        {
            sistema.Id = ProximoId("pedido");
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "insert into pedido (id,id_produto,id_pedido) VALUES " +
                "(" +
                "@id,@id_produto,@id_pedido" +
                ") "
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        private SqlCommand preparaCommand(EntidadePedido sistema, SqlConnection conexao, string sqlString)
        {
            sistema.Id_produto = null;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.Parameters.Add("id_produto", SqlDbType.Int).Value = insereValorBanco(sistema.IdSistema);
            cmd.Parameters.Add("id_pedido", SqlDbType.Int).Value = insereValorBanco(sistema.IdMeioPagamento);
            cmd.Parameters.Add("id_frete", SqlDbType.Int).Value = insereValorBanco(sistema.IdFrete);

            return cmd;
        }
    }

}
