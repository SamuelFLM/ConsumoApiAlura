using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_C_.Modelos
{
    public class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Chave { get; set; }

        [JsonPropertyName("year")]
        public string? AnoString { get; set; }

        public int Ano { get => Convert.ToInt32(AnoString!); }

        public string Tonalidade { get => tonalidades[Chave]; }

        public void ExibirDetalhesDaMusica()
        {
            System.Console.WriteLine($"Artista: {Artista}");
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            System.Console.WriteLine($"Key: {Tonalidade}");
            System.Console.WriteLine($"Gênero: {Genero}");
        }
    }
}