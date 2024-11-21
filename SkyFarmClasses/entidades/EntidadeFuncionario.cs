using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.entidades
{
    public class EntidadeFuncionario
    {
        int? _id;
        EntidadePessoa _pessoa;
        EntidadeAcessoSistema _sistema;
        String valor;
        public int? Id { get { return _id; } set { _id = value; } }
        public EntidadeAcessoSistema Sistema { get { return _sistema; } set { _sistema = value; } }
        public EntidadePessoa Pessoa{ get { return _pessoa;   } set { _pessoa = value; } }
        public String VV {  get { return valor; } set { valor = value; } }
    }
}
