using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    public class Musica
    {
        public string nome { get; set; }
        public string autor { get; set; }
        public string gravadora { get; set; }
    }
    public class Playlist
    {
        private List<Musica> listaDeMusicas;
        private string donoDaPlaylist;

        public Playlist(string dono)
        {
            listaDeMusicas = new List<Musica>();
            donoDaPlaylist = dono;
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }

        public void TocarMusicaAleatoria()
        {
            if (listaDeMusicas.Count == 0)
            {
                Console.WriteLine("Nenhuma música encontrada na playlist.");
            }
            else
            {
                Random random = new Random();
                int indiceAleatorio = random.Next(0, listaDeMusicas.Count);
                Musica musicaAleatoria = listaDeMusicas[indiceAleatorio];
                Console.WriteLine("Tocando a música: " + musicaAleatoria.nome);
            }
        }
    }
}
