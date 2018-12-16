using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Produto;


namespace Teste_Stefanini
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista_validada = Teste_BLL.trataArquivo(@"c:\users\dlancellotti\downloads\ARQUIVO2-PLENO.txt");

            if (lista_validada[0].Split(',').Count() > 4)
            {
                Teste_BLL.arquivoPessoa(lista_validada);
                Teste_BLL.trataErrosPessoa();
            }
            else
            {

                Teste_BLL.arquivoProduto(lista_validada);
                Teste_BLL.trataErrosProduto();
            }

            Teste_BLL.trataRetornoPessoa();

            foreach (var item in Teste_BLL.arrDados)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
