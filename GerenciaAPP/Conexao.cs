using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GerenciaAPP
{
    class Conexao
    {

        //String de conexão
        private string stringConexao = @"Server=FRA0687817W11-1\SQLEXPRESS;
        Database=db_gerenciaapp;User Id = sa;
        Password = 1234567890;TrustServerCertificate=True";

        //Método para abrir a conexão

        public SqlConnection Conectar()
        {
            SqlConnection con = 
                new SqlConnection(stringConexao);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }

        public void Desconectar(SqlConnection con)
        {
            if (con.State ==
                ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
