using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarFuncionario
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            Console.WriteLine(" --- CADASTRAR FUNCIONARIO --- \n");
            Console.WriteLine("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário: ");
            f.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(f.Cpf))
            {
                if (FuncionarioDAO.Cadastrar(f))
                {
                    Console.WriteLine("\nFuncionário cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("\nO funcionário já existe!!!");
                }
            }
            else
            {
                Console.WriteLine("\nCPF inválido!");
            }
        }
    }
}
