using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEscola.Models
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string EstudanteNome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Foto { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string NivelEnsinoId { get; set; }
        public List<Curso> Cursos { get; set; }
        public NivelEnsino  NivelEnsino { get; set; }
        public Endereco Enderecos { get; set; }





    }
}