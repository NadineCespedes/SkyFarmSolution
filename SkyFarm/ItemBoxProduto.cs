using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarm
{
    public class ItemBoxProduto
    {
        EntidadeProduto _sistema;

        public ItemBoxProduto(EntidadeProduto sistema)
        {
            this._sistema = sistema;
        }
        public EntidadeProduto Acesso { get { return _sistema; } }
        public override string ToString()
        {
            return _sistema.Nome + " | " + _sistema.Valor;
        }
    }
}
