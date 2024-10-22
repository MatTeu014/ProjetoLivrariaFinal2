using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    class Clientes
    {
        private static int codigoCli;
        private static string nomeCli;
        private static string emailCli;
        private static string cpfCli;

        public static int CodigoCli { get => codigoCli; set => codigoCli = value; }
        public static string NomeCli { get => nomeCli; set => nomeCli = value; }
        public static string EmailCli { get => emailCli; set => emailCli = value; }
        public static string CpfCli { get => cpfCli; set => cpfCli = value; }
    }
}
