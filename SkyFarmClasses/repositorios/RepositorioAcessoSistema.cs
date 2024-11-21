using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyFarmClasses;
using SkyFarmClasses.entidades;
namespace SkyFarmClasses.repositorios
{
    public class RepositorioAcessoSistema : Repositorio
    {
        private string[] colunas = { "id", "email","login" };

        public void cadastrarUsuario(EntidadeAcessoSistema sistema)
        {
            sistema.ID = ProximoId("acesso_sistema");
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "insert into acesso_sistema (id,login,senha,email) VALUES " +
                "(" +
                "@id,@login,@senha,@email) "
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }

        public void atualizarUsuario(EntidadeAcessoSistema sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "update acesso_sistema SET login =@login,senha=@senha,email=@email " +
                "where id=@id"
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        public void removerUsuario(EntidadeAcessoSistema sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "delete from acesso_sistema where id=@id"
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.ID;
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        public EntidadeAcessoSistema carregarUsuario(EntidadeAcessoSistema sistema)
        {

            List<EntidadeAcessoSistema> listaResultado = new List<EntidadeAcessoSistema>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from acesso_sistema where " +
                "(email = @email or login = @login) "
                + "and senha   = @senha"
                ;
            SqlCommand cmd = preparaCommandSelect(sistema, conexao, sqlString);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadeAcessoSistema entidade = new EntidadeAcessoSistema();
                for (int contaColuna = 0; contaColuna < colunas.Length; contaColuna++)
                {
                    string colunaNome = colunas[contaColuna];
                    object valor = tbAc.Rows[contaLinha][colunas[contaColuna]];
                    popularFromDados(entidade, colunaNome, valor);

                }
                listaResultado.Add(entidade);
            }


            conexao.Close();
            if(listaResultado.Count < 1)
            {
                return null;
            }
            return listaResultado.First();
        }

        public List<EntidadeAcessoSistema> carregarUsuarios()
        {

            List<EntidadeAcessoSistema> listaResultado = new List<EntidadeAcessoSistema>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from acesso_sistema " 
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadeAcessoSistema entidade = new EntidadeAcessoSistema();
                for (int contaColuna = 0; contaColuna < colunas.Length; contaColuna++)
                {
                    string colunaNome = colunas[contaColuna];
                    object valor = tbAc.Rows[contaLinha][colunas[contaColuna]];
                    popularFromDados(entidade, colunaNome, valor);

                }
                listaResultado.Add(entidade);
            }

            conexao.Close();
            return listaResultado;
        }

        private SqlCommand preparaCommand(EntidadeAcessoSistema sistema, SqlConnection conexao, string sqlString)
        {
            
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.ID;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = sistema.Email;
            cmd.Parameters.Add("login", SqlDbType.VarChar).Value = sistema.Login;
            cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = sistema.Senha;
            return cmd;
        }
        private static SqlCommand preparaCommandSelect(EntidadeAcessoSistema sistema, SqlConnection conexao, string sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = sistema.Login;
            cmd.Parameters.Add("login", SqlDbType.VarChar).Value = sistema.Email;
            cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = sistema.Senha;
            return cmd;
        }

        private void popularFromDados(EntidadeAcessoSistema entidade, string coluna, object valor)
        {
            if (valor == null) { return; }
            switch (coluna)
            {
                case "id": entidade.ID = Convert.ToInt16(valor); break;
                case "email": entidade.Email = Convert.ToString(valor); break;
                case "login": entidade.Login = Convert.ToString(valor); break;
            }
        }
    }
}
