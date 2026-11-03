// Criando a classe Diario

// Essa será a classe responsável por administrar todos os registros.


using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{

    // A classe Diario guarda os registros, mas não deixa outras 
    // classes alterarem diretamente sua lista.
    //Isso é um exemplo importante de encapsulamento e abstração.

    private List<Registro> _registros = new List<Registro>();

    private GeradorDePerguntas _gerador = new GeradorDePerguntas();

// Adicionar o Registro
    public void AdicionarRegistro()
    {
        string pergunta = _gerador.ObterPerguntaAleatoria();

        Console.WriteLine(pergunta);
        Console.Write("> ");

        string resposta = Console.ReadLine() ?? "";

        Registro novoRegistro = new Registro(
            DateTime.Now, // Adicona a Data de agora 
            pergunta,
            resposta
        );

        _registros.Add(novoRegistro);

        Console.WriteLine("Registro adicionado com sucesso!");
    }

    public void ExibirDiario()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário está vazio.");
            return;
        }

        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarDiario(string arquivo)
    {
        using (StreamWriter escritor = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                escritor.WriteLine(registro.Data.ToString("o"));
                escritor.WriteLine(registro.Pergunta);
                escritor.WriteLine(registro.Resposta);
            }
        }

        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void CarregarDiario(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string[] linhas = File.ReadAllLines(arquivo);

        if (linhas.Length % 3 != 0)
        {
            Console.WriteLine("Arquivo com formato inválido.");
            return;
        }

        List<Registro> registrosCarregados = new List<Registro>();

        try
        {
            for (int i = 0; i < linhas.Length; i += 3)
            {
                DateTime data = DateTime.Parse(linhas[i]);
                string pergunta = linhas[i + 1];
                string resposta = linhas[i + 2];

                Registro registro = new Registro(data, pergunta, resposta);

                registrosCarregados.Add(registro);
            }

            _registros = registrosCarregados;

            Console.WriteLine("Diário carregado com sucesso!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro ao interpretar os dados do arquivo.");
        }
    }
}
