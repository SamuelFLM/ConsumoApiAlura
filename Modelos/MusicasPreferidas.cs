using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace API_C_.Modelos;
public class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> listaDeMusicasFavoritas;


    public MusicasPreferidas(string? nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicaFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {

        Console.WriteLine($"Essa são as músicas favoritas -> {Nome}");
        listaDeMusicasFavoritas.ForEach(x => Console.WriteLine($" -  {x.Nome} de {x.Artista}"));
    }

    public void GerarArquivoJson()
    {   //Objeto anonimo (Criar uma estrutura temporaria)
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
    }
    public void GerarArquivoTxt()
    {

        string nomeArquivo = $"musicas-favoritas-{Nome}.txt";

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");

            listaDeMusicasFavoritas.ForEach(x => arquivo.WriteLine($" - {x.Nome}"));

            arquivo.Close();
        }

        System.Console.WriteLine("Arquivo finalizado.");

    }
}