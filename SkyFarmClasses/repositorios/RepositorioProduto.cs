using Microsoft.Data.SqlClient;
using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.repositorios
{
    public class RepositorioProduto :Repositorio
    {
        private string[] colunasPessoa = { "id","nome", "bitmap", "descricao", "codigo"
                , "preco" };

        public void remover(EntidadeProduto sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "delete from produto where id = @id "
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        public void atualizar(EntidadeProduto sistema)
        {
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "update produto SET nome=@nome, bitmap=@bitmap where id = @id "
                ;
            SqlCommand cmd = cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = sistema.Nome;
            cmd.Parameters.Add("bitmap", SqlDbType.Image).Value = ImageProcessador.CopyImageToByteArray(sistema.Bitmap);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }

        public void cadastrarNovo(EntidadeProduto sistema)
        {
            sistema.Id = ProximoId("produto");
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "" +
                "INSERT INTO produto " +
                "(id ,nome ,bitmap,descricao,codigo,preco) " +
                "VALUES " +
                "(@id  ,@nome ,@bitmap,@descricao,@codigo,@preco  ) "
                ;
            SqlCommand cmd = preparaCommand(sistema, conexao, sqlString);
            cmd.ExecuteNonQuery();
            banco.conexaFechar();
        }
        private SqlCommand preparaCommand(EntidadeProduto   sistema, SqlConnection conexao, string sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = sistema.Nome;
            cmd.Parameters.Add("bitmap", SqlDbType.Image).Value = ImageProcessador.CopyImageToByteArray(sistema.Bitmap);
            cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = sistema.Descricao;
            cmd.Parameters.Add("codigo", SqlDbType.VarChar).Value = sistema.Codigo;
            cmd.Parameters.Add("preco", SqlDbType.Float).Value = sistema.Valor;

            return cmd;
        }


        public List<EntidadeProduto> carregarProdutos()
        {

            List<EntidadeProduto> listaResultado = new List<EntidadeProduto>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from produto " ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadeProduto entidade = new EntidadeProduto();
                for (int contaColuna = 0; contaColuna < colunasPessoa.Length; contaColuna++)
                {
                    string colunaNome = colunasPessoa[contaColuna];
                    object? valor = valorDoBanco2(tbAc.Rows[contaLinha][colunaNome]);
                    popularFromDados(entidade, colunaNome, valor);

                }
                listaResultado.Add(entidade);
            }

            conexao.Close();
            return listaResultado;
        }
        public EntidadeProduto carregarProduto(EntidadeProduto sistema)
        {

            List<EntidadeProduto> listaResultado = new List<EntidadeProduto>();
            BancoDeDadosConfiguracao banco = new BancoDeDadosConfiguracao();
            SqlConnection conexao = banco.abreConexao();
            string sqlString = "select * from produto where " +
                "id = @id "
                ;
            SqlCommand cmd = new SqlCommand(sqlString, conexao);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = sistema.Id;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tbAc = new DataTable();
            adp.Fill(tbAc);
            for (int contaLinha = 0; contaLinha < tbAc.Rows.Count; contaLinha++)
            {
                EntidadeProduto entidade = new EntidadeProduto();
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

        private void popularFromDados(EntidadeProduto entidade, string coluna, object? valor)
        {

            if (valor == null) return;
            switch (coluna)
            {
                case "id": entidade.Id = Convert.ToInt16(valor); break;
                case "nome": entidade.Nome = Convert.ToString(valor); break;
                case "descricao": entidade.Descricao = Convert.ToString(valor); break;
                case "codigo": entidade.Codigo = Convert.ToString(valor); break;
                case "quantidade": entidade.Quantidade = Convert.ToInt32(valor); break;
                case "preco": entidade.Valor = float.Parse(Convert.ToString(valor)); break;
                case "bitmap":
                        byte[] im = (byte[]) valor;
                        entidade.Bitmap = ImageProcessador.GetImageFromByteArray(im); break;
            }
        }
    }
}
