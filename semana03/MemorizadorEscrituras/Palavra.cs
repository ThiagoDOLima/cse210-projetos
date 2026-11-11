// ============================================================
// CLASSE PALAVRA
// Responsabilidade: cuidar de UMA palavra da escritura.
// Ela sabe seu texto e se está oculta ou não.
// ============================================================
public class Palavra
{
    // ENCAPSULAMENTO (dados): os campos são PRIVATE.
    // Nenhuma outra classe consegue ler ou alterar esses valores diretamente.
    // O "_" no início é a convenção de C# para campos privados.
    private readonly string _texto;   // readonly: definido uma vez no construtor e nunca mais muda
    private bool _estaOculta;

    // CONSTRUTOR: roda quando fazemos "new Palavra("texto")".
    // Garante que toda Palavra nasce com um texto e começa visível.
    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    // ENCAPSULAMENTO (comportamento): quem está fora não faz "palavra._estaOculta = true".
    // Pede para a própria Palavra se ocultar, através de um método PUBLIC.
    // são os métodos
    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        _estaOculta = false;
    }

    // Permite CONSULTAR o estado sem permitir ALTERAR por fora.
    public bool EstaOculta()
    {
        return _estaOculta;
    }

    // Devolve o texto que deve aparecer na tela.
    // Quem chama não precisa saber se a palavra está oculta: a Palavra decide.
    public string ObterTexto()
    {
        if (_estaOculta)
        {
            // Cada letra/número vira "_". A pontuação (vírgula, ponto) continua visível.
            return string.Concat(_texto.Select(c => char.IsLetterOrDigit(c) ? '_' : c));
        }

        return _texto;
    }
}