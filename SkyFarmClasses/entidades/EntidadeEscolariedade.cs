using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.entidades
{
    public class EntidadeEscolariedade
    {
        int? _id;
        string _descricao;
        public int? Id { get { return _id; } set { _id = value; } }
        public string Descricao { get { return _descricao; } set { _descricao = value; } }
        
    }
    
}
