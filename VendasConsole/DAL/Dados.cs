using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Gabriel Alex",
                Cpf = "10772537920"
            };
            ClienteDAO.Cadastrar(cliente);
            Funcionario funcionario = new Funcionario
            {
                Nome = "Jose da Silva",
                Cpf = "05363419904"
            };
            FuncionarioDAO.Cadastrar(funcionario);
            Produto produto = new Produto
            {
                Nome = "Bolacha",
                Preco = 3.5,
                Quantidade = 150
            };
            ProdutoDAO.Cadastrar(produto);

        }
    }
}
