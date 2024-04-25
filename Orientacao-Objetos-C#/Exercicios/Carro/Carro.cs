class Carro
{
    private int ano;

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano 
    { 
        get => ano; 
        set
        {
            if (value > 1960 && value < 2023)
                Ano = value;
            else
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
        } 
    }
    public string Fabricante { get; set; }
    public string DescricaoDetalhada => $"Marca: {Marca}, Modelo: {Fabricante}, Fabricante: {Fabricante}, Ano: {Ano}";

    public void Acelerar()
    {
        Console.WriteLine("Carro acelerando!");
    }

    public void Frear()
    {
        Console.WriteLine("Carro freando!");
    }

    public void Buzinar()
    {
        Console.WriteLine("Carro buzinando!");
    }
}