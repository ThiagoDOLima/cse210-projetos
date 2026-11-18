

//A definição da classe, Produto, public significa que qualquer outra parte 
// do seu programa pode usar esse molde para criar produtos 
public class Endereco
{

    //Os atributos, o termo private isso protege os dados (encapsulamente)
    //Ninguém de fora consegue alterar
    private string rua;
    private string cidade;
    private string estado;
    private string pais;
    
    //Contrutor
    public Endereco(string rua, string cidade, string estado, string pais)
    {
        this.rua = rua;
        this.cidade = cidade;
        this.estado = estado;
        this.pais = pais;
    }

    public bool EhNosEUA()
    {
        return pais.Equals(
            "USA",
            StringComparison.OrdinalIgnoreCase // StringComparison.OrdinalIgnoreCase: Faz com que a comparação ignore letras maiúsculas e minúsculas. Assim, "usa", "USA" ou "Usa" retornam true.
        ) || pais.Equals( // • || (Operador OU): Garante que o resultado seja verdadeiro se o país for igual a qualquer uma das duas opções.
            "United States",
            StringComparison.OrdinalIgnoreCase
        );
    }

    public string RetornarEnderecoCompleto() //public string RetornarEnderecoCompleto(): Junta todos os dados do endereço em um único texto organizado.
    {
        return $"{rua}\n{cidade}, {estado}\n{pais}"; //$"..." (Interpolação de string): Permite colocar variáveis diretamente dentro das aspas usando chaves ({rua}, {cidade}).
        //\n: Representa uma quebra de linha (como apertar Enter), fazendo com que o endereço fique dividido em três linhas.
    }
}
