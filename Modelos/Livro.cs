
using System.Text.Json.Serialization;

namespace DesafioApi4.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Nome { get; set; }
    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }
    [JsonPropertyName("editora")]
    public string? Editora { get; set; }
}
