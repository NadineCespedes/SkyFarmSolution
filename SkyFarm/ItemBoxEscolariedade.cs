using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarm
{
    public class ItemBoxEscolariedade
    {
        EntidadeEscolariedade? _sistema;

        public ItemBoxEscolariedade(EntidadeEscolariedade sistema)
        {
            this._sistema = sistema;
        }
        public EntidadeEscolariedade? Acesso { get { return _sistema; } }
        public override string ToString()
        {
            return _sistema.Descricao;
        }
    }
}
