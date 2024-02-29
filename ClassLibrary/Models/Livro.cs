using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Livro
    {
        public int id;
        public string titulo;
        public Autor autor;
        public double preco;

        // Construtor Especializado - Não Testado
        public Livro(string titulo, Autor autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        // Construtor Completo - Testado Na Linha 317 do Console 
        public Livro(int id, string titulo, Autor autor, double preco)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.preco = preco;
        }

        // Construtor Chamando Outro Construtor - Não Testado
        public Livro(Autor autor) : this("Título 01", autor) { }
    }
}
