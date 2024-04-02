using System.Text.Json;
using API_C_.Modelos;
using API_C_.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[100].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Wiz Khalifa");
        // LinqFilter.FiltrarMusicasPeloAno(musicas, 2010);
        LinqFilter.FiltroMusicasTonalidadeCsharp(musicas, "C#");

        // MusicasPreferidas musicasPreferidas = new MusicasPreferidas("Samuel");

        // musicasPreferidas.AdicionarMusicaFavoritas(musicas[1]);
        // musicasPreferidas.AdicionarMusicaFavoritas(musicas[377]);
        // musicasPreferidas.AdicionarMusicaFavoritas(musicas[4]);
        // musicasPreferidas.AdicionarMusicaFavoritas(musicas[6]);
        // musicasPreferidas.AdicionarMusicaFavoritas(musicas[1467]);

        // musicasPreferidas.GerarArquivoJson();
        // musicasPreferidas.GerarArquivoTxt();


        // Desafio - minha forma.

        // Dictionary<int, string> chaveMusica = new Dictionary<int, string>()
        // {
        //     { 0, "C" },
        //     { 1, "C#" },
        //     { 2, "D" },
        //     { 3, "D#" },
        //     { 4, "E" },
        //     { 5, "F" },
        //     { 6, "F#" },
        //     { 7, "G" },
        //     { 8, "G#" },
        //     { 9, "A" },
        //     { 10, "A#" },
        //     { 11, "B" }
        // };

        // System.Console.WriteLine("Conversão de valores: ");

        // foreach (var musica in musicas)
        // {
        //     System.Console.WriteLine(chaveMusica[musica.Chave]);
        // }



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }
}

