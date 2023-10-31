using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class CorretoraDeImoveis
    {
        public List<Imovel> imoveis;

        public CorretoraDeImoveis()
        {
            this.imoveis = new List<Imovel>();
        }

        public void ListarImoveis()
        {
            foreach (var imovel in this.imoveis)
            {
                Console.WriteLine("Endereço: " + imovel.endereco + ", Preço: " + imovel.preco + ", Tipo: " + imovel.tipo);
            }
        }

        public double CalcularValorMedio()
        {
            if (this.imoveis.Count == 0)
            {
                return 0;
            }

            double somaPrecos = 0;
            foreach (var imovel in this.imoveis)
            {
                somaPrecos += imovel.preco;
            }

            return somaPrecos / this.imoveis.Count;
        }
    }
}
