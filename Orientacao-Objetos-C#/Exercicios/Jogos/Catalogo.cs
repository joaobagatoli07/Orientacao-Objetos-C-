class Catalogo
{
    public List<Jogo> Jogos { get; set; }

    public Catalogo()
    {
        Jogos = new List<Jogo>();
    }

    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
    }

    public void ListarJogos()
    {
        if (Jogos.Count > 0)
        {
            Console.WriteLine("Catálogo de Jogos");
            foreach(var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }

    public void RemoverJogo(Jogo jogo)
    {
        Jogos.Remove(jogo);
    }
}