using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Pessoa
    {
        public int id;
        public string nome;

        // Construtor Padrão
        public Pessoa()
        {

        }

        // Construtor Especializado
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        // Construtor Completo
        public Pessoa(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        // Método Virtual para ser Sobrescrito
        protected virtual void getNome()
        {
            Console.WriteLine(nome);
        }
    }
}
