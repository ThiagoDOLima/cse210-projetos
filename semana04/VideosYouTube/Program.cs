
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando o primeiro vídeo
        Video video1 = new Video(
            "Aprendendo C# do Zero",
            "Thiago Lima",
            600
        );

        video1.AdicionarComentario(new Comentario("João", "Excelente aula!"));
        video1.AdicionarComentario(new Comentario("Maria", "Aprendi bastante."));
        video1.AdicionarComentario(new Comentario("Pedro", "Muito bem explicado!"));

        // Criando o segundo vídeo
        Video video2 = new Video(
            "Introdução à Programação Orientada a Objetos",
            "Canal Tecnologia",
            900
        );

        video2.AdicionarComentario(new Comentario("Ana", "Conteúdo muito bom!"));
        video2.AdicionarComentario(new Comentario("Carlos", "Gostei da explicação."));
        video2.AdicionarComentario(new Comentario("Lucas", "Aguardando a próxima aula!"));

        // Criando o terceiro vídeo
        Video video3 = new Video(
            "Como aprender programação",
            "Mundo da Programação",
            450
        );

        video3.AdicionarComentario(new Comentario("Fernanda", "Ótimas dicas!"));
        video3.AdicionarComentario(new Comentario("Roberto", "Muito interessante."));
        video3.AdicionarComentario(new Comentario("Juliana", "Me ajudou bastante!"));

        // Criando uma lista de vídeos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Percorrendo e exibindo os vídeos
        foreach (Video video in videos)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine($"Quantidade de comentários: {video.RetornarNumeroDeComentarios()}");

            Console.WriteLine("\nComentários:");

            video.ExibirComentarios();

            Console.WriteLine("==================================");
        }
    }
}
