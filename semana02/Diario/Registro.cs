
// Quando o usuario ele responde uma 
// pergunta criaremos um objeto para Registro
public class Registro
{
    public DateTime Data { get; set; }
    public string Pergunta { get; set; }
    public string Resposta { get; set; }

    public Registro(DateTime data, string pergunta, string resposta)
    {
        Data = data;
        Pergunta = pergunta;
        Resposta = resposta;
    }

    public void Exibir()
    {
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine($"Pergunta: {Pergunta}");
        Console.WriteLine($"Resposta: {Resposta}");
        Console.WriteLine("--------------------------------");
    }
}
