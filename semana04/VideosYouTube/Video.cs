//Essa é a classe principal da atividade. Ela armazenará os dados do vídeo e uma lista de comentários.
using System.Collections.Generic;

public class Video
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int Duracao { get; private set; }

    private List<Comentario> comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        Titulo = titulo;
        Autor = autor;
        Duracao = duracao;

        comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        comentarios.Add(comentario);
    }

    public int RetornarNumeroDeComentarios()
    {
        return comentarios.Count;
    }

    public void ExibirComentarios()
    {
        foreach (Comentario comentario in comentarios)
        {
            Console.WriteLine($" {comentario.Nome}: {comentario.Texto}");   
        }
    }
}


//Entendendo os pontos principais:
//List<Comentario>: permite armazenar vários comentários dentro de um vídeo.
//AdicionarComentario(): adiciona um comentário à lista.
//RetornarNumeroDeComentarios(): retorna a quantidade de comentários.
//ExibirComentarios(): percorre a lista e mostra todos os comentários.
//Observe que a classe Video utiliza a classe Comentario. Isso demonstra o relacionamento entre objetos.