Musica musica1 = new Musica();
musica1.Nome = "So Long, London";
musica1.Artista = "Taylor Swift";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);
Console.WriteLine(musica1.Titulo);

musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "Birds";
musica2.Artista = "Imagine Dragons";
musica1.Duracao = 367;
musica1.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica2.ExibirFichaTecnica();
