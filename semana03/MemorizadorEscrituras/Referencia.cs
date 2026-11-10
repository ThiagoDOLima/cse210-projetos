

// Declarando as variáveis e o tipo 
using System.Runtime.InteropServices;

public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    // Contrutor para um único versículo
    public Referencia(string livro, int _capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculoInicial;
        _versiloFinal = versiculoFinal;
    }

    // Retorna a referência formatada
    public string ObterReferencia()
    {
        if (_versiculoInicial == _versiculoFinal)
        {

            return $"{_livro} {_capitulo}:{_versiculoInicial}";

        }

        return $"{_livro} {_capitulo}:{_versiculoInicial}-{versiculoFinal}";
    
    }    
}