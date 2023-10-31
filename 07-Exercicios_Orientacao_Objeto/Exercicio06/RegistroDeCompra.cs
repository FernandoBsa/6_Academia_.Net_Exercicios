using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class RegistroDeCompra
    {
        public string data;
        public string produto;
        public double valor;
        public List<RegistroDeCompra> compras;

        public RegistroDeCompra(string data, string produto, double valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
            this.compras = new List<RegistroDeCompra>();
        }

        public void AdicionarCompra(RegistroDeCompra compra)
        {
            this.compras.Add(compra);
        }

        public void Listar()
        {
            foreach (var compra in this.compras)
            {
                Console.WriteLine("Data: " + compra.data);
                Console.WriteLine("Produto: " + compra.produto);
                Console.WriteLine("Valor: " + compra.valor);
            }
        }
    }
}
