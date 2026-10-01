internal class Switchcase
{
    public static void Executar()
    {
        int opcao = -1;
        while (opcao != 0){
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("1-saque");
            Console.WriteLine("2-depósito");
            Console.WriteLine("3-saldo");
            Console.WriteLine("0-sair");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Saque realizado com sucesso");
                    break;
                case 2:
                    Console.WriteLine("deposito realizado com sucesso");
                    break;
                case 3: 
                    Console.WriteLine("saldo atual de R$0,67");
                    break;
                default:
                    Console.WriteLine("opção inválida, tente novamente");
                    break;
            }
        } Console.WriteLine("Programa encerrado, obrigado por usá-lo");
    
    }
}