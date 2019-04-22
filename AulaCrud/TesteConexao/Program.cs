using AulaCrudConexao;
using AulaCrudEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConexao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexao cnn = new Conexao();

            cnn.ExecuteNonQuery("INSERT INTO PESSOA (Nome, Idade, CPF) VALUES ('Murilo', 33, '36976518703')");

            Console.ReadKey();
        }
    }
}
