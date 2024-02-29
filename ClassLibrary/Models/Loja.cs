using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Loja
    {
        protected int id;
        protected string endereco;
        protected string telefone;

        // Construtor Especializado
        public Loja(int id)
        {
            this.id = id;
        }

        // Construtor Completo
        public Loja(int id, string endereco, string telefone) : this(id)
        {
            this.endereco = endereco;
            this.telefone = telefone;
        }

        // Construtor Chamando Outro Construtor
        public Loja() : this(1) { }

        // Método Interno que Retorna os Dados da Loja
        internal void getInfosLoja()
        {
            Console.WriteLine($"O Endereço da Loja é: {endereco} e o Telefone é: {telefone}");
        }
    }
}
