using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Livro
    {
        protected int id;
        protected string titulo;
        protected Autor autor;
        protected double preco;

        // Construtor Especializado
        public Livro(string titulo, Autor autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        // Construtor Completo
        public Livro(int id, string titulo, Autor autor, double preco)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.preco = preco;
        }

        // Construtor Chamando Outro Construtor
        public Livro(Autor autor) : this("Título 01", autor) { }
    }
}
