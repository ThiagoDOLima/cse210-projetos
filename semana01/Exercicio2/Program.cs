using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Qual o porcentual da sua nota? ");
        string resposta = Console.ReadLine();
        int percentual = int.Parse(resposta);

        string letra = "";

        if (percentual >= 90)
        {
            letra = "A";
        }
        else if (percentual >= 80)
        {
            letra = "B";
        }
        else if (percentual >= 70)
        {
            letra = "C";
        }
        else if (percentual >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }
        // Determinar o sinal da nota
        int ultimoDigito = percentual % 10;
        string sinal = "";

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }
        // Tratar as exceções

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }

        if (letra == "F")
        {
            sinal = "";
        }

        // Exiba a nota

        Console.WriteLine($"Sua nota é: {letra} {sinal}");

        // Verifica aprovação

        if (percentual >= 70)
        {
            Console.WriteLine("Você passou");
        }
        else
        {
            Console.WriteLine("Mais sorte da próxima vez!");
        }
    }
}
