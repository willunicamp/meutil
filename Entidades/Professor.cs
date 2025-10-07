using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Professor : Pessoa
    {
        public string Titulacao { get; set; }
        public string AreaEspecializacao { get; set; }

        // LISTAS (Collections): Um professor pode lecionar várias disciplinas.
        public List<Disciplina> DisciplinasLecionadas { get; set; }

        public Professor(string nome, string cpf, DateTime dataNascimento, string titulacao)
            : base(nome, cpf, dataNascimento)
        {
            Titulacao = titulacao;
            DisciplinasLecionadas = new List<Disciplina>(); // Sempre inicialize listas!
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o professor(a) {Nome}, com titulação em {Titulacao}.");
        }
    }
}
