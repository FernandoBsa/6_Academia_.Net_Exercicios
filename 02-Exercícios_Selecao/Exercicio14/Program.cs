namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            //link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
            //do arquivo usando este link (em minutos).

            double tamanho, velocidadeInternet, tempoDownload;

            Console.WriteLine("Tamanho do arquivo: ");
            tamanho = double.Parse(Console.ReadLine());

            Console.WriteLine("Velocidade da internet em Mbps: ");
            velocidadeInternet = double.Parse(Console.ReadLine());

            tempoDownload = ((tamanho * 8) / velocidadeInternet) / 60;

            Console.WriteLine("Tempo aproximado de download em minutos: " + tempoDownload);
        }
    }
}