class Episodio
{
    private List<string> convidados = new List<string>();

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Episódio {this.Ordem} - {this.Titulo}, com duração de {this.Duracao} minutos e {string.Join(", ", convidados)} como convidados";

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}