using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEscola.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public string ProfessorId { get; set; }
        public Professor Professores { get; set; }
        public List<Estudante> Estudantes { get; set; }

    }
}