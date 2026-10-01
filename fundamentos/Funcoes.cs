internal class Funcoes{
    public static void Executar(){
        double CalcularDesc(double precoOriginal, double porcentagem)
        {
            double valorDesconto = precoOriginal * (porcentagem/100);
            double precoFinal = precoOriginal - valorDesconto;

            return precoFinal;
        }

        Console.WriteLine(CalcularDesc(1874,8));
    }
}