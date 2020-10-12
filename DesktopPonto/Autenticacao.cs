using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopPonto
{
    static class Autenticacao //é um tipo de dado não instanciado e sempre disponivel em mémoria para uso quando necessário
    {
        static string nome;
        static string senha;
        static int nivel;


        public static void login(string nome1, string senha1, int nivel1)
        {
            nome = nome1;
            senha = senha1;
            nivel = nivel1;
        }

        public static void logout()
        {
            nome = null;
            senha = null;
            nivel = 0;
        }

        public static String getUsario()
        {
            return "Nome: " + nome + "\nSenha: " + senha + "\nNível: " + nivel;
        }

    }
}
