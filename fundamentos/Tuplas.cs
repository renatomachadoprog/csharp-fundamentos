internal class Tuplas{
    public static void Executar()
    {
        var pt = (x:5, y:2);

        var slope = pt.y / pt.x;
        Console.WriteLine($"a linha que tem origem no ponto {pt} tem um 'slope' de {slope}");

        pt.x = pt.x+5;
        Console.WriteLine($"o ponto agora está em {pt}");

        var pt2 = pt with {y =10};
        Console.WriteLine(pt2);

        var subscript = (a:0, b:0);
        subscript = pt;
        Console.WriteLine(subscript);

    }
}