class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProdutos(Produto produto)
    {
        produtos.Add(produto);
    }

    public void ExibirEstoque()
    {
        foreach(var produto in produtos)
        {
            Console.WriteLine(produto.DescricaoProduto);
        }
    }
}