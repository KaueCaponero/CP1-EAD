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

        // Método Público que chama o método Interno
        public void showDetailsLoja(List<Loja> listaLojas)
        {
            foreach (var loja in listaLojas)
            {
                loja.getInfosLoja();
            }
        }

        // Método Interno que Retorna os Dados da Loja
        internal void getInfosLoja()
        {
            Console.WriteLine($"A Loja de ID: {id} possui o endereço: {endereco} e o Telefone: {telefone}");
        }

        // Método protected para setar o telefone da loja
        protected void setTelefoneLoja(string telefoneLoja)
        {
            this.telefone = telefoneLoja;
        }

        // Método público que chamará o método privado de setar o telefone da loja
        public void updateTelefoneLoja(Loja loja, string telefoneLoja)
        {
            loja.setTelefoneLoja(telefoneLoja);
        }
    }
}
