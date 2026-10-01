
internal class Ifelse
{
    private static void Executar(){
        Boolean rodando = true;
        Console.WriteLine("digite seu nome");
        string nome=Console.ReadLine()!;
        while(rodando){

            Console.WriteLine("digite sua idade");
            int idade= int.Parse(Console.ReadLine()!);

            if (idade >= 18){
                Console.WriteLine("entrada liberada");
            } else if(idade >= 16){
                Console.WriteLine("entrada liberada somente com permissão de pais ou responsáveis");
            } else {
                Console.WriteLine("saia daqui imediatamente neguin");
                rodando = false;
            }
        }
    }
}