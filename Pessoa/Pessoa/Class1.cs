using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    public class clsPessoa
    {
        private static int codigo;
        private static String nome;
        private static String sobrenome;
        private static DateTime data_nasc;
        private static String sexo;
        private static String email;
        private static Boolean ativo;

        public static void setCodigo(int _codigo) { codigo = _codigo; }
        public static void setNome(String _nome) { nome = _nome; }
        public static void setSobrenome(String _sobrenome) { sobrenome = _sobrenome; }
        public static void setDataNasc(DateTime _datanasc) { data_nasc = _datanasc; }
        public static void setSexo(String _sexo) { sexo = _sexo; }
        public static void setEmail(String _email) { email = _email; }
        public static void setAtivo(Boolean _ativo) { ativo = _ativo; }

        public static int getCodigo() { return codigo; }
        public static String getNome() { return nome; }
        public static String getSobrenome() { return sobrenome; }
        public static DateTime getDataNasc() { return data_nasc; }
        public static String getSexo() { return sexo; }
        public static String getEmail() { return email; }
        public static Boolean getAtivo() { return ativo; }
    }
}
