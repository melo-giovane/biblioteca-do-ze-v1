using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Leitor> leitores = new List<Leitor>();

        while (true)
        {
            Menu menu = new Menu();
            Console.WriteLine("\nDigite o numero da sua opção");
            menu.ListarOpcoes();
            short opcaoEscolhida;

            Console.Write("Escolha uma opção: ");

            if (!short.TryParse(Console.ReadLine(), out opcaoEscolhida))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            switch (opcaoEscolhida)
            {
                case 1: //Leitor
                    Console.WriteLine("\n---Você escolheu a opção de leitores---");
                    Console.WriteLine("Digite o numero da sua opção");
                    menu.ListarOpcoesLeitor();
                    Console.Write("Escolha uma opção: ");
                    
                    if (short.TryParse(Console.ReadLine(), out short opcaoOperacao))
                    {
                        if (opcaoOperacao == 1) //Adicionar novo leitor
                        {
                           Leitor leitorCadastrado = new Leitor().cadastroLeitor();
                           leitores.Add(leitorCadastrado);
                           Console.WriteLine($"\n{leitorCadastrado.Nome} cadastrado com sucesso!");
                        }

                        if (opcaoOperacao == 2)//Listar leitores
                        {
                        }

                        break;
                    }
                    return;

                case 2://Livros
                    Console.WriteLine("\n---Você escolheu a opção de livros---");
                    Console.WriteLine("Digite o numero da sua opção");
                    menu.ListarOpcoesLivro();
                    Console.Write("Escolha uma opção: ");
                    break;

                case 3:
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}