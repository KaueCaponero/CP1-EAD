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

        // Construtor Padrão - Não Testado
        public Vendedor()
        {

        }

        // Construtor Especializado - Testado na Linha 739 do Console
        public Vendedor(Pessoa pessoa, string cpf)
        {
            this.id = pessoa.id;
            this.nome = pessoa.nome;
            this.cpf = cpf;
        }

        // Construtor Completo - Não Testado
        public Vendedor(int id, string nome, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
        }

        // Método que Sobrescreve o Método Virtual de Pessoa - Testado na Linha 800 do Console
        public override string getNome()
        {
            if (nome == null)
            {
                Console.WriteLine("O NOME do Vendedor não foi cadastrado.");
                return null;
            }
            Console.WriteLine($"O NOME do Vendedor é: {nome}");
            return nome;
        }

        // Método Público que Chama o Método Privado - Testado na Linha 769 do Console
        public void printCpf(Vendedor vendedor)
        {
            Console.WriteLine($"CPF: {vendedor.getCpf()}");
        }

        // Método Privado para Retornar o CPF de um Vendedor - Testado na Linha 769 do Console Através do Método printCpf
        private string getCpf()
        {
            return cpf;
        }
    }
}
