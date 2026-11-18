//Classe	Responsabilidade
//Video Armazenar título, autor, duração e comentários.
//Comentario	Armazenar o nome do autor e o texto do comentário.
//Program	Criar os vídeos, adicionar comentários e exibir os resultados.

//Essa classe será responsável por armazenar duas informações: 
// quem comentou e o texto do comentário.
public class Comentario
{
    //private set: impede que outras classes alterem diretamente esses valores.
    public string Nome { get; private set; } 
    public string Texto { get; private set; }
    
    // construtor
    public Comentario(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }
}

//Entendendo o código:
//public class Comentario : cria a classe.
//Nome: armazena o nome da pessoa.
//Texto: armazena o conteúdo do comentário.

//Comentario(string nome, string texto): construtor que recebe os dados na criação do objeto.