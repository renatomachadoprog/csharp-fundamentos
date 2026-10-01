internal class Exercicio3
{
    public static void Executar()
    {
        int idade = 18;
        string ConfereIdade(int idade)
        {
            return idade >=18 ? "aprovado" : "reprovado";
        }
        Console.WriteLine(ConfereIdade(idade));
    }
}