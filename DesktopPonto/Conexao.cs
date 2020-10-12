using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Odbc;


namespace DesktopPonto
{
    class Conexao
    {
        public OleDbConnection cn = new OleDbConnection();

        public void conectar()
        {
            cn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Resources\Banco_teste.mdb";
            cn.Open();
        }

        public void desconectar()
        {
            cn.Close();
        }
    }
}
