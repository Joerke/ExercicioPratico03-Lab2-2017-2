﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEscola.Models
{
    public class NivelEnsino
    {
        public int NivelEnsinoId { get; set; }
        public string Descricao { get; set; }
        public List<Professor> Professores  { get; set; }
        public List<Estudante> Estudantes { get; set; }

    }
}