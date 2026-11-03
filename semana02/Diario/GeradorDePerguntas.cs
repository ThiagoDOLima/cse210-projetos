// Criando a classe GeradorDePerguntas

// O que cada coisa Faz

// private List<string>: armazena as perguntas.
// Random: gera números aleatórios._random.Next(_perguntas.Count): escolhe uma posição aleatória da lista.
// return: devolve a pergunta escolhida.

public class GeradorDePerguntas
{
    // armazena as perguntas.
    private List<string> _perguntas = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa hoje, o que seria?",
        "O que aprendi de novo hoje?",
        "Pelo que sou grato hoje?"
    };

    private Random _random = new Random();

    public string ObterPerguntaAleatoria()
    {
        // escolhe uma posição aleatória da lista.
        int indice = _random.Next(_perguntas.Count);
        // devolve a pergunta escolhida.
        return _perguntas[indice];
    }
}
