using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C__.net.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(Aluno); 
        }
    }
}