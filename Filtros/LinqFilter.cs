using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_C_.Modelos;

namespace API_C_.Filtros;
public class LinqFilter
{
    //Select
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();

        todosOsGenerosMusicas.ForEach(genero => Console.WriteLine($" - {genero}"));
    }

    //Order by
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistaOrdenados = musicas
        .OrderBy(musica => musica.Artista) // Ordena todas as musicas com base no artista
        .Select(musica => musica.Artista) // Seleciono apenas os artistas
        .Distinct() // Tirar o que e repetido
        .ToList(); // Colocar numa lista de strings

        System.Console.WriteLine("Lista de artista ordenados");
        artistaOrdenados.ForEach(x => Console.WriteLine($"Artista: {x}"));
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas
        .Where(musica => musica.Genero!.Contains(genero))
        .Select(musica => musica.Artista)
        .Distinct()
        .ToList();

        System.Console.WriteLine($"Exibindo os artistas por gênero musical: {genero}");

        artistaPorGeneroMusical.ForEach(x => System.Console.WriteLine($"Artista: {x}"));
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();

        System.Console.WriteLine($"Filtrar musicas do artista: {artista}");
        musicasDoArtista.ForEach(x => System.Console.WriteLine($"Musica: {x}"));
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicaFiltroAno = musicas
        .Where(musica => musica.Ano == ano)
        .OrderBy(musica => musica.Nome)
        .Distinct()
        .ToList();

        System.Console.WriteLine($"Músicas filtradas ano: {ano}");
        musicaFiltroAno.ForEach(x => Console.WriteLine($"Música: {x.Nome} - {x.Artista}"));
    }
    //Filtrar todos os nomes das musicas que esteja na tonalidade C#

    public static void FiltroMusicasTonalidadeCsharp(List<Musica> musicas, string tonalidade)
    {
        //Se for comparação de string utilizar o equals
        var filtroTonalidades = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).Distinct().ToList();
        System.Console.WriteLine($"Tonalidade {tonalidade}");
        filtroTonalidades.ForEach(x => Console.WriteLine($"Música: {x}"));
    }

}