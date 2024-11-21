using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.entidades
{
    public class EntidadePedido
    {
      public int Id{ get; set; }
      public string Id_produto{ get; set; }
      public string IdSistema{ get; set; }
      public int Quantidade{ get; set; }
      public float ValorTotal{ get; set; }
      public string IdMeioPagamento{ get; set; }
      public string IdFrete{ get; set; }
    }
}
