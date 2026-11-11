// ============================================================
// CLASSE ESCRITURA
// Responsabilidade: juntar a Referencia e as Palavras, e controlar
// o exercício de memorização (ocultar palavras, montar o texto).
// ============================================================
public class Escritura
{
    // Dados PRIVADOS. Program não consegue mexer na lista de palavras diretamente.
    // Só a Escritura sabe como ela está organizada por dentro.
    private readonly Referencia _referencia;
    private readonly List<Palavra> _palavras;

    // CONSTRUTOR: recebe a referência e o texto completo (uma string só).
    // Aqui o texto é "quebrado" em palavras, e cada pedaço vira um objeto Palavra.
    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = texto
            .Split(' ', StringSplitOptions.RemoveEmptyEntries) // separa por espaços
            .Select(p => new Palavra(p))                       // cria uma Palavra para cada pedaço
            .ToList();
    }

    // Oculta N palavras sorteadas.
    // Repare: a Escritura NÃO mexe no estado interno da Palavra.
    // Ela só chama palavra.Ocultar() e a Palavra cuida do resto (encapsulamento).
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        // Sorteia apenas entre as que ainda estão visíveis, para nunca repetir uma já oculta.
        List<Palavra> visiveis = _palavras.Where(p => !p.EstaOculta()).ToList();

        // Evita erro caso peçam para ocultar mais palavras do que ainda restam.
        int quantidade = Math.Min(numeroParaOcultar, visiveis.Count);

        for (int i = 0; i < quantidade; i++)
        {
            int indice = Random.Shared.Next(visiveis.Count);
            visiveis[indice].Ocultar();
            visiveis.RemoveAt(indice); // tira da lista de sorteio
        }
    }

    // Junta a referência com o texto atual de cada palavra (visível ou com "_").
    public string ObterTexto()
    {
        string texto = string.Join(" ", _palavras.Select(p => p.ObterTexto()));
        return $"{_referencia.ObterTexto()} {texto}";
    }

    // Retorna true somente se TODAS as palavras estiverem ocultas.
    // O Program usa isso para saber quando encerrar, sem ver a lista interna.
    public bool EstaCompletamenteOculta()
    {
        return _palavras.All(p => p.EstaOculta());
    }
}