using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFarmClasses.entidades
{
    public class EntidadeAcessoSistema
    {
        private int _id;
        private string _email;
        private string _login;
        private String _senha;


        public string Email { get { return _email; } set { _email = value; } }
        public int ID { get { return _id; } set { _id = value; } }

        public string Login { get { return _login; } set { _login = value; } }
        public String Senha { get { return _senha; } set { _senha = value; } }
        

    }
}
