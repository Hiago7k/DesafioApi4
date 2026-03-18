using DesafioApi4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioApi4.Filtros;
using DesafioApi4.Modelos;

internal class LinqFilter
{
    public static void ListarLivrosFiltrados(List<Livro> livros) 
    {
        var livrosFiltrados = livros.Select(livros => livros.Nome).Distinct().ToList();
        foreach (var filme in livrosFiltrados) 
        {
            Console.WriteLine("- {filme}");
        }
    }

}
