namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
            //Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar
            //o dono da playlist.Implemente um método para adicionar músicas na lista, para "tocar a música"
            //(só mostrar uma mensagem na tela com o titulo da música).Tente fazer uma reprodução aleatória, 
            //ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

            Playlist minhaPlaylist = new Playlist("Fernando");

            minhaPlaylist.AdicionarMusica(new Musica { nome = "Música 1", autor = "Autor 1", gravadora = "Gravadora 1" });
            minhaPlaylist.AdicionarMusica(new Musica { nome = "Música 2", autor = "Autor 2", gravadora = "Gravadora 2" });
            minhaPlaylist.AdicionarMusica(new Musica { nome = "Música 3", autor = "Autor 3", gravadora = "Gravadora 3" });

            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}