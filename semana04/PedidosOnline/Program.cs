
using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CultureInfo cultura = CultureInfo.GetCultureInfo("en-US");

        // PRIMEIRO CLIENTE - ESTADOS UNIDOS
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "John Smith",
            endereco1
        );

        // PRIMEIRO PEDIDO
        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(
            new Produto("Notebook", "P001", 1200.00m, 1)
        );

        pedido1.AdicionarProduto(
            new Produto("Mouse", "P002", 25.00m, 2)
        );

        pedido1.AdicionarProduto(
            new Produto("Teclado", "P003", 50.00m, 1)
        );

        // SEGUNDO CLIENTE - BRASIL
        Endereco endereco2 = new Endereco(
            "Rua das Flores, 100",
            "São Paulo",
            "SP",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "Maria Silva",
            endereco2
        );

        // SEGUNDO PEDIDO
        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(
            new Produto("Monitor", "P004", 300.00m, 1)
        );

        pedido2.AdicionarProduto(
            new Produto("Headset", "P005", 80.00m, 2)
        );

        pedido2.AdicionarProduto(
            new Produto("Webcam", "P006", 45.00m, 1)
        );

        // LISTA DE PEDIDOS
        List<Pedido> pedidos = new List<Pedido>();

        pedidos.Add(pedido1);
        pedidos.Add(pedido2);

        // EXIBIR OS PEDIDOS
        int numeroPedido = 1;

        foreach (Pedido pedido in pedidos)
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine($"PEDIDO {numeroPedido}");
            Console.WriteLine("====================================");

            Console.WriteLine();
            Console.WriteLine(pedido.RetornarEtiquetaEmbalagem());

            Console.WriteLine(pedido.RetornarEtiquetaEnvio());

            Console.WriteLine();
            Console.WriteLine(
                $"VALOR TOTAL: {pedido.CalcularTotal().ToString("C", cultura)}"
            );

            Console.WriteLine("====================================");

            numeroPedido++;
        }
    }
}
