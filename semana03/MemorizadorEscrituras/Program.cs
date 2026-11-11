using System;

// ============================================================
// CLASSE PROGRAM
// Responsabilidade: interação com o usuário (tela e teclado).
// Ela NÃO conhece Palavra nem como a Escritura guarda os dados:
// só usa os métodos públicos da Escritura.
// ============================================================
class Program
{
    static void Main()
    {
        // 1) Cria a referência (usa o construtor de INTERVALO: 3:5-6).
        //    Para um versículo só, seria: new Referencia("João", 3, 16)
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        string texto = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. " +
                       "Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.";

        // 2) Cria a escritura, que por dentro cria todas as Palavras.
        Escritura escritura = new Escritura(referencia, texto);

        const int palavrasPorRodada = 3;

        // 3) Laço principal: mostra, pergunta, oculta mais palavras, repete.
        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteOculta())
            {
                Console.WriteLine("Parabéns! Você chegou ao fim do exercício.");
                break;
            }

            Console.WriteLine("Pressione ENTER para ocultar mais palavras ou digite 'sair' para encerrar.");
            string? entrada = Console.ReadLine();

            if (entrada != null && entrada.Trim().ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(palavrasPorRodada);
        }
    }
}