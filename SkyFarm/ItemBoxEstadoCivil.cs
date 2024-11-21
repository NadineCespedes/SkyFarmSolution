using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarm
{
    public class ItemBoxEstadoCivil
    {
        EntidadeEstadoCivil _sistema;

        public ItemBoxEstadoCivil(EntidadeEstadoCivil sistema)
        {
            this._sistema = sistema;
        }
        public EntidadeEstadoCivil Acesso { get { return _sistema; } }
        public override string ToString()
        {
            return _sistema.Descricao;
        }
    }
}
