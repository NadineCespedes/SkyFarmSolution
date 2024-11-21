using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses
{
    public class CadastrarFuncionario
    {
        EntidadeFuncionario _funcionario;
        public CadastrarFuncionario() {
            _funcionario = new EntidadeFuncionario();
            _funcionario.Sistema = new EntidadeAcessoSistema();
            _funcionario.Pessoa = new EntidadePessoa();
            _funcionario.Pessoa.Escolariedade = new EntidadeEscolariedade();
            _funcionario.Pessoa.EstadoCivil = new EntidadeEstadoCivil();
        }
        
        public EntidadeFuncionario NovoFuncionario { get { return _funcionario; } set { _funcionario = value; } }

        public void registrar()
        {
            cadastrarSistema();
            cadastrarPessoa();
            RepositorioFuncionario repo  = new RepositorioFuncionario();
            repo.cadastrarFuncionario(_funcionario);
        }

        private void cadastrarSistema()
        {
            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            repo.cadastrarUsuario(_funcionario.Sistema);
        }
        private void cadastrarPessoa()
        {
            RepositorioPessoa repo = new RepositorioPessoa();
            if (_funcionario.Pessoa.Escolariedade == null) _funcionario.Pessoa.Escolariedade = new EntidadeEscolariedade();
            if (_funcionario.Pessoa.EstadoCivil == null) _funcionario.Pessoa.EstadoCivil = new EntidadeEstadoCivil();
            repo.cadastrarPessoa(_funcionario.Pessoa);
        }

        public void atualizar()
        {
            atualizarSistema();
            atualizarPessoa();
        }

        private void atualizarSistema()
        {
            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            repo.atualizarUsuario(_funcionario.Sistema);
        }
       

        private void atualizarPessoa()
        {
            RepositorioPessoa repo = new RepositorioPessoa();
            if (_funcionario.Pessoa.Escolariedade == null) _funcionario.Pessoa.Escolariedade = new EntidadeEscolariedade();
            if (_funcionario.Pessoa.EstadoCivil == null) _funcionario.Pessoa.EstadoCivil = new EntidadeEstadoCivil();
            repo.atualizarPessoa(_funcionario.Pessoa);
        }

        public void remover()
        {
            
            removerSistema();
            removerFucionario();
            removerPessoa();
            

        }

        private void removerSistema()
        {
            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            repo.removerUsuario(_funcionario.Sistema);
        }

        private void removerPessoa()
        {
            RepositorioPessoa repo = new RepositorioPessoa();
            if (_funcionario.Pessoa.Escolariedade == null) _funcionario.Pessoa.Escolariedade = new EntidadeEscolariedade();
            if (_funcionario.Pessoa.EstadoCivil == null) _funcionario.Pessoa.EstadoCivil = new EntidadeEstadoCivil();
            repo.removerPessoa(_funcionario.Pessoa);
        }
        public void removerFucionario()
        {
            RepositorioFuncionario repo = new RepositorioFuncionario();
            repo.removerFuncionario(_funcionario);
        }
    }
}
