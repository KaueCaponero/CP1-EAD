using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Vendedor : Pessoa
    {
        protected string cpf;

        // Construtor Padrão
        public Vendedor()
        {

        }

        // Construtor Especializado
        public Vendedor(Pessoa pessoa, string cpf)
        {
            this.id = pessoa.id;
            this.nome = pessoa.nome;
            this.cpf = cpf;
        }

        // Construtor Completo
        public Vendedor(int id, string nome, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
        }

        // Método que Sobrescreve o Método Virtual de Pessoa
        public override string getNome()
        {
            if (nome == null)
            {
                Console.WriteLine("O Nome do Vendedor não foi cadastrado.");
                return null;
            }
            Console.WriteLine($"O Nome do Vendedor é: {nome}");
            return nome;
        }

        // Método Privado para Retornar o CPF de um Vendedor
        private string getCpf()
        {
            return cpf;
        }
    }
}
