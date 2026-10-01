internal class Exercicio4
{
    public static void Executar()
    {
        float salario = 6000.00f;

        float CalcularImposto(float salario)
        {
            if(salario <= 2000.00f)
            {
                return salario * 1;
            } else if (salario <=5000.00f) {
                return salario * 0.10f;
            } else
            {
                return salario * 0.20f;
            }
        }
        Console.WriteLine(CalcularImposto(salario));
    }
}