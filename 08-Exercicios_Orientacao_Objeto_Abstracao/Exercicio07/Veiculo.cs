﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine("Marca: " + Marca + " \nAno: " + Ano);
        }
    }
}
