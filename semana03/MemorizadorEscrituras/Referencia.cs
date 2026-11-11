// ============================================================
// CLASSE REFERENCIA
// Responsabilidade: representar "onde" a escritura está na Bíblia,
// por exemplo "João 3:16" ou "Provérbios 3:5-6".
// ============================================================
public class Referencia
{
    // Dados PRIVADOS: ninguém de fora altera livro, capítulo ou versículos.
    private readonly string _livro;
    private readonly int _capitulo;
    private readonly int _versiculo;        // primeiro versículo
    private readonly int _ultimoVersiculo;  // último versículo (igual ao primeiro se for só um)

    // CONSTRUTOR 1: um único versículo. Ex.: new Referencia("Provérbios", 3, 5)
    // Como só há um versículo, o "último" é igual ao primeiro.
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = versiculo;
    }

    // CONSTRUTOR 2: intervalo de versículos. Ex.: new Referencia("Provérbios", 3, 5, 6)
    // É uma SOBRECARGA (overload): mesmo nome, parâmetros diferentes.
    // O C# escolhe qual usar pela quantidade de argumentos. É isso que o requisito 3 pede.
    public Referencia(string livro, int capitulo, int primeiroVersiculo, int ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = primeiroVersiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    // Monta o texto da referência. Quem usa a classe não precisa saber
    // se é um versículo ou um intervalo: a própria Referencia decide o formato.
    public string ObterTexto()
    {
        if (_versiculo == _ultimoVersiculo)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";            // "Provérbios 3:5"
        }

        return $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}"; // "Provérbios 3:5-6"
    }
}