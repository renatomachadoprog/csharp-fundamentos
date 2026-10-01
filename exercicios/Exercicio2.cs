internal class Exercicio2
{
    public static void Executar()
    {   
        Console.WriteLine("Digite um número para ser exibido os pares até 0");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 0; i <= numero; i++)
        {
            if(i%2==0){
                Console.WriteLine(i);
            }
            
        }
    }
}