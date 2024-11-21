using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses
{
    public class BancoDeDadosConfiguracao
    {
        private String _servidorUsuario = "User ID=sa;";
        private String _servidorDataSource = "Data Source=jessa.server,1433;";
        private String _servidorSenha = "Password=Jessa@7590;";
        private String ParametroConexao()
        {
            String _parametroConexao =
            @"Initial Catalog=skyfarm_bd;Persist Security Info=True;Encrypt=False;";
            _parametroConexao = _parametroConexao + _servidorUsuario + _servidorSenha + _servidorDataSource;

            return _parametroConexao;
        }
        SqlConnection conexao;
        public SqlConnection abreConexao()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection(ParametroConexao());
            }

            conexao.Open();
            return conexao;
        }
        public void conexaFechar()
        {
            conexao.Close();
        }
    }
}
