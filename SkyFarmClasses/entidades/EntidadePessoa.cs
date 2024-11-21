using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.entidades
{
    public class EntidadePessoa
    { int _id;
      string _nome;
      string _data_nascimento;
      string _rg;
      string _cpf;
      EntidadeEstadoCivil? _estado_civil;
      EntidadeEscolariedade? _escolariedade;
      string _filiacao;
      

        public int Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } } 
        public string Data_nascimento { get { return _data_nascimento; } set { _data_nascimento = value; } }                        
        
        public string RG { get { return _rg; } set {_rg = value; } }
        public string Cpf { get { return _cpf; } set { _cpf = value; } }

        public string Filiacao { get { return _filiacao; } set { _filiacao = value; } }

        public EntidadeEstadoCivil? EstadoCivil { get { return _estado_civil;} set {  _estado_civil = value; } }

        public EntidadeEscolariedade? Escolariedade { get{ return _escolariedade; } set { _escolariedade = value; } }
        
    }

}
