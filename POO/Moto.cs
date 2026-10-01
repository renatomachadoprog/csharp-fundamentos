public class Moto : Veiculo
{
    public int Cilindradas {get;set;}
    public Moto(string modelo, string placa, int quilometragem, int cilindradas): base(modelo, placa, quilometragem)
    {
        Cilindradas = cilindradas;
    }
    public override void ExibirFicha()
    {
        base.ExibirFicha();
        Console.WriteLine($"Cilindradas: {Cilindradas}");
    }
    public void Empinar()
    {
        Console.WriteLine($"OOOOOOOOOOOpa Henrique tá empinando a {Modelo} de {Cilindradas}, grau com atenção!");
    }
    public override double CalcularCustoRevisao()
    {
        return 150 + (Cilindradas*0.5);
    }
}