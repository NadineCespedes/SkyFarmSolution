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
    public class RepositorioPedido : Repositorio
    {
        private string[] colunas = {
            "id",
            "id_sistema",
            "quantidade",
            "valor_total",
            "id_meio_pagamento",
            "id_frete"};


        public void cadastrarPedido(EntidadePedido sistema)
        {
            sistema.Id = ProximoId("pedido");
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "insert into pedido (id,id_sistema,quantidade,valor_total,id_meio_pagamento,id_frete) VALUES " +
                "(" +
                "@id,@id_sistema,@quantidade,@valor_total,@id_meio_pagamento,@id_frete" +
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
            cmd.Parameters.Add("id_sistema", SqlDbType.Int).Value = insereValorBanco(sistema.IdSistema);
            cmd.Parameters.Add("quantidade", SqlDbType.Int).Value = sistema.Quantidade;
            cmd.Parameters.Add("valor_total", SqlDbType.Float).Value = sistema.ValorTotal;
            cmd.Parameters.Add("id_meio_pagamento", SqlDbType.Int).Value = insereValorBanco(sistema.IdMeioPagamento);
            cmd.Parameters.Add("id_frete", SqlDbType.Int).Value = insereValorBanco(sistema.IdFrete);

            return cmd;
        }
}
}
