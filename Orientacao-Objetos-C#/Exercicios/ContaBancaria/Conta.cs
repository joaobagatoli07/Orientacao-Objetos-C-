class Conta
{
    public int Numero { get; set; }
    public string Agencia { get; set; }
    public Titular Titular { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da Conta");
        Console.WriteLine($"Numero: {Numero}");
        Console.WriteLine($"Titular: {Titular.Nome} - {Titular.CPF}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
    }
}

