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
            menu.ListarOpções();
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
                    menu.ListarOpçõesLeitor();
                    Console.Write("Escolha uma opção: ");
                    
                    if (short.TryParse(Console.ReadLine(), out short opcaoOperacao))
                    {
                        if (opcaoOperacao == 1) //Adicionar novo leitor
                        {
                            Leitor novoLeitor = new Leitor();

                            Console.WriteLine("\n---Cadastro de Leitor---");

                            while (true) //Validação do CPF para garantir que o identificador tenha exatamente 11 dígitos
                            {
                                Console.Write("Digite o CPF do leitor (11 dígitos, sem pontuação): ");
                                novoLeitor.Cpf = Console.ReadLine();
                                if (!string.IsNullOrEmpty(novoLeitor.Cpf) && novoLeitor.Cpf.Length == 11)
                                {
                                    break;
                                }
                                Console.WriteLine("CPF Inválido! O identificador deve ter exatamente 11 números.");
                            }
                            
                            Console.Write("Digite o nome do leitor: ");
                            novoLeitor.Nome = Console.ReadLine();

                            Console.Write("Digite a idade do leitor: ");
                            novoLeitor.Idade = byte.Parse(Console.ReadLine());

                            while (true) //Validação do contato para garantir que o número de telefone tenha exatamente 13 caracteres (incluindo espaço e hífen)
                            {
                                Console.Write("Digite o contato do leitor (xx xxxxx-xxxx): ");
                                novoLeitor.Contato = Console.ReadLine();
                                if (!string.IsNullOrEmpty(novoLeitor.Contato) && novoLeitor.Contato.Length == 13)
                                {
                                    break;
                                }
                                Console.WriteLine("Contato escrito de forma errada.");
                            }

                            leitores.Add(novoLeitor);
                            Console.WriteLine($"\n{novoLeitor.Nome} cadastrado com sucesso!");

                        }

                        break;
                    }
                    return;

                case 2://Livros
                    Console.WriteLine("\n---Você escolheu a opção de livros---");
                    Console.WriteLine("Digite o numero da sua opção");
                    menu.ListarOpçõesLivro();
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