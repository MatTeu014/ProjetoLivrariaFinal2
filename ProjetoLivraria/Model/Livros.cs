using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    internal class Livros
    {
        private static int codigoLiv;
        private static string nomeLiv;
        private static string categoriaLiv;
        private static string autorLiv;
        private static decimal valorLiv;

        public static int CodigoLiv { get => codigoLiv; set => codigoLiv = value; }
        public static string NomeLiv { get => nomeLiv; set => nomeLiv = value; }
        public static string CategoriaLiv { get => categoriaLiv; set => categoriaLiv = value; }
        public static string AutorLiv { get => autorLiv; set => autorLiv = value; }
        public static decimal ValorLiv { get => valorLiv; set => valorLiv = value; }
    }
}
