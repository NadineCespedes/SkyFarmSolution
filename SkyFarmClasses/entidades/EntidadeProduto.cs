using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace SkyFarmClasses.entidades
{
    public class EntidadeProduto
    {
        int? _id;
        string _nome;
        float _valor;
        private Image _bitmap;

        int? _quantidade;
        string _medida;
        string _descricao;
        string _codigo;

        public int? Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public float Valor { get { return _valor; } set { _valor = value; } }
        public Image Bitmap { get { return _bitmap; } set { _bitmap = value; } }

        public string Medida { get { return _medida; }  set { _medida = value; } }  
        public int? Quantidade{get { return _quantidade; }set { _quantidade = value; }}

        public string Descricao { get { return _descricao; } set { _descricao = value; } }
        public string Codigo { get { return _codigo; }  set { _codigo = value; } } 
    }
}
