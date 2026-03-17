using Biblioteca;

internal class Program
{
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
                    Console.WriteLine("Adicionar leitor");
                    break;

                case 2:
                    Console.WriteLine("Listar leitores");
                    break;

                case 3:
                    Console.WriteLine("Editar leitor");
                    break;

                case 4:
                    Console.WriteLine("Remover leitor");
                    break;

                case 5:
                    Console.WriteLine("Doar livro");
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