using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarm
{
    internal class ItemBoxFuncionario
    {
        EntidadeAcessoSistema _sistema;

        public ItemBoxFuncionario(EntidadeAcessoSistema sistema) {
            this._sistema = sistema;
        }
        public EntidadeAcessoSistema Acesso { get { return _sistema; } }
        public override string ToString()
        {
            return _sistema.Login+" | " +_sistema.Email;
        }
    }
}
