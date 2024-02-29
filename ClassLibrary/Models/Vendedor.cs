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
        protected override void getNome()
        {
            if (nome == null)
            {
                Console.WriteLine("O Nome do Vendedor não foi cadastrado.");
            }
            Console.WriteLine($"O nome do Vendedor é: {nome}");
        }

        // Método Privado para Retornar o CPF de um Vendedor
        private string getCpf()
        {
            return cpf;
        }
    }
}
