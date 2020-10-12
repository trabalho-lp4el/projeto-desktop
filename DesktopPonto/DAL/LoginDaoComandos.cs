﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesktopPonto.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool veriricarLogin(String login, String senha)
        {
            //procurar no banco esse login e senha
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos SQL para inserir no banco retornando uma mensagem
            return mensagem;
        }
    }
}
