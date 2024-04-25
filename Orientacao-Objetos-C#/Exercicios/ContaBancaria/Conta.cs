class Conta
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}

