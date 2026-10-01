class Produto{
    string Nome {get;set;}
    double Preco {get;set;}
    int Quantidade {get;set;}
    public Produto(string nome, double preco, int quantidade){
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }   
    public double CalcularValorTotal(){
        double ValorTotal = Preco*Quantidade;
    
        return ValorTotal;
    }
    public void DescricaoItem(){
        Console.WriteLine($"Descrição do produt\nNome: {Nome}\nPreço Unitário: R${Preco:F2}\nValor total em estoque: {CalcularValorTotal():F2}");
    }

    public void AdicionarQuantidade(int quantidade){
        if (quantidade > 0){
            Quantidade += quantidade;
            Console.WriteLine($"quantidade atual {Quantidade}");
        }
        else{
            Console.WriteLine("A quantidade deve ser maior que 0");
        }
        
    }
        public void RemoverQuantidade(int quantidade){
        if (quantidade <= 0){
            Quantidade += quantidade;
            Console.WriteLine($"foram removidos {quantidade} de {Nome}\nquantidade atual {Quantidade}");
        }
        else{
            Console.WriteLine("quantidade insuficiente");
        }
        
    }
    
}