using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    public class clsProduto
    {
        private static int codigo;
        private static int quantidade;
        private static String produto;

        public static void setCodigo(int _codigo) { codigo = _codigo; }
        public static void setQuantidade(int _quantidade) { quantidade = _quantidade; }
        public static void setProduto(String _produto) { produto = _produto; }

        public static int getCodigo() { return codigo; }
        public static int getQuantidade() { return quantidade; }
        public static String getProduto() { return produto; }
    }
}
