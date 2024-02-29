// Mensagem de Inicialização
using ClassLibrary.Models;

Console.WriteLine("Projeto Console - CP1 - C# - RM96466 e RM 96848");

// Declarando Listas
var listaAutores = new List<Autor>();
var listaLivros = new List<Livro>();
var listaLojas = new List<Loja>();
var listaPessoas = new List<Pessoa>();
var listaVendedores = new List<Vendedor>();

// Populando Algumas Listas
// Populando Lista de Pessoas
Pessoa kaue = new Pessoa(1, "Kaue");
listaPessoas.Add(kaue);
Pessoa bruna = new Pessoa(2, "Bruna");
listaPessoas.Add(bruna);
Pessoa douglas = new Pessoa(3, "Douglas");
listaPessoas.Add(douglas);
Pessoa douglinhas = new Pessoa(4, "Douglinhas");
listaPessoas.Add(douglinhas);

// Populando Lista de Autores
Autor novoAutor1 = new Autor(kaue, "kauezinho");
listaAutores.Add(novoAutor1);
Autor novoAutor2 = new Autor(bruna, "bruninha");
listaAutores.Add(novoAutor2);

// Populando Lista de Vendedores
Vendedor vendedor1 = new Vendedor(douglas, "12345678910");
listaVendedores.Add(vendedor1);
Vendedor vendedor2 = new Vendedor(douglinhas, "01987654321");
listaVendedores.Add(vendedor2);

// Declarando Variáveis que vão controlar a execução dos Whiles
var menuInicial = true;
var menuClasse = true;

// Declarando Variável global

void opcoesClasses(string nomeClasse)
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine($"1. Cadastrar {nomeClasse}");
    Console.WriteLine($"2. Exibir {nomeClasse}");
    Console.WriteLine($"3. Deletar {nomeClasse}");
    Console.WriteLine("4. Voltar ao Menu Inicial");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Digite a Opção Desejada:");
}

while (menuInicial)
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("1. Autores");
    Console.WriteLine("2. Livros");
    Console.WriteLine("3. Lojas");
    Console.WriteLine("4. Pessoas");
    Console.WriteLine("5. Vendedores");
    Console.WriteLine("6. Sair do programa");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Digite a Opção Desejada:");

    // Capturando a opção desejada
    var opcaoEscolhida = Console.ReadLine();

    switch (opcaoEscolhida)
    {
        case "1":
            // Chamando o opcoesClasses para exibição do menu da Classe
            while (menuClasse)
            {
                // Exibindo menu da Classe
                opcoesClasses("Autores");

                // Capturando a opção desejada
                var opcaoEscolhidaClasse = Console.ReadLine();

                switch (opcaoEscolhidaClasse)
                {
                    case "1":
                        // Pedindo Dados do Autor
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID do Novo Autor: ");
                        var idAutor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o NOME do Novo Autor: ");
                        var nomeAutor = Console.ReadLine();
                        Console.WriteLine("Digite o PSEUDÔNIMO do Novo Autor: ");
                        var pseudonimoAutor = Console.ReadLine();

                        // Cadastrando nova Pessoa e adicionando na Lista
                        Pessoa novaPessoa = new Pessoa();
                        novaPessoa.id = idAutor;
                        novaPessoa.nome = nomeAutor;
                        listaPessoas.Add(novaPessoa);

                        // Cadastrando novo Autor e adicionando na Lista
                        Autor novoAutor = new Autor(novaPessoa, pseudonimoAutor);
                        listaAutores.Add(novoAutor);

                        Console.WriteLine($"Autor Cadastrado com Sucesso!");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Autores: ");

                        // Exibindo Lista de Autores e Dados
                        foreach (var autor in listaAutores)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"ID: {autor.id}");
                            Console.WriteLine($"NOME: {autor.nome}");
                            Console.WriteLine($"PSEUDÔNIMO: {autor.pseudonimo}");
                        }
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Autores: ");

                        // Exibindo Lista de Autores e Dados
                        foreach (var autor in listaAutores)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"ID: {autor.id} | NOME: {autor.nome}");
                        }

                        // Capturando o ID do Autor a ser Deletado
                        Console.WriteLine("Digite o ID do Autor que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        foreach (var autor in listaAutores)
                        {
                            if (autor.id == idDelete)
                            {
                                // Removendo o Autor com ID digitado
                                listaAutores.Remove(autor);
                                Console.WriteLine($"Autor Deletado com Sucesso!");
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Digite qualquer tecla para continuar");
                                Console.ReadLine();
                                break;
                            }
                            break;
                        }
                        // Caso o ID não exista, voltar ao menu anterior
                        Console.WriteLine($"ID não encontrado!");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;
        case "2":
            
            break;
        case "3":

            break;
        case "4":
            
            break;
        case "5":
            break;
        default:
            menuInicial = false;
            break;
    }
}

Console.WriteLine("Obrigado por utilizar o nosso programa!");