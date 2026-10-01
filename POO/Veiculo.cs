public abstract class Veiculo // classe mãe tendo caracteristicas gerais de qualquer veiculo
{
    public string Modelo {get;set;}
    public string Placa {get;set;}
    public double Quilometragem {get; private set;}

    public Veiculo(string modelo, string placa, double quilometragem)
    {
        Modelo = modelo;
        Placa = placa;
        Quilometragem = quilometragem;
    }

    public void RegistrarViagem(double KMPercorridos)
    {
        if (KMPercorridos > 0)
        {   
            Quilometragem += KMPercorridos; 
            Console.WriteLine($"Quilometragem atual: {Quilometragem}");
        }
        else
        {
            Console.WriteLine("A viagem percorrida deve ser maior que zero.");
        }
    }
    
    public virtual void ExibirFicha()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Quilometragem: {Quilometragem}");
    }

    public abstract double CalcularCustoRevisao();
}