Banda bandaTaylor = new Banda("The Eras Tour");

Album albumTaylor = new Album("The Tortured Poets Department");

Musica musica1 = new Musica(bandaTaylor, "So Long, London")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(bandaTaylor, "Who's Afraid Of Little Old Me?")
{
    Duracao = 354,
    Disponivel = false,
};

albumTaylor.AdicionarMusica(musica1);
albumTaylor.AdicionarMusica(musica2);
bandaTaylor.AdicionarAlbum(albumTaylor);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumTaylor.ExibirMusicas();
bandaTaylor.ExibirDiscografia();