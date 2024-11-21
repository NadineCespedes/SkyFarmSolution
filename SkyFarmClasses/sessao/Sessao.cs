using SkyFarmClasses.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.sessao
{
    public class Sessao
    {
        EntidadeAcessoSistema _usuario;
        public Sessao() { 
            
        } 
        public EntidadeAcessoSistema Usuario { get { return _usuario; } set { _usuario = value; } }

        internal void carregarPermissoes()
        {
            
        }
    }
}
