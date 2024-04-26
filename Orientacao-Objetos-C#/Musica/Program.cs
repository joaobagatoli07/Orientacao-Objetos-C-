Album albumTaylor = new Album();
albumTaylor.Nome = "The Tortured Poets Department";

Musica musica1 = new Musica();
musica1.Nome = "So Long, London";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Who's Afraid Of Little Old Me?";
musica2.Duracao = 354;

albumTaylor.AdicionarMusica(musica1);
albumTaylor.AdicionarMusica(musica2);

albumTaylor.ExibirMusicas();
