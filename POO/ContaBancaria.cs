 public class ContaBancaria
{
    // propriedades da conta 
    public string Titular {get;set;}
    public int NumeroConta{get;set;}
    public double Saldo{get; private set;}


    public ContaBancaria(string titular, int numeroConta, double saldoInicial){
        Titular = titular;
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }
    // método para depositar / soma ao saldo
    public void Depositar(double valor)
    {
        Saldo +=valor;
        Console.WriteLine($"Deposito de {valor} realizado na sua conta! Saldo atual de: R${Saldo}");
    }

    // método para sacar / subtração ao saldo
    public void Sacar(double valor)
    {
        if (Saldo >=valor){
            Saldo -=valor;
            Console.WriteLine($"Saque realizado com sucesso. Saldo atual de: R${Saldo}");
        } else{
            Console.WriteLine("saldo insuficiente para a transação");
        }
    }
}