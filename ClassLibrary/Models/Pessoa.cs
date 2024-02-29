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

        // Construtor Padrão - Testado na Linha 124 do Console
        public Pessoa()
        {

        }

        // Construtor Especializado - Testado na Linha 597 do Console
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        // Construtor Completo - Testado na Linha 20 do Console
        public Pessoa(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        // Método Virtual para ser Sobrescrito - Testado na Linha 626 do Console
        public virtual string getNome()
        {
            return nome;
        }
    }
}
