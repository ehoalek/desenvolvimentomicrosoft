using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class FuncionarioDAO
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorCpf(funcionario.Cpf) != null)
            {
                return false;
            }
            funcionarios.Add(funcionario);
            return true;
        }

        public static Funcionario BuscarPorCpf(string cpf)
        {
            foreach (Funcionario funcionarioCadastrado in funcionarios)
            {
                if (cpf.Equals(funcionarioCadastrado.Cpf))
                {
                    return funcionarioCadastrado;
                }
            }
            return null;
        }

        public static List<Funcionario> Listar() => funcionarios;

    }
}
