using Microsoft.VisualBasic;

internal class Exercicios1
{
    public static void Executar()
    {
        Console.WriteLine("qual a distancia?");
        int distancia = int.Parse(Console.ReadLine()!);

        if (distancia <= 100)
        {
            double precoKM = distancia * 1.5;
            Console.WriteLine($"o preço final será de {precoKM:F2}"); 
        }
        else
        {
            double precoKM = distancia * 1.2;
            Console.WriteLine($"o preço final será de {precoKM:F2}");
        }
        }
    }
