// Referenciando o ClassLibrary
using ClassLibrary.Models;

// Mensagens de Inicialização
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Projeto Console - CP1 - Enterprise Applicattion Development");
Console.WriteLine("RM 96466 - Kaue Caponero Figueiredo");
Console.WriteLine("RM 96848 - Bruna Menegatti Vienna");

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

// Declarando Variáveis que vão Controlar a Execução dos Whiles
bool menuInicial = true;

// Método para Exibir o Menu Inicial
void exibirMenuInicial()
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("MENU INICIAL");
    Console.WriteLine("1. Autores");
    Console.WriteLine("2. Livros");
    Console.WriteLine("3. Lojas");
    Console.WriteLine("4. Pessoas");
    Console.WriteLine("5. Vendedores");
    Console.WriteLine("6. Sair do programa");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Digite a Opção Desejada:");
}

// Método para Exibir o Menu da Classe
void exibirMenuClasses(string nomeClasse, string nomeClassePlural)
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine($"MENU DE {nomeClassePlural.ToUpper()}");
    Console.WriteLine($"1. Cadastrar {nomeClasse}");
    Console.WriteLine($"2. Exibir {nomeClassePlural}");
    Console.WriteLine($"3. Deletar {nomeClasse}");
    Console.WriteLine("4. Voltar ao Menu Inicial");
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine("Digite a Opção Desejada:");
}

