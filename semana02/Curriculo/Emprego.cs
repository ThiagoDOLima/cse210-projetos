using System;

// 3 Passo Crie a classe Emprego
public class Emprego
{
    //Crie variáveis membro na classe para cada elemento que esta classe deve conter. Por convenção, essas variáveis membro devem começar com um sublinhado e uma letra minúscula, como _cargo.
    public string _cargo;
    public string _empresa;
    public int _anoInicio;
    public int _anoFim;

    public void Exibir()
    {
        Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim}");
    }

}