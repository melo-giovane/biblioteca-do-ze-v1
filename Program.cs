using Biblioteca;

internal class Program
{
    static List<Leitor> leitores = new List<Leitor>();
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            short opcaoPrincipal = menu.MenuPrincipal();

            switch (opcaoPrincipal)
            {
                case 1: // Leitor
                    MenuLeitor(menu);
                    break;

                case 2: // Livro
                    MenuLivro(menu);
                    break;

                case 3: // Encerrar
                    Console.WriteLine("Encerrando o programa...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void MenuLeitor(Menu menu)
    {
        while (true)
        {
            short opcao = menu.MenuLeitor();

            switch (opcao)
            {
                case 1:
                    //Cadastrar leitor
                    Leitor novoLeitor = new Leitor().CadastroLeitor(leitores);
                    leitores.Add(novoLeitor);
                    Console.WriteLine("Leitor cadastrado com sucesso!");
                    break;

                case 2:
                    Leitor x = new Leitor();
                    Leitor.ListarLeitores(leitores);
                    break;

                case 3:
                    Console.WriteLine("Editar leitor");
                    break;

                case 4:
                    Console.WriteLine("Remover leitor");
                    break;

                case 5:
                    Console.WriteLine("Digite o cpf do doador");
                    string cpfDoador = Console.ReadLine();
                    Leitor? doador = leitores.Find(x => x.cpf == cpfDoador);
                    if(doador! != null)
                    {
                        doador.DoarLivro(leitores);
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nDigite 0 para voltar ou qualquer outra tecla para continuar...");
            if (Console.ReadLine() == "0")
                break;
        }
    }

    static void MenuLivro(Menu menu)
    {
        while (true)
        {
            short opcao = menu.MenuLivro();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Adicionar livro");
                    break;

                case 2:
                    Console.WriteLine("Listar livros");
                    break;

                case 3:
                    Console.WriteLine("Editar livro");
                    break;

                case 4:
                    Console.WriteLine("Remover livro");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nDigite 0 para voltar ou qualquer outra tecla para continuar...");
            if (Console.ReadLine() == "0")
                break;
        }
    }
}