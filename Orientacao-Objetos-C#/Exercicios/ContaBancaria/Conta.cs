class Conta
{
    public int Numero { get; set; }
    public int Agencia { get; set; }
    public Titular Titular { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }
    public string Resumo => $"Conta nº {Numero} - Agência {Agencia} / Titular: {Titular.Nome} - {Titular.Cpf} / Saldo: {Saldo} e Limite: {Limite}";

    public Conta(int numero, int agencia, Titular titular, double saldo, double limite)
    {
        Numero = numero;
        Agencia = agencia;
        Titular = titular;
        Saldo = saldo;
        Limite = limite;
    }
}

