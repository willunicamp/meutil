using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entidades;

namespace Entidades
{
    public class Turma
    {
        public int ID { get; set; }
        public int Ano { get; set; }
        public string Sigla { get; set; }
        public string Periodo { get; set; }

        // LISTAS E ITERATORS: A turma contém uma lista de alunos.
        // O C# nos permite iterar sobre essa lista facilmente com um foreach.
        public List<Aluno> Alunos { get; set; }

        public Turma()
        {
            Alunos = new List<Aluno>();
        }
    }
}
