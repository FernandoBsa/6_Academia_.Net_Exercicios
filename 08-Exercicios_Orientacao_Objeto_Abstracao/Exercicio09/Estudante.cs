﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Estudante : Pessoa
    {
        public int Matricula { get; set; }
        public string Curso { get; set; }

        public Estudante(string nome, int idade, int matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
