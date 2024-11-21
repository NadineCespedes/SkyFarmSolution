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
    public class RepositorioPessoa :Repositorio
    {
        private string[] colunasPessoa = { "id", "nome", "data_nascimento",
            "rg", "cpf", "id_estado_civil", "id_escolariedade", "filiacao" };

        public void cadastrarPessoa(EntidadePessoa sistema)
        {
            

            sistema.Id = ProximoId("pessoa");
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "INSERT INTO pessoa " +
                "(id ,nome ,data_nascimento ,rg ,cpf ,id_estado_civil ,id_escolariedade ,filiacao) " +
                "VALUES " +
                "(@id  ,@nome ,@data_nascimento ,@rg  ,@cpf  ,@id_estado_civil ,@id_escolariedade ,@filiacao ) "
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }


        public void atualizarPessoa(EntidadePessoa sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "UPDATE pessoa SET " +
                " nome = @nome,data_nascimento =@data_nascimento ,rg=@rg ,cpf =@cpf ,id_estado_civil=@id_estado_civil ,id_escolariedade=@id_escolariedade ,filiacao=@filiacao " +
                " WHERE id = @id ";
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }

        public void removerPessoa(EntidadePessoa sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "delete from pessoa WHERE id = @id ";
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }



        private SqlCommand preparaCommand(EntidadePessoa sistema, SqlConnection conexao, string sqlString)
        {
            
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = sistema.Nome;
            cmd.Parameters.Add("data_nascimento", SqlDbType.VarChar).Value = sistema.Data_nascimento;
            cmd.Parameters.Add("rg", SqlDbType.VarChar).Value = sistema.RG;
            cmd.Parameters.Add("cpf", SqlDbType.VarChar).Value = sistema.Cpf;
            cmd.Parameters.Add("id_estado_civil", SqlDbType.Int).Value = insereValorBanco(sistema.EstadoCivil.Id);
            cmd.Parameters.Add("id_escolariedade", SqlDbType.Int).Value = insereValorBanco(sistema.Escolariedade.Id);
            cmd.Parameters.Add("filiacao", SqlDbType.VarChar).Value = sistema.Filiacao;
            
            return cmd;
        }


        public EntidadePessoa carregarPessoa(EntidadePessoa sistema)
        {

            List<EntidadePessoa> listaResultado = new List<EntidadePessoa>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from pessoa where " +
                "id = @id "
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadePessoa entidade = new EntidadePessoa();
                entidade.Escolariedade = new EntidadeEscolariedade();
                entidade.EstadoCivil = new EntidadeEstadoCivil();
                for (int contaColuna = 0; contaColuna < colunasPessoa.Length; contaColuna++)
                {
                    string colunaNome = colunasPessoa[contaColuna];
                    object? valor = valorDoBanco2(tbAc.Rows[contaLinha][colunaNome]);
                    popularFromDados(entidade, colunaNome, valor);

                }
                listaResultado.Add(entidade);
            }

            conexao.Close();
            if (listaResultado.Count == 1) return listaResultado.First();
            return null;
        }

        private void popularFromDados(EntidadePessoa entidade, string coluna, object? valor)
        {
            
           //entidade.EstadoCivil = new EntidadeEstadoCivil();
            //if (valor is null) { return; }
            switch (coluna)
            {
                case "id": entidade.Id = Convert.ToInt16(valor); break;
                case "nome": entidade.Nome = Convert.ToString(valor); break;
                case "data_nascimento": entidade.Data_nascimento = Convert.ToString(valor); break;
                case "rg": entidade.RG = Convert.ToString(valor); break;
                case "cpf": entidade.Cpf = Convert.ToString(valor); break;
                case "id_estado_civil": entidade.EstadoCivil.Id = Convert.ToInt32(valor); break;
                case "id_escolariedade": entidade.Escolariedade.Id = Convert.ToInt32(valor); break;
                case "filiacao": entidade.Filiacao = Convert.ToString(valor); break;
            }
        }
    }
}