// Início do Programa
while (menuInicial)
{
    // Declarando Variáveis que vão Controlar a Execução dos Whiles
    bool menuClasse = true;

    // Exibindo Menu Inicial Através do Método
    exibirMenuInicial();

    // Capturando a Opção Escolhida
    var opcaoEscolhida = int.Parse(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        // Menu de Autores
        case 1:

            // Setando Variável de Controle como True para Manter o Loop
            menuClasse = true;

            while (menuClasse)
            {
                // Exibindo Menu da Classe Através do Método
                exibirMenuClasses("Autor", "Autores");

                // Capturando a Opção Escolhida
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando Novo Autor
                    case 1:

                        // Pedindo Dados do Novo Autor
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo ID do Novo Autor
                        Console.WriteLine("Digite o ID do Novo Autor: ");
                        var idAutor = int.Parse(Console.ReadLine());

                        // Pedindo NOME do Novo Autor
                        Console.WriteLine("Digite o NOME do Novo Autor: ");
                        var nomeAutor = Console.ReadLine();

                        // Pedindo PSEUDÔNIMO do Novo Autor
                        Console.WriteLine("Digite o PSEUDÔNIMO do Novo Autor: ");
                        var pseudonimoAutor = Console.ReadLine();

                        // Cadastrando Nova Pessoa e Adicionando na Lista
                        // Testando Construtor Padrão da Classe Pessoa
                        Pessoa novaPessoa = new Pessoa();
                        novaPessoa.id = idAutor;
                        novaPessoa.nome = nomeAutor;
                        listaPessoas.Add(novaPessoa);

                        // Cadastrando Novo Autor e Adicionando na Lista
                        // Testando Construtor Personalizado da Classe Autor
                        Autor novoAutor = new Autor(novaPessoa, pseudonimoAutor);
                        listaAutores.Add(novoAutor);

                        // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                        Console.WriteLine($"Autor Cadastrado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Exibindo Autores
                    case 2:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Autores: ");

                        // Verificando Tamanho da Lista
                        if (listaAutores.Count == 0)
                        {
                            Console.WriteLine("A Lista de Autores está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Autores
                            foreach (var autor in listaAutores)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {autor.id}");
                                Console.WriteLine($"NOME: {autor.nome}");
                                Console.WriteLine($"PSEUDÔNIMO: {autor.pseudonimo}");
                            }
                        }

                        // Voltando ao Menu Anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Deletando Autor
                    case 3:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Autores: ");

                        // Verificando Tamanho da Lista
                        if (listaAutores.Count == 0)
                        {
                            Console.WriteLine("A Lista de Autores está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Autores
                            foreach (var autor in listaAutores)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {autor.id} | NOME: {autor.nome}");
                            }
                        }

                        // Capturando o ID do Autor a ser Deletado
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID do Autor que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação do Autor Escolhido
                        bool autorEncontrado = false;

                        // Percorrendo lista de Autores para Deletar
                        foreach (var autor in listaAutores)
                        {
                            if (autor.id == idDelete)
                            {
                                // Deletando o Autor com ID digitado
                                listaAutores.Remove(autor);
                                autorEncontrado = true;
                                Console.WriteLine($"Autor Deletado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar Ao Menu Anterior
                        if (!autorEncontrado)
                        {
                            Console.WriteLine($"ID do Autor Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao Menu Anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;

        // Menu de Livros
        case 2:

            // Setando Variável de Controle como True para Manter o Loop
            menuClasse = true;

            while (menuClasse)
            {
                // Exibindo Menu da Classe Através do Método
                exibirMenuClasses("Livro", "Livros");

                // Capturando a Opção Escolhida
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando Novo Livro
                    case 1:

                        // Pedindo Dados do Novo Livro
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo o ID do Novo Livro
                        Console.WriteLine("Digite o ID do Novo Livro: ");
                        var idLivro = int.Parse(Console.ReadLine());

                        // Pedindo o TÍTULO do Novo Livro
                        Console.WriteLine("Digite o TÍTULO do Novo Livro: ");
                        var tituloLivro = Console.ReadLine();

                        // Pedindo o AUTOR do Novo Livro
                        // Verificando Tamanho da Lista
                        if (listaAutores.Count == 0)
                        {
                            Console.WriteLine("A Lista de Autores está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Lista de Autores: ");

                            // Exibindo Lista de Autores
                            foreach (var autor in listaAutores)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {autor.id} | NOME: {autor.nome} | PSEUDÔNIMO: {autor.pseudonimo}");
                            }
                        }

                        // Pedindo o ID do Autor do Novo Livro
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID do AUTOR do Novo Livro: ");
                        var idAutor = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação do Autor Escolhido
                        bool autorEncontrado = false;

                        // Instanciando o Autor do Livro
                        Autor autorLivro = new Autor();

                        // Validando o ID do Autor
                        foreach (var autor in listaAutores)
                        {
                            if (autor.id == idAutor)
                            {
                                // Setando a Variável AutorLivro
                                autorLivro = autor;
                                autorEncontrado = true;
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar ao Menu Anterior
                        if (!autorEncontrado)
                        {
                            Console.WriteLine($"ID do Autor Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }

                        // Pedindo o PREÇO do Novo Livro
                        Console.WriteLine("Digite o PREÇO do Livro: ");
                        var precoLivro = double.Parse(Console.ReadLine());

                        // Cadastrando Novo Livro e Adicionando na Lista
                        // Testando Construtor Completo da Classe Livro
                        Livro novoLivro = new Livro(idLivro, tituloLivro, autorLivro, precoLivro);
                        listaLivros.Add(novoLivro);

                        // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                        Console.WriteLine($"Livro Cadastrado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Exibindo Livros
                    case 2:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Livros: (Exibindo Apenas os Livros com Preço > 10 para atender um dos requisitos da CP1");

                        // Verificando Tamanho da Lista
                        if (listaLivros.Count == 0)
                        {
                            Console.WriteLine("A Lista de Livros está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Livros
                            foreach (var livro in listaLivros)
                            {
                                // Tomada de Decisão de Acordo com uma propriedade de uma classe, apenas para requisito da CP1
                                if (livro.preco > 10)
                                {
                                    Console.WriteLine("---");
                                    Console.WriteLine($"ID: {livro.id}");
                                    Console.WriteLine($"TÍTULO: {livro.titulo}");
                                    // Testando Método Sobrescrito da Classe Autor
                                    Console.WriteLine($"AUTOR: {livro.autor.getNome()}");
                                    Console.WriteLine($"PREÇO: {livro.preco}");
                                }
                            }
                        }
                        
                        // Voltando ao menu anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Deletando Livros
                    case 3:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Livros: ");

                        // Verificando Tamanho da Lista
                        if (listaLivros.Count == 0)
                        {
                            Console.WriteLine("A Lista de Livros está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Livros
                            foreach (var livro in listaLivros)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {livro.id} | TÍTULO: {livro.titulo}");
                            }
                        }

                        // Capturando o ID do Livro a ser Deletado
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID do Livro que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação do Livro Escolhido
                        bool livroEncontrado = false;

                        // Percorrendo Lista de Livros para Deletar
                        foreach (var livro in listaLivros)
                        {
                            if (livro.id == idDelete)
                            {
                                // Deletando o Livro com ID digitado
                                listaLivros.Remove(livro);
                                livroEncontrado = true;

                                // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                                Console.WriteLine($"Livro Deletado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar ao Menu Anterior
                        if (!livroEncontrado)
                        {
                            Console.WriteLine($"ID do Livro Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao Menu Anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;

        // Menu de Lojas
        case 3:

            // Setando Variável de Controle como True para Manter o Loop
            menuClasse = true;

            while (menuClasse)
            {
                // Exibindo Menu da Classe Através do Método
                exibirMenuClasses("Loja", "Lojas");

                // Capturando a Opção Escolhida
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando Nova Loja
                    case 1:

                        // Pedindo Dados da Nova Loja
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo ID da Nova Loja
                        Console.WriteLine("Digite o ID da Nova Loja: ");
                        var idLoja = int.Parse(Console.ReadLine());

                        // Pedindo ENDERECO da Nova Loja
                        Console.WriteLine("Digite o ENDEREÇO da Nova Loja: ");
                        var enderecoLoja = Console.ReadLine();

                        // Pedindo TELEFONE da Nova Loja
                        Console.WriteLine("Digite o TELEFONE da Nova Loja: ");
                        var telefoneLoja = Console.ReadLine();

                        // Testando Construto que Chama Outro Construtor
                        Loja novaLoja = new Loja(1);

                        // Testando Método e Validando Construtor que Chama Outro Construtor (Exibindo na Tela)
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Validando Construtor que Chama Outro Construtor: ");
                        Console.WriteLine($"Criada com o ID 1. ID da Loja Criada: {novaLoja.id}");
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Cadastrando Nova Loja 
                        novaLoja.id = idLoja;
                        novaLoja.endereco = enderecoLoja;

                        // Testando Método Público que chama Método Protected da Classe Loja
                        novaLoja.updateTelefoneLoja(novaLoja, telefoneLoja);

                        // Adicionando na Lista
                        listaLojas.Add(novaLoja);

                        // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                        Console.WriteLine($"Loja Cadastrada com Sucesso! Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Exibindo Lojas
                    case 2:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Lojas: ");

                        // Verificando Tamanho da Lista
                        if (listaLojas.Count == 0)
                        {
                            Console.WriteLine("A Lista de Lojas está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Lojas
                            // Chamando Método que Chama o Método Internal para Teste
                            Loja lojaTeste = new Loja();
                            lojaTeste.showDetailsLoja(listaLojas);
                        }

                        // Voltando ao Menu Anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Deletando Lojas
                    case 3:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Lojas: ");

                        // Verificando Tamanho da Lista
                        if (listaLojas.Count == 0)
                        {
                            Console.WriteLine("A Lista de Lojas está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Lojas
                            foreach (var loja in listaLojas)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {loja.id} | TELEFONE: {loja.telefone}");
                            }
                        }

                        // Capturando o ID da Loja a ser Deletada
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID da Loja que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação da Loja Escolhido
                        bool lojaEncontrada = false;

                        // Percorrendo Lista de Lojas para Deletar
                        foreach (var loja in listaLojas)
                        {
                            if (loja.id == idDelete)
                            {
                                // Removendo a Loja com ID digitado
                                listaLojas.Remove(loja);
                                lojaEncontrada = true;
                                Console.WriteLine($"Loja Deletada com Sucesso! Digite Qualquer Tecla para Continuar: ");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar ao Menu Anterior
                        if (!lojaEncontrada)
                        {
                            Console.WriteLine($"ID da Loja Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao Menu Anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;

        // Menu de Pessoas
        case 4:

            // Setando Variável de Controle como True para Manter o Loop
            menuClasse = true;

            while (menuClasse)
            {
                // Exibindo Menu da Classe Através do Método
                exibirMenuClasses("Pessoa", "Pessoas");

                // Capturando a Opção Escolhida
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando Nova Pessoa
                    case 1:

                        // Pedindo Dados da Nova Pessoa
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo ID da Nova Pessoa
                        Console.WriteLine("Digite o ID da Nova Pessoa: ");
                        var idPessoa = int.Parse(Console.ReadLine());

                        // Pedindo NOME da Nova Pessoa
                        Console.WriteLine("Digite o NOME da Nova Pessoa: ");
                        var nomePessoa = Console.ReadLine();

                        // Cadastrando Nova Pessoa e Adicionando na Lista
                        // Testando Construtor Especializado da Classe Pessoa
                        Pessoa novaPessoa = new Pessoa(nomePessoa);
                        novaPessoa.id = idPessoa;
                        listaPessoas.Add(novaPessoa);

                        // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                        Console.WriteLine($"Pessoa Cadastrada com Sucesso! Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Exibindo Pessoas
                    case 2:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Pessoas: ");

                        // Verificando Tamanho da Lista
                        if (listaPessoas.Count == 0)
                        {
                            Console.WriteLine("A Lista de Pessoas está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Pessoas
                            foreach (var pessoa in listaPessoas)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {pessoa.id}");
                                Console.WriteLine($"NOME: {pessoa.getNome()}");
                            }
                        }

                        // Voltando ao Menu Anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Deletando Pessoa
                    case 3:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Pessoas: ");

                        // Verificando Tamanho da Lista
                        if (listaPessoas.Count == 0)
                        {
                            Console.WriteLine("A Lista de Pessoas está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Pessoas
                            foreach (var pessoa in listaPessoas)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {pessoa.id} | NOME: {pessoa.nome}");
                            }
                        }

                        // Capturando o ID da Pessoa a ser Deletado
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID da Pessoa que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação do Autor Escolhido
                        bool pessoaEncontrada = false;

                        // Percorrendo lista de Pessoas para Deletar
                        foreach (var pessoa in listaPessoas)
                        {
                            if (pessoa.id == idDelete)
                            {
                                // Deletando a Pessoa com ID digitado
                                listaPessoas.Remove(pessoa);
                                pessoaEncontrada = true;
                                Console.WriteLine($"Pessoa Deletada com Sucesso! Digite Qualquer Tecla para Continuar: ");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar Ao Menu Anterior
                        if (!pessoaEncontrada)
                        {
                            Console.WriteLine($"ID da Pessoa Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao Menu Anterior
                    default:
                        menuClasse = false;
                        break;
                }
            }
            break;

        // Menu de Vendedores
        case 5:

            // Setando Variável de Controle como True para Manter o Loop
            menuClasse = true;

            while (menuClasse)
            {
                // Exibindo Menu da Classe Através do Método
                exibirMenuClasses("Vendedor", "Vendedores");

                // Capturando a Opção Escolhida
                var opcaoEscolhidaClasse = int.Parse(Console.ReadLine());

                switch (opcaoEscolhidaClasse)
                {
                    // Cadastrando Novo Vendedor
                    case 1:

                        // Pedindo Dados do Novo Vendedor
                        Console.WriteLine("-----------------------------------------------------------------");

                        // Pedindo ID do Novo Vendedor
                        Console.WriteLine("Digite o ID do Novo Vendedor: ");
                        var idVendedor = int.Parse(Console.ReadLine());

                        // Pedindo NOME do Novo Vendedor
                        Console.WriteLine("Digite o NOME do Novo Vendedor: ");
                        var nomeVendedor = Console.ReadLine();

                        // Pedindo CPF do Novo Autor
                        Console.WriteLine("Digite o CPF do Novo Vendedor: ");
                        var cpfVendedor = Console.ReadLine();

                        // Cadastrando Nova Pessoa e Adicionando na Lista
                        // Testando Construtor Padrão da Classe Pessoa
                        Pessoa novaPessoa = new Pessoa();
                        novaPessoa.id = idVendedor;
                        novaPessoa.nome = nomeVendedor;
                        listaPessoas.Add(novaPessoa);

                        // Cadastrando Novo Vendedor e Adicionando na Lista
                        // Testando Construtor Personalizado da Classe Autor
                        Vendedor novoVendedor = new Vendedor(novaPessoa, cpfVendedor);
                        listaVendedores.Add(novoVendedor);

                        // Exibindo Mensagem de Sucesso e Voltando ao Menu Anterior
                        Console.WriteLine($"Vendedor Cadastrado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Exibindo Vendedores
                    case 2:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Vendedores: ");

                        // Verificando Tamanho da Lista
                        if (listaVendedores.Count == 0)
                        {
                            Console.WriteLine("A Lista de Vendedores está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Vendedores
                            foreach (var vendedor in listaVendedores)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {vendedor.id}");
                                Console.WriteLine($"NOME: {vendedor.nome}");
                                // Testando o Método Público da Classe Vendedor
                                vendedor.printCpf(vendedor);
                            }
                        }

                        // Voltando ao Menu Anterior
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite Qualquer Tecla para Continuar: ");
                        Console.ReadLine();
                        break;

                    // Deletando Vendedor
                    case 3:

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Lista de Vendedores: ");

                        // Verificando Tamanho da Lista
                        if (listaVendedores.Count == 0)
                        {
                            Console.WriteLine("A Lista de Vendedores está vazia. Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            // Exibindo Lista de Vendedores
                            foreach (var vendedor in listaVendedores)
                            {
                                Console.WriteLine("---");
                                Console.WriteLine($"ID: {vendedor.id}");
                                // Testando Método Sobrescrito da Classe Vendedor
                                vendedor.getNome();
                            }
                        }

                        // Capturando o ID do Vendedor a ser Deletado
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Digite o ID do Vendedor que Deseja Deletar: ");
                        var idDelete = int.Parse(Console.ReadLine());

                        // Declarando Variável Booleana para Validação do Autor Escolhido
                        bool vendedorEncontrado = false;

                        // Percorrendo lista de Vendedores para Deletar
                        foreach (var vendedor in listaVendedores)
                        {
                            if (vendedor.id == idDelete)
                            {
                                // Deletando o Vendedor com ID digitado
                                listaVendedores.Remove(vendedor);
                                vendedorEncontrado = true;
                                Console.WriteLine($"Vendedor Deletado com Sucesso! Digite Qualquer Tecla para Continuar: ");
                                Console.ReadLine();
                                break;
                            }
                        }
                        // Caso o ID Não Exista, Voltar Ao Menu Anterior
                        if (!vendedorEncontrado)
                        {
                            Console.WriteLine($"ID do Vendedor Não Encontrado! Digite Qualquer Tecla para Continuar: ");
                            Console.ReadLine();
                        }
                        break;

                    // Voltando ao Menu Anterior
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