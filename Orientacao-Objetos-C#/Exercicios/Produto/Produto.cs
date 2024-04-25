class Produto
{
    private float preco;
    private int estoque;

    public string Nome { get; set; }
    public string Marca { get; set; }
    public float Preco 
    {
        get => preco; 
        set
        {
            if (value > 0)
                preco = value;
            else
                Console.WriteLine("Insira um preço válido");
        }
    }
    public int Estoque 
    {
        get => estoque; 
        set
        {
            if (value > 0)
                estoque = value;
            else
                Console.WriteLine("Insira um estoque válido");
        }
    }
    public string DescricaoProduto => $"Produto: {Nome}, Marca: {Marca}, Preço: {Preco}, Estoque: {Estoque}";
}