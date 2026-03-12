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

                        if (opcaoOperacao == 2)//Listar leitores
                        {
                            Console.WriteLine("\n---Lista de Leitores---");
                            Console.WriteLine("1 - Listar todos os leitores e seus livros");
                            Console.WriteLine("2 - Listar leitor específico e seus livros");
                            Console.Write("Escolha uma opção: ");
                            
                            if (short.TryParse(Console.ReadLine(), out short opcaoListar))
                            {
                                if (opcaoListar == 1) //Listar Todos
                                {
                                    if(leitores.Count == 0)
                                    {
                                        Console.WriteLine("Nenhum leitor cadastrado.");
                                    }
                                    foreach (var leitor in leitores)
                                    {
                                        Console.WriteLine($"\nLeitor: {leitor.Nome} - CPF: {leitor.Cpf} - Idade: {leitor.Idade} - Contato: {leitor.Contato}");
                                    }
                                }

                                if (opcaoListar == 2) // Listar específico
                                {
                                    Console.Write("Digite o CPF do leitor que deseja consultar: ");
                                    string cpfConsulta = Console.ReadLine();
                                    Leitor leitorEncontrado = leitores.Find(l => l.Cpf == cpfConsulta);

                                    if (leitorEncontrado != null)
                                    {
                                        Console.WriteLine($"\nLeitor: {leitorEncontrado.Nome} - CPF: {leitorEncontrado.Cpf} - Idade: {leitorEncontrado.Idade} - Contato: {leitorEncontrado.Contato}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Leitor não encontrado.");
                                    }
                                }
                            }
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