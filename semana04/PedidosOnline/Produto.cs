

//Entenda o encapsulamento:
//Os atributos são private, portanto não podem ser acessados diretamente por outras classes.
//Por que private?: Essa palavra-chave protege os dados (encapsulamento). Ninguém de fora da classe pode alterar esses valores diretamente por acidente.

public class Produto
{
    // Os atributos (dados guardados)
    private string nome;
    private string idProduto;
    private decimal preco;
    private int quantidade;

    //O construtor (criando o produto)

    //public Produto(string nome, ...) : É um método especial que tem o mesmo nome da classe.
    // Ele é executado automaticamente no momento em que você cria um produto novo(usando new Produto(...))
    //  e obriga você a preencher todas as informações iniciais.
    //this.nome = nome;: A palavra this serve para diferenciar o atributo da classe(this.nome) 
    // do valor que acabou de chegar nos parênteses(nome).
    public Produto(string nome, string idProduto, decimal preco, int quantidade)
    {
        this.nome = nome;
        this.idProduto = idProduto;
        this.preco = preco;
        this.quantidade = quantidade;
    }
    //Os métodos GetNome(), GetPreco() e outros permitem consultar os dados.
    public string GetNome()
    {
        return nome;
    }

    public string GetIdProduto()
    {
        return idProduto;
    }

    public decimal GetPreco()
    {
        return preco;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }
    //O método CalcularCustoTotal() calcula o preço multiplicado pela quantidade.
    public decimal CalcularCustoTotal()
    {
        return preco * quantidade;
    }
}