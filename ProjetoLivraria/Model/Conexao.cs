using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Model
{
    internal class Conexao
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matpa\source\repos\ProjetoLivraria-master-master2-master\ProjetoLivraria\Dados\bdlivraria.mdf;Integrated Security=True";
        }
    }
}
