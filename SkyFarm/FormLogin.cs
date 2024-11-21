using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyFarm
{
    public partial class FormLogin : Form
    {
        private FormPrincipal formPrincipal;
        public FormLogin(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            formPrincipal.WindowState = FormWindowState.Minimized;
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            EntidadeAcessoSistema acessoSistema = new EntidadeAcessoSistema();
            acessoSistema.Email = txtLogin.Text;
            acessoSistema.Login = txtLogin.Text;
            acessoSistema.Senha = txtSenha.Text;
            buscarUsuario(acessoSistema);
            
        }

        private void buscarUsuario(EntidadeAcessoSistema acessoSistema)
        {
            RepositorioAcessoSistema repo = new RepositorioAcessoSistema();
            
            EntidadeAcessoSistema listaUsuarios = repo.carregarUsuario(acessoSistema);
            if (listaUsuarios != null)
            {
                formPrincipal.setUsuarioLogado(listaUsuarios);
                Dispose();
                formPrincipal.WindowState = FormWindowState.Normal;
            }
            else {
                new BoxMessage("Falha de acesso ", "Usuario ou senha invalidos");
              }
        }
    }
}
