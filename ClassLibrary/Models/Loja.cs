using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Loja
    {
        public int id;
        public string endereco;
        public string telefone;

        // Construtor Especializado - Não Testado
        public Loja(int id)
        {
            this.id = id;
        }

        // Construtor Completo - Não Testado
        public Loja(int id, string endereco, string telefone) : this(id)
        {
            this.endereco = endereco;
            this.telefone = telefone;
        }

        // Construtor Chamando Outro Construtor - Testado na Linha 455 do Console
        public Loja() : this(1) { }

        // Método Público que Chama o Método Internal - Testado na Linha 478 do Console
        public void showDetailsLoja(List<Loja> listaLojas)
        {
            foreach (var loja in listaLojas)
            {
                loja.getInfosLoja();
            }
        }

        // Método Internal que Retorna os Dados da Loja - Testado na Linha 496 do Console Através do Médoto showDetailsLoja
        internal void getInfosLoja()
        {
            Console.WriteLine($"A Loja de ID: {id} possui o endereço: {endereco} e o Telefone: {telefone}");
        }

        // Método Protected para Setar o Telefone da Loja - Testado na Linha 468 do Console Através do Método updateTelefoneLoja
        protected void setTelefoneLoja(string telefoneLoja)
        {
            this.telefone = telefoneLoja;
        }

        // Método Público que Chama o Método Privado de Setar o Telefone da Loja - Testado na Linha 468 do Console
        public void updateTelefoneLoja(Loja loja, string telefoneLoja)
        {
            loja.setTelefoneLoja(telefoneLoja);
        }
    }
}
