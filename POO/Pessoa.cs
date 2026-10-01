using System;

class Pessoa{
 // propriedades ==  get significa que podemos ler, e set significa que podemos alterar 
    public string Nome {get; set;}
    public int Idade {get;set;}

    // construtor, tem o MESMO NOME da classe e não tem retorno, void, nem nada:
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    // métodos == o que Pessoa faz?
    // void == significa que o método executa uma ação, mas não devolve nenhum valor
    public void Apresentar(){
        Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
    }
    // esse método retorna um valor INTEIRO
    public int AnoNascimento()
    {
        int anoAtual = DateTime.Now.Year;
        return anoAtual-Idade; 
    }
}