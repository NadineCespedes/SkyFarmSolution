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
    public class RepositorioEscolariedade : Repositorio
    {
        private string[] colunas = { "id", "descricao" };
        public List<EntidadeEscolariedade> carregarUsuarios()
        {

            List<EntidadeEscolariedade> listaResultado = new List<EntidadeEscolariedade>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from grau_escola "
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadeEscolariedade entidade = new EntidadeEscolariedade();
                for (int contaColuna = 0; contaColuna < colunas.Length; contaColuna++)
                {
                    string colunaNome = colunas[contaColuna];
                    object? valor = valorDoBanco2(tbAc.Rows[contaLinha][colunaNome]);
                    popularFromDados(entidade, colunaNome, valor);

                }
                listaResultado.Add(entidade);
            }

            conexao.Close();
            return listaResultado;
        }

        private void popularFromDados(EntidadeEscolariedade entidade, string coluna, object valor)
        {
            if (valor == null) { return; }
            switch (coluna)
            {
                case "id": entidade.Id = Convert.ToInt16(valor); break;
                case "descricao": entidade.Descricao = Convert.ToString(valor); break;
            }
        }
    }
}
