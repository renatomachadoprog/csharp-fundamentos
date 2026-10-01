 using System;

public class Caminhao : Veiculo, IVistoria  // classe que herda métodos /funções de outra classe
{
    public double CargaMaximaToneladas{get;set;}

    // : base (modelo, placa, quilometragem) -> envia essas 3 variaveis para a classe Veiculo        
    public Caminhao(string modelo, string placa, double quilometragem, double cargamaximatoneladas) : base(modelo,placa, quilometragem)
    {
        CargaMaximaToneladas = cargamaximatoneladas;
    }
    public override void ExibirFicha()
    {
        base.ExibirFicha();
        Console.WriteLine($"Carga máxima em toneladas: {CargaMaximaToneladas}");
    }
    public void Carregar(double pesoCarga)
    {
        if(pesoCarga <= CargaMaximaToneladas)
        {
            Console.WriteLine($"Caminhão {Modelo} carregado com {pesoCarga} toneladas!");
        }
        else
        {
        Console.WriteLine($"Carga de {pesoCarga} excede a capacidade máxima de {CargaMaximaToneladas}");
        }
    }

    public override double CalcularCustoRevisao()
    {
        return 500 + (CargaMaximaToneladas *50);
    }

    public bool RealizarVistoria()
    {
        if(Quilometragem < 100000)
        {
            Console.WriteLine($"vistoria aprovada para o veículo {Modelo} (placa> {Placa})");
            return true;
        } else
        {
            Console.WriteLine($"Vistoria reprovada para o veículo {Modelo} placa> {Placa}. Motivo: Quilometragem muito alta. ({Quilometragem} km.)");
            return false;
        }
    }

}