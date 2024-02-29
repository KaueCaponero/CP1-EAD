using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Autor : Pessoa
    {
        public string pseudonimo;

        // Construtor Padrão
        public Autor()
        {

        }

        // Construtor Especializado
        public Autor(Pessoa pessoa, string pseudonimo)
        {
            this.id = pessoa.id;
            this.nome = pessoa.nome;
            this.pseudonimo = pseudonimo;
        }

        // Construtor Completo
        public Autor(int id, string nome, string pseudonimo)
        {
            this.id = id;
            this.nome = nome;
            this.pseudonimo= pseudonimo;
        }

        // Método que Sobrescreve o Método Virtual de Pessoa
        protected override void getNome()
        {
            if (nome == null)
            {
                Console.WriteLine("Nome é nulo.");
            }
            Console.WriteLine($"O nome do Autor é: {nome}");
        }

        // Método Protegido para retornar o Pseudonimo de um Autor
        protected string getPseudonimo()
        {
            Console.WriteLine($"O Pseudônimo do autor é: {pseudonimo}");
            return pseudonimo;
        }
    }
}
