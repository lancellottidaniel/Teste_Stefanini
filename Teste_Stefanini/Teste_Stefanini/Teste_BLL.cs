//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.IO;
//using System.Globalization;
//using Produto;
//using Pessoa;
//using Erro;
//using Teste_DAL;

//namespace Teste_Stefanini
//{
//    class Teste_BLL
//    {
//        private static string dado = null, dados = null;
//        public static List<String> lista_arq = new List<string>();
//        public static string[,] arrDados = new string [30,7];

//        //lê arquivo de input e separa as informações por lista
//        public static List<string> trataArquivo(string arquivo)
//        {
//            StreamReader arq_txt1 = new StreamReader(arquivo);
//            while ((dado = arq_txt1.ReadLine()) != null)
//            {
//                dados = dado;
//            }
//            for (int i = 0; i < dados.Split(';').Count(); i++)
//            {
//                lista_arq.Add(dados.Split(';')[i].ToString());
//            }
//            return lista_arq;
//        }

//        //trata as informações do arquivo Pessoa
//        public static void arquivoPessoa(List<string> lista_validada)
//        {
//            for (int i = 0; i < lista_validada.Count(); i++)
//            {
//                clsPessoa.setCodigo(int.Parse(lista_validada[i].Split(',')[0]));
//                clsPessoa.setNome(lista_validada[i].Split(',')[1]);
//                clsPessoa.setSobrenome(lista_validada[i].Split(',')[2]);
//                clsPessoa.setDataNasc(DateTime.ParseExact(lista_validada[i].Split(',')[3], "dd/MM/yyyy", new CultureInfo("br")));
//                clsPessoa.setSexo(lista_validada[i].Split(',')[4]);
//                clsPessoa.setEmail(lista_validada[i].Split(',')[5]);
//                clsPessoa.setAtivo(bool.Parse(lista_validada[i].Split(',')[6]));
//                clsTeste_DAL.insereUmaPessoa();
//            }
//        }

//        //trata as informações do arquivo Produto
//        public static void arquivoProduto(List<string> lista_validada)
//        {
//            for (int i = 0; i < lista_validada.Count(); i++)
//            {
//                clsProduto.setCodigo(int.Parse(lista_validada[i].Split(',')[0]));
//                clsProduto.setQuantidade(int.Parse(lista_validada[i].Split(',')[1]));
//                clsProduto.setProduto(lista_validada[i].Split(',')[2]);


//                //verifica se o Produto já existe, caso exista, soma as quantidades dos produtos iguais e atualiza a tabela, caso não, apenas insere o produto
//                if (clsTeste_DAL.verificaProduto(int.Parse(lista_validada[i].Split(',')[0])))
//                    clsTeste_DAL.somaQuantidade(int.Parse(lista_validada[i].Split(',')[0]), int.Parse(lista_validada[i].Split(',')[1]));
//                else
//                    clsTeste_DAL.insereUmProduto();
//            }
//        }

//        public static void trataErrosPessoa()
//        {
//            StreamWriter arqLog = new StreamWriter((Directory.GetCurrentDirectory() + @"\log_erros_produto.txt").ToString());
//            clsErro.setErro(false);
//            if (clsPessoa.getNome().Equals(""))
//            {
//                clsErro.setMsg("O nome é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsPessoa.getSobrenome().Equals(""))
//            {
//                clsErro.setMsg("O sobrenome é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsPessoa.getDataNasc().Equals(""))
//            {
//                clsErro.setMsg("A data de nascimento é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsPessoa.getEmail().Equals(""))
//            {
//                clsErro.setMsg("O ano é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsPessoa.getAtivo().Equals("") || Boolean.Parse(clsPessoa.getAtivo().ToString()))
//            {
//                clsErro.setMsg("O ano é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            arqLog.Close();
//        }

//        public static void trataErrosProduto()
//        {
//            StreamWriter arqLog = new StreamWriter((Directory.GetCurrentDirectory() + @"\log_erros_produto.txt").ToString());
//            clsErro.setErro(false);
//            if (clsProduto.getCodigo().Equals(""))
//            {
//                clsErro.setMsg("O código é de preenchimento obrigatório e deve ser numérico!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsProduto.getQuantidade().Equals(""))
//            {
//                clsErro.setMsg("O nome é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            if (clsProduto.getProduto().Equals(""))
//            {
//                clsErro.setMsg("O sobrenome é de preenchimento obrigatório!");
//                arqLog.WriteLine(clsErro.getMsg());
//            }
//            arqLog.Close();
//        }

//        public static string[,] trataRetornoPessoa()
//        {
//            int i = 0;
//            clsTeste_DAL.consultaPessoa();
//            while (clsTeste_DAL.retorno.Read())
//            {
//                clsPessoa.setCodigo(int.Parse(clsTeste_DAL.retorno[0].ToString()));
//                clsPessoa.setNome(clsTeste_DAL.retorno[1].ToString());
//                clsPessoa.setSobrenome(clsTeste_DAL.retorno[2].ToString());
//                clsPessoa.setDataNasc(DateTime.Parse(clsTeste_DAL.retorno[3].ToString()));
//                clsPessoa.setSexo(clsTeste_DAL.retorno[4].ToString());
//                clsPessoa.setEmail(clsTeste_DAL.retorno[5].ToString());
//                clsPessoa.setAtivo(bool.Parse(clsTeste_DAL.retorno[6].ToString()));

//                arrDados[i, 0] = clsPessoa.getCodigo().ToString();
//                arrDados[i, 1] = clsPessoa.getNome();
//                arrDados[i, 2] = clsPessoa.getSobrenome();
//                arrDados[i, 3] = clsPessoa.getDataNasc().ToString();
//                arrDados[i, 4] = clsPessoa.getSexo();
//                arrDados[i, 5] = clsPessoa.getEmail();
//                arrDados[i, 6] = clsPessoa.getAtivo().ToString();

//                i++;
//            }
//            clsTeste_DAL.desconecta();

//            return arrDados;
//        }

//        public static string[,] trataRetornoProduto()
//        {            
//            int i = 0;
//            clsTeste_DAL.consultaProduto();
//            while (clsTeste_DAL.retorno.Read())
//            {
//                clsProduto.setCodigo(int.Parse(clsTeste_DAL.retorno[0].ToString()));
//                clsProduto.setQuantidade(int.Parse(clsTeste_DAL.retorno[1].ToString()));
//                clsProduto.setProduto(clsTeste_DAL.retorno[2].ToString());

//                arrDados[i, 0] = clsProduto.getCodigo().ToString();
//                arrDados[i, 1] = clsProduto.getQuantidade().ToString();
//                arrDados[i, 2] = clsProduto.getProduto();

//                i++;
//            }
//            clsTeste_DAL.desconecta();

//            return arrDados;
//        }

//    }
//}
