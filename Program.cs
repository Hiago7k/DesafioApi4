using DesafioApi4.Filtros;
using DesafioApi4.Modelos;
using System.Text.Json;

using (HttpClient httpClient = new HttpClient()) 
{
    try
    {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        LinqFilter.ListarLivrosFiltrados(livros);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Erro {ex:Message}");
    } 
}