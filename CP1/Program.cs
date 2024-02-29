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

// Declarando Variável global

void opcoesClasses(string nomeClasse, string nomeClassePlural)
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine($"1. Cadastrar {nomeClasse}");
    Console.WriteLine($"2. Exibir {nomeClassePlural}");
    Console.WriteLine($"3. Deletar {nomeClasse}");
    Console.WriteLine("4. Voltar ao Menu Inicial");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Digite a Opção Desejada:");
}

while (menuInicial)
{
    // Declarando Variáveis que vão controlar a execução dos Whiles
    var menuClasse = true;

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
    var opcaoEscolhida = int.Parse(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        // Menu de Autores
        case 1:

            // Setando menuClasse como true
            menuClasse = true;

            // Chamando o opcoesClasses para exibição do menu da Classe
            while (menuClasse)
            {
                // Exibindo menu da Classe
                opcoesClasses("Autor", "Autores");

                // Capturando a opção desejada
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando novo Autor
                    case 1:
                        // Pedindo Dados do Autor
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo ID do novo Autor
                        Console.WriteLine("Digite o ID do Novo Autor: ");
                        var idAutor = int.Parse(Console.ReadLine());

                        // Pedindo Nome do novo Autor
                        Console.WriteLine("Digite o NOME do Novo Autor: ");
                        var nomeAutor = Console.ReadLine();

                        // Pedindo Pseudonimo do novo Autor
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

                        // Exibindo mensagem de sucesso e voltando ao menu anterior
                        Console.WriteLine($"Autor Cadastrado com Sucesso!");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;

                    // Exibindo Autores
                    case 2:
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

                        // Voltando ao menu anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;

                    // Deletando Autores
                    case 3:
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

                        // Declarando booleano para validação
                        bool autorEncontrado = false;

                        // Percorrendo lista de autores para deletar
                        foreach (var autor in listaAutores)
                        {
                            if (autor.id == idDelete)
                            {
                                // Removendo o Autor com ID digitado
                                listaAutores.Remove(autor);
                                autorEncontrado = true;
                                Console.WriteLine($"Autor Deletado com Sucesso!");
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Digite qualquer tecla para continuar");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID não exista, voltar ao menu anterior
                        if (!autorEncontrado)
                        {
                            Console.WriteLine($"ID não encontrado!");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Digite qualquer tecla para continuar");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao menu anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;

        // Menu de Livros
        case 2:

            // Setando menuClasse como true
            menuClasse = true;

            // Chamando o opcoesClasses para exibição do menu da Classe
            while (menuClasse)
            {
                // Exibindo menu da Classe
                opcoesClasses("Livro", "Livros");

                // Capturando a opção desejada
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando novo Livro
                    case 1:
                        // Pedindo Dados do Livro
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo o ID do novo Livro
                        Console.WriteLine("Digite o ID do Novo Livro: ");
                        var idLivro = int.Parse(Console.ReadLine());

                        // Pedindo o TÍTULO do novo Livro
                        Console.WriteLine("Digite o TÍTULO do Novo Livro: ");
                        var tituloLivro = Console.ReadLine();

                        // Exibindo a lista de Autores para Selecionar o ID
                        foreach (var autor in listaAutores)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"ID: {autor.id} | NOME: {autor.nome} | PSEUDÔNIMO: {autor.pseudonimo}");
                        }

                        // Pedidno o ID do Autor do Livro
                        Console.WriteLine("Digite o ID do Autor do Livro: ");
                        var idAutor = int.Parse(Console.ReadLine());

                        // Declarando booleano para validação
                        bool autorEncontrado = false;

                        // Instanciando o autorLivro
                        Autor autorLivro = null;

                        // Validando o ID do Autor
                        foreach (var autor in listaAutores)
                        {
                            if (autor.id == idAutor)
                            {
                                // Setando a variável autorLivro
                                autorLivro = autor;
                                autorEncontrado = true;
                                break;
                            }
                        }
                        // Caso o ID não exista, voltar ao menu anterior
                        if (!autorEncontrado)
                        {
                            Console.WriteLine($"ID não encontrado!");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Digite qualquer tecla para continuar");
                            Console.ReadLine();
                            break;
                        }

                        // Pedindo o preço do novo livro
                        Console.WriteLine("Digite o PREÇO do Livro: ");
                        var precoLivro = double.Parse(Console.ReadLine());

                        // Cadastrando novo Livro e adicionando na Lista
                        Livro novoLivro = new Livro(idLivro, tituloLivro, autorLivro, precoLivro);
                        listaLivros.Add(novoLivro);

                        // Exibindo mensagem de sucesso e voltando ao menu anterior
                        Console.WriteLine($"Livro Cadastrado com Sucesso!");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;

                    // Exibindo Livros
                    case 2:
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Livros: ");

                        // Exibindo Lista de Livros e Dados
                        foreach (var livro in listaLivros)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"ID: {livro.id}");
                            Console.WriteLine($"TÍTULO: {livro.titulo}");
                            Console.WriteLine($"AUTOR: {livro.autor.nome}");
                            Console.WriteLine($"PREÇO: {livro.preco}");
                        }

                        // Voltando ao menu anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                        break;

                    // Deletando Livros
                    case 3:
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Livros: ");

                        // Exibindo Lista de Livros e Dados
                        foreach (var livro in listaLivros)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"ID: {livro.id} | TÍTULO: {livro.titulo}");
                        }

                        // Capturando o ID do Livro a ser Deletado
                        Console.WriteLine("Digite o ID do Livro que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        bool livroEncontrado = false;

                        foreach (var livro in listaLivros)
                        {
                            if (livro.id == idDelete)
                            {
                                // Removendo o Livro com ID digitado
                                listaLivros.Remove(livro);
                                livroEncontrado = true;

                                // Exibindo Mensagem de Sucesso e voltando ao menu anterior
                                Console.WriteLine($"Livro Deletado com Sucesso!");
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Digite qualquer tecla para continuar");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID não exista, voltar ao menu anterior
                        if (!livroEncontrado)
                        {
                            Console.WriteLine($"ID não encontrado!");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Digite qualquer tecla para continuar");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao menu Anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;


        // Encerrando o Programa
        default:
            menuInicial = false;
            break;
    }
}

Console.WriteLine("Programa Encerrado!");