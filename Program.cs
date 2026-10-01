using System;
using System.Collections.Generic;
using System.Globalization;

List<Veiculo> frota = new List<Veiculo>();
frota.Add(new Moto("Kawasaki Z900", "ABC1A23", 80000, 900));
frota.Add(new Caminhao("volvo", "add2B34", 12989, 20));
frota.Add(new Caminhao("Scania fudido", "old9d99", 1000000, 40));

foreach (Veiculo veiculo in frota)
{
    veiculo.ExibirFicha();
    Console.WriteLine($"Preço estimado de revisão: R${veiculo.CalcularCustoRevisao():F2}");
}
foreach(Veiculo veiculo in frota)
{
    if(veiculo is IVistoria vistoriavel)
    {
        vistoriavel.RealizarVistoria();
    }
    else
    {
        Console.WriteLine($"o veiculo {veiculo.Modelo} não necessita de vistorias.");
    }
}

