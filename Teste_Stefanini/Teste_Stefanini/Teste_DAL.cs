//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data.SqlClient;
//using System.Data.Sql;
//using System.Data;
//using Pessoa;
//using Produto;
//using Erro;

//namespace Teste_Stefanini
//{
//    class Teste_DAL
//    {
//        private static String strConexao = @"Data Source=BRSPDLANCELLOTT\SQLEXPRESS;Initial Catalog=Teste_Stefanini;User ID=sa;Password=teste123***; Connection Timeout=120";
//        private static SqlConnection connection = new SqlConnection(strConexao);
//        private static SqlCommand command = new SqlCommand();
//        public static SqlDataReader retorno;

//        public static void conecta()
//        {
//            connection.Open();
//        }

//        public static void desconecta()
//        {
//            connection.Close();
//        }

//        public static void alteraUmaPessoa()
//        {
//            StringBuilder aux = null;

//            aux.Append("Update TabPessoa");
//            aux.Append("set nome = '" + clsPessoa.getNome() + "', ");
//            aux.Append("sobrenome = '" + clsPessoa.getSobrenome() + "', ");
//            aux.Append("data_nasc = '" + clsPessoa.getDataNasc() + "', ");
//            aux.Append("email = '" + clsPessoa.getEmail() + "', ");
//            aux.Append("sexo = '" + clsPessoa.getSexo() + "', ");
//            aux.Append("ativo = '" + clsPessoa.getAtivo() + "' ");
//            aux.Append("where codigo = '" + clsPessoa.getCodigo() + "'");

//            conecta();
//            command.Connection = connection;
//            command.CommandText = aux.ToString();
//            command.ExecuteNonQuery();
//            desconecta();
//        }

//        public static void insereUmaPessoa()
//        {
//            try
//            {
//                String aux = "insert into TabPessoa(codigo,nome,sobrenome,data_nasc,email,sexo,ativo) values ('" + clsPessoa.getCodigo() + "','" + clsPessoa.getNome() + "','" + clsPessoa.getSobrenome() + "','" + clsPessoa.getDataNasc() + "','" + clsPessoa.getEmail() + "','" + clsPessoa.getSexo() + "','" + clsPessoa.getAtivo() + "')";

//                conecta();
//                command.Connection = connection;
//                command.CommandText = aux.ToString();
//                command.ExecuteNonQuery();
//                desconecta();
//            }
//            catch(Exception ex)
//            {
//                clsErro.setMsg(ex.Message);
//            }
            
//        }

//        public static void insereUmProduto()
//        {
//            try
//            {
//                String aux = "insert into TabProduto(codigo,quantidade,produto) values ('" + clsProduto.getCodigo() + "','" + clsProduto.getQuantidade() + "','" + clsProduto.getProduto() + "')";

//                conecta();
//                command.Connection = connection;
//                command.CommandText = aux.ToString();
//                command.ExecuteNonQuery();
//                desconecta();
//            }
//            catch (Exception ex)
//            {
//                clsErro.setMsg(ex.Message);
//            }

//        }
//        public static bool verificaProduto(int codigo)
//        {
//            String aux = "select quantidade from TabProduto where codigo = " + codigo;

//            conecta();
//            command.Connection = connection;
//            command.CommandText = aux.ToString();
//            retorno = command.ExecuteReader();
//            retorno.Read();
//            try
//            {
//                int nRetorno = retorno.GetInt32(0);
//                desconecta();
//                return true;
//            }
//            catch
//            {
//                desconecta();
//                return false;
//            }
//        }

//        public static void somaQuantidade(int codigo, int quantidade)
//        {
//            String aux = "select quantidade from TabProduto where codigo = " + codigo;

//            command.CommandType = CommandType.Text;
//            command.Connection = connection;
//            command.CommandText = aux.ToString();
//            conecta();

//            retorno = command.ExecuteReader();
//            retorno.Read();
//            int qtdBd = int.Parse(retorno[0].ToString());
//            desconecta();
//            quantidade += qtdBd;
            
//            String aux2 = "update TabProduto set quantidade = " + quantidade.ToString() + "where codigo = " + codigo;

//            conecta();
//            command.Connection = connection;
//            command.CommandText = aux2.ToString();
//            command.ExecuteNonQuery();

//            desconecta();

//        }

//        public static SqlDataReader consultaPessoa()
//        {
//            String aux = "select * from TabPessoa";

//            conecta();
//            command.Connection = connection;
//            command.CommandText = aux.ToString();
//            retorno = command.ExecuteReader();

//            return retorno;
//        }

//        public static SqlDataReader consultaProduto()
//        {
//            String aux = "select * from TabProduto";

//            conecta();
//            command.Connection = connection;
//            command.CommandText = aux.ToString();
//            retorno = command.ExecuteReader();

//            return retorno;
//        }                
//    }
//}
