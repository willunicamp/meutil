using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    // HERANÇA: Aluno "é uma" Pessoa, herdando todas as suas propriedades e métodos.
    public class Aluno : Pessoa
    {
        public string RA { get; set; }

        // Chama o construtor da classe base (Pessoa)
        public Aluno(string nome, string cpf, DateTime dataNascimento, string matricula) : base(nome, cpf, dataNascimento)
        {
            RA = matricula;
        }

        // POLIMORFISMO: Sobrescrevendo o método da classe pai para um comportamento específico.
        public override void Apresentar()
        {
            //base.Apresentar(); // Opcional: Chama o método da classe pai
            Console.WriteLine($"Sou o aluno(a) {Nome}, RA {RA}.");
        }
    }
}
