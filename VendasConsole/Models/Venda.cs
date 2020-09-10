using System;

namespace VendasConsole.Models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Produto = new Produto();
            Funcionario = new Funcionario();
        }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
