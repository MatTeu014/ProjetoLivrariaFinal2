using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    internal class Funcionarios
    {
        private static int codigoFun;
        private static string nomeFun;
        private static string cpfFun;
        private static string emailFun;
        private static string cargoFun;

        public static int CodigoFun { get => codigoFun; set => codigoFun = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string CpfFun { get => cpfFun; set => cpfFun = value; }
        public static string EmailFun { get => emailFun; set => emailFun = value; }
        public static string CargoFun { get => cargoFun; set => cargoFun = value; }
    }
}
