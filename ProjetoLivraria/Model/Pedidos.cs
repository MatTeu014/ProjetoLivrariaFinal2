using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    internal class Pedidos
    {
        private static int codigoPed;
        private static DateTime dataPed;
        private static decimal valorTotalPed;
        private static int codigoCliFK;
        private static int codigoFunFK;

        public static int CodigoPed { get => codigoPed; set => codigoPed = value; }
        public static DateTime DataPed { get => dataPed; set => dataPed = value; }
        public static decimal ValorTotalPed { get => valorTotalPed; set => valorTotalPed = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
    }
}
