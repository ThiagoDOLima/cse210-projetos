// Requisitos de Design
// Além disso, seu programa deve:

// Conter classes para os principais componentes do programa.
// Conter pelo menos duas classes além da classe Program.
// Demonstrar o princípio da abstração usando variáveis membro e métodos adequadamente.


using System;

class Program
{
    static void Main(string[] args)
    {
        
        Diario diario = new Diario();

        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine();
            Console.WriteLine("===== MEU DIARIO =====");
            Console.WriteLine();
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diario");
            Console.WriteLine("3. Salvar diario");
            Console.WriteLine("4. Carregar diario");
            Console.WriteLine("5. Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opcao: ");
            opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    diario.AdicionarRegistro();
                    break;

                case "2":
                    diario.ExibirDiario();
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo: ");
                    string arquivoSalvar = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(arquivoSalvar))
                    {
                        diario.SalvarDiario(arquivoSalvar);
                    }
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo: ");
                    string arquivoCarregar = Console.ReadLine() ?? "";

                    if (!string.IsNullOrWhiteSpace(arquivoCarregar))
                    {
                        diario.CarregarDiario(arquivoCarregar);
                    }
                    break;

                case "5":
                    Console.WriteLine("Obrigado por utilizar o diario!");
                    break;

                default:
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    break;
            }
        }
    }
}
