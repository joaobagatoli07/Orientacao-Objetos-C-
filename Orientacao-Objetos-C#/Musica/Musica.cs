﻿class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public Genero Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Titulo => $"{Nome} - {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
            Console.WriteLine("Disponível no plano");
        else
            Console.WriteLine("Adquira o plano Plus");
    }
}

