using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.sessao
{
    public class ControleSessao
    {
        private List<Sessao> acessoSistema;
        public ControleSessao()
        {
            acessoSistema = new List<Sessao>();
        }
        public Sessao CriaSessao(String login,String senha)
        {
            Sessao sessao = new Sessao();
            sessao.Usuario = carregaUsuario(login, senha);
            sessao.carregarPermissoes();
            acessoSistema.Add(sessao);
            return sessao;
        }
        public bool verificaPermissao(Sessao sessao,String permissao)
        {
            return false;
        }

        private EntidadeAcessoSistema carregaUsuario(String login, String senha)
        {
            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            List<EntidadeAcessoSistema> listaUsuarios = new List<EntidadeAcessoSistema>();// = repo.carregarUsuario(login, senha);
            EntidadeAcessoSistema usuario = null;
            if (listaUsuarios.Count == 1)
            {
                usuario = listaUsuarios[0];
            }
            return usuario;
        }
    }
}
