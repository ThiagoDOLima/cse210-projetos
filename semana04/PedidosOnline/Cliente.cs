

//Classe cliente
public class Cliente
{
    private string nome;
    private Endereco endereco;

    public Cliente(string nome, Endereco endereco)
    {
        this.nome = nome;
        this.endereco = endereco;
    }

    public string GetNome()
    {
        return nome;
    }

    public Endereco GetEndereco()
    {
        return endereco;
    }

    public bool MoraNosEUA()
    {
        return endereco.EhNosEUA();
    }
}
