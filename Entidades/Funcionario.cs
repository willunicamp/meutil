using Entidades;
using System;

namespace Entidades
{
    // HERANÇA: Funcionario também "é uma" Pessoa.
    public class Funcionario : Pessoa
    {
        // Propriedades específicas de um Funcionário
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }

        /// Construtor da classe Funcionario.
        public Funcionario(string nome, string cpf, DateTime dataNascimento, string cargo, decimal salario)
            : base(nome, cpf, dataNascimento) // Chama o construtor da classe base (Pessoa)
        {
            Cargo = cargo;
            Salario = salario;
            DataAdmissao = DateTime.Now; // Podemos definir a data de admissão como o momento do cadastro
        }

        /// POLIMORFISMO: Sobrescreve o método Apresentar para fornecer uma
        /// implementação específica para a classe Funcionario.
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o funcionário(a) {Nome}, e meu cargo é {Cargo}.");
        }

        /// Um método específico da classe Funcionario.
        public void Promover(string novoCargo, decimal novoSalario)
        {
            if (novoSalario <= this.Salario)
            {
                // Conceito de validação dentro da própria classe
                throw new ArgumentException("O novo salário deve ser maior que o salário atual.");
            }

            this.Cargo = novoCargo;
            this.Salario = novoSalario;
            Console.WriteLine($"{Nome} foi promovido para {Cargo} com um salário de {Salario:C}.");
        }
    }
}