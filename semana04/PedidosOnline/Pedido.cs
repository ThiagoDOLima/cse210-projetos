
using System;
using System.Collections.Generic;

public class Pedido
{
    private List<Produto> produtos;
    private Cliente cliente;

    public Pedido(Cliente cliente)
    {
        this.cliente = cliente;
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (Produto produto in produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        decimal frete = cliente.MoraNosEUA() ? 5 : 35;

        return total + frete;
    }

    public string RetornarEtiquetaEmbalagem()
    {
        string etiqueta = "ETIQUETA DE EMBALAGEM\n";

        foreach (Produto produto in produtos)
        {
            etiqueta += $"Produto: {produto.GetNome()}\n";
            etiqueta += $"ID: {produto.GetIdProduto()}\n";
            etiqueta += "-------------------------\n";
        }

        return etiqueta;
    }

    public string RetornarEtiquetaEnvio()
    {
        return "ETIQUETA DE ENVIO\n" +
               $"Cliente: {cliente.GetNome()}\n" +
               cliente.GetEndereco().RetornarEnderecoCompleto();
    }
}
