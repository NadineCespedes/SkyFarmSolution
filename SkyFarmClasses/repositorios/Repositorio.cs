using Microsoft.Data.SqlClient;
using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.repositorios
{
    public class Repositorio
    {

        public object? valorDoBanco2(object valorDoBanco)
        {
            return System.DBNull.Value.Equals (valorDoBanco) ? null :valorDoBanco;
        }

        public object? insereValorBanco(object? valorDoBanco)
        {
            return (object?)valorDoBanco ?? DBNull.Value;
        }
     
        public int ProximoId(string tabela)
        {
            int proximoId = 0;
            
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "select " +
                "CASE WHEN MAX(id) is null THEN 1 ELSE MAX(id)+1 END id_next " +
                "from  "+tabela;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            object valor = tbAc.Rows[0]["id_next"];
            if (valor == null) throw new Exception("Erro ao carregar proximo ID");
            proximoId = Convert.ToInt32(valor);
            conexao.Close();
            return proximoId;
        }
    }
}
