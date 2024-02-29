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

        // Construtor Padrão - Testado na Linha 290 do Console
        public Autor()
        {

        }

        // Construtor Especializado - Testado na Linha 131 do Console
        public Autor(Pessoa pessoa, string pseudonimo)
        {
            this.id = pessoa.id;
            this.nome = pessoa.nome;
            this.pseudonimo = pseudonimo;
        }

        // Construtor Completo - Não Testado
        public Autor(int id, string nome, string pseudonimo)
        {
            this.id = id;
            this.nome = nome;
            this.pseudonimo= pseudonimo;
        }

        // Método que Sobrescreve o Método Virtual de Pessoa - Testado na Linha 347 do Console
        public override string getNome()
        {
            if (nome == null)
            {
                return null;
            }
            return nome;
        }

        // Método Protegido para Retornar o Pseudonimo de um Autor - Não Testado
        protected string getPseudonimo()
        {
            Console.WriteLine($"O Pseudônimo do autor é: {pseudonimo}");
            return pseudonimo;
        }
    }
}
