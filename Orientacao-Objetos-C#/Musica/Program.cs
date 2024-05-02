//Banda bandaTaylor = new Banda("The Eras Tour");

//Album albumTaylor = new Album("The Tortured Poets Department");

//Musica musica1 = new Musica(bandaTaylor, "So Long, London")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(bandaTaylor, "Who's Afraid Of Little Old Me?")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumTaylor.AdicionarMusica(musica1);
//albumTaylor.AdicionarMusica(musica2);
//bandaTaylor.AdicionarAlbum(albumTaylor);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumTaylor.ExibirMusicas();
//bandaTaylor.ExibirDiscografia();

Episodio ep1 = new Episodio(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new Episodio(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Leticia", "Dicas Agora");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


