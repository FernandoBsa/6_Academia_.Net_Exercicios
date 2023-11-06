using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio02
{
    public abstract class Veiculo
    {
        public string Marca {  get; set; } 
        public string Modelo { get; set; }

        public abstract void Dirigir();
    }
}
