using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarFuncionarios
    {
        public static void Renderizar()
        {
            Console.WriteLine(" --- LISTAR FUNCIONÁRIO --- \n");
            foreach (Funcionario funcionarioCadastrado in FuncionarioDAO.Listar())
            {
                Console.WriteLine(funcionarioCadastrado);
            }
        }
    }
}
