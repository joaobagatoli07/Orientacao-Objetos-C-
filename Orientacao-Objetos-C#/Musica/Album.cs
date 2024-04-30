﻿class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int Duracao => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esse album você precisa de {Duracao} segundos");
    }
}