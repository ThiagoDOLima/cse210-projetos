using System;

// Crie a classe Curriculo
// Adicione um Método Exibir à Classe Curriculo
public class Curriculo
{
    // Este método não deve ter nenhum parâmetro e não deve retornar nada.
    public string _nome;

    // No corpo do método, você deve exibir o nome da pessoa e, em seguida, percorrer por cada instância de Emprego na lista de empregos e exibi-los.
    public List<Emprego> _empregos = new List<Emprego>();

    // Dica: lembre-se de que você pode chamar o método Exibir de cada emprego que você criou anteriormente.
    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");

        //  Retorne à sua função principal, remova qualquer código que esteja exibindo informações e, em vez disso, adicione uma chamada no final ao método Exibir da sua classe Curriculo para exibir o nome e todos os empregos em uma linha.
        foreach (Emprego emprego in _empregos)
        {
            // 
            emprego.Exibir();
        }
    }
}