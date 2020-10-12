using DesktopPonto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopPonto.Models
{
    public class Controller
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.veriricarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
