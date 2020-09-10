using System;

namespace VendasConsole.Models
{
    class Funcionario
    {
        //Construtor
        public Funcionario(string nome, string cpf)
        {

            Nome = nome;
            Cpf = cpf;
        }
        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }

        //Atributos, propriedades, membros e características
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
