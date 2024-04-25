class Conta
{
    public int numeroIndicador;
    public string titular;
    public double saldo;
    public int senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}

