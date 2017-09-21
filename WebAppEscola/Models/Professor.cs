using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEscola.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorNome { get; set; }
        public string TipoProfessor { get; set; }
        public string NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}