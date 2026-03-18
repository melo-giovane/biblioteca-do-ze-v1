//GUSTAVO DECKER COUTO
//GIOVANE MELO
using Biblioteca;

internal class Program
{
    static List<Leitor> leitores = new List<Leitor>();
    static List<Livro> livros = new List<Livro>();
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (true)
        {
            short opcao = menu.MenuLeitor();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nTem certeza que deseja encerrar a operação?...");
                    break;

                case 1:
                    Leitor novoLeitor = new Leitor().CadastroLeitor(leitores);
                    leitores.Add(novoLeitor);
                    Console.WriteLine("\nLeitor cadastrado com sucesso!");
                    break;

                case 2:
                    Leitor x = new Leitor();
                    Leitor.ListarLeitores(leitores);
                    break;

                case 3:
                    Console.Write("\nDigite o cpf do leitor que deseja exibir: ");
                    string cpfLeitor = Console.ReadLine();
                    Leitor? leitor = leitores.Find(x => x.cpf == cpfLeitor);
                    if (leitor! != null)
                    {
                        leitor.ExibirDetalhes();
                    }
                    break;

                case 4:
                    Console.Write("\nDigite o cpf do leitor que deseja editar: ");
                    string leitorEditar = Console.ReadLine();
                    Leitor? editar = leitores.Find(x => x.cpf == leitorEditar);
                    if (editar! != null)
                    {
                        editar.editarLeitor();
                    }
                    break;

                case 5:
                    Console.Write("\nDigite o cpf do leitor que deseja excluir: ");
                    string cpfExcluir = Console.ReadLine();
                    Leitor? excluir = leitores.Find(x => x.cpf == cpfExcluir);
                    if (excluir! != null)
                    {
                        leitores.Remove(excluir);
                        Console.WriteLine("Leitor excluído com sucesso!");
                    }
                    break;

                case 6:
                    Console.Write("\nDigite o cpf do leitor: ");
                    string dono = Console.ReadLine();
                    Leitor? donoLeitor = leitores.Find(x => x.cpf == dono);
                    if (donoLeitor! != null)
                    {
                        Console.WriteLine("Incluir livro");
                        Livro novoLivro = new Livro().CadastroLivro();
                        donoLeitor.LivrosLeitor.Add(novoLivro);
                        Console.WriteLine("Livro cadastrado com sucesso!");
                    }
                    break;

                case 7:
                    Console.Write("\nDigite o cpf do leitor que possui o livro: ");
                    string cpfPropietario = Console.ReadLine();
                    Leitor? proprietario = leitores.Find(x => x.cpf == cpfPropietario);
                    if (proprietario! != null)
                    {
                        Console.WriteLine("\nDigite o título do livro que deseja editar: ");
                        string tituloLivro = Console.ReadLine();
                        Livro? livroEditar = proprietario.LivrosLeitor.Find(x => x.Titulo == tituloLivro);
                        if (livroEditar! != null)
                        {
                            livroEditar.editarLivro();
                            Console.WriteLine("Livro editado com sucesso!");
                        }
                    }
                    break;

                case 8:
                    Console.Write("\nDigite o cpf do doador: ");
                    string cpfDoador = Console.ReadLine();
                    Leitor? doador = leitores.Find(x => x.cpf == cpfDoador);
                    if (doador! != null)
                    {
                        doador.DoarLivro(leitores);
                    }
                    break;

                case 9:
                    Console.Write("\nDigite o cpf do leitor que possui o livro: ");
                    string cpf3 = Console.ReadLine();
                    Leitor? proprietarioRemover = leitores.Find(x => x.cpf == cpf3);
                    if (proprietarioRemover! != null)
                    {
                        Console.Write("\nDigite o título do livro que deseja remover: ");
                        string tituloLivro = Console.ReadLine();
                        Livro? livroRemover = proprietarioRemover.LivrosLeitor.Find(x => x.Titulo == tituloLivro);
                        if (livroRemover! != null)
                        {
                            proprietarioRemover.LivrosLeitor.Remove(livroRemover);
                            Console.WriteLine("Livro removido com sucesso!");
                        }
                    }
                    break;

                case 10:
                    Console.Write("\nDigite o título do livro que deseja procurar: ");
                    string tituloProcurar = Console.ReadLine();
                    Console.WriteLine($"Título: {tituloProcurar} - Leitores:");
                    foreach (Leitor l in leitores)
                    {
                        foreach (Livro livro in l.LivrosLeitor)
                        {
                            if (livro.Titulo == tituloProcurar)
                            {
                               Console.WriteLine($"- {l.nome} || CPF: {l.cpf} || Idade: {l.idade} || Contato: {l.contato}");
                            }
                            else
                            {
                                Console.WriteLine("Livro não encontrado.");
                            }
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nDigite 0 para encerrar ou qualquer outra tecla para continuar...");
            if (Console.ReadLine() == "0")
            {
                Console.WriteLine("Encerrando programa...");
                break;
            }
                
        }

    }
}