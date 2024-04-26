Titular pessoa = new Titular();
pessoa.Nome = "João";
pessoa.CPF = "134-195-276.81";

Conta conta = new Conta();
conta.Numero = 123;
conta.Agencia = "X";
conta.Titular = pessoa;
conta.Saldo = 350;
conta.Limite = 2000;
conta.ExibirInformacoes();



