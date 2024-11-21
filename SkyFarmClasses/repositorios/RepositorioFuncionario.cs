using Microsoft.Data.SqlClient;
using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.repositorios
{
    public class RepositorioFuncionario : Repositorio
    {
        private string[] colunasFuncionario = { "id", "id_pessoa", "id_sistema" };
        //private string[] colunasSistema = { "id", "email", "login" };
        private string[] colunasPessoa = { "id", "nome", "data_nascimento", "rg", "cpf", "id_estado_civil", "id_escolariedade", "filiacao" };

        public void cadastrarFuncionario(EntidadeFuncionario sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "insert into funcionario (id,id_pessoa,id_sistema) VALUES " +
                "(" +
                "@id,@pessoa,@sistema" +
                ")"
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }

        public void removerFuncionario(EntidadeFuncionario sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "delete from funcionario where id=@id";
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        private SqlCommand preparaCommand(EntidadeFuncionario sistema, SqlConnection conexao, string sqlString)
        {
            sistema.Id = ProximoId("funcionario");
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.Parameters.Add("pessoa", SqlDbType.Int).Value = sistema.Pessoa.Id;
            cmd.Parameters.Add("sistema", SqlDbType.Int).Value = sistema.Sistema.ID;
            return cmd;
        }
        public EntidadeFuncionario carregarFuncionario(EntidadeAcessoSistema acesso)
        {
            EntidadeFuncionario funcionario = new EntidadeFuncionario();
            funcionario.Sistema = acesso;
            funcionario.Pessoa = new EntidadePessoa();

            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from funcionario where " +
                "id_sistema = @id "
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = funcionario.Sistema.ID;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            if (tbAc.Rows.Count < 1)
            {
                conexao.Close();
                return null;
            }

            for (int contaColuna = 0; contaColuna < colunasFuncionario.Length; contaColuna++)
                {
                    string colunaNome = colunasFuncionario[contaColuna];
                    object valor = tbAc.Rows[0][colunaNome];
                    popularFromDados(funcionario, colunaNome, valor);

                }
                

            conexao.Close();

            RepositorioPessoa repositorioPessoa = new RepositorioPessoa();
            funcionario.Pessoa = repositorioPessoa.carregarPessoa(funcionario.Pessoa);
            return funcionario;

        }
        private void popularFromDados(EntidadeFuncionario entidade, string coluna, object valor)
        {
            if (valor == null) { return; }
            switch (coluna)
            {
                case "id": entidade.Id = Convert.ToInt16(valor); break;
                case "id_pessoa": entidade.Pessoa.Id = Convert.ToInt32(valor); break;
            }
        }
    }
    
}
