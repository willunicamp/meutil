using System;

namespace Entidades
{
    // CLASSE ABSTRATA: Não pode ser instanciada diretamente. Serve como um modelo base.
    public abstract class Pessoa
    {
        // ENCAPSULAMENTO: Propriedades públicas controlam o acesso aos dados.
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Construtor
        public Pessoa(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        // Método que pode ser sobrescrito pelas classes filhas (Polimorfismo)
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}.");
        }
    }
}