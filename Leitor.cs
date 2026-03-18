namespace Biblioteca;

public class Leitor
{
    public string cpf;
    public string nome;
    public byte idade;
    public string contato;
    public List<Livro> LivrosLeitor = new List<Livro>();
    public void AdiconarLivro(Livro livro)
    {
        this.LivrosLeitor.Add(livro);
    }
    public void RemoverLivro(Livro livro)
    {
        this.LivrosLeitor.Remove(livro);
    }
    public void DoarLivro(List<Leitor> leitores)
    {


        Console.WriteLine("Digite o cpf do recebedor");
        string cpfRecebedor = Console.ReadLine();

        Leitor? recebedor = leitores.Find(x => x.cpf == cpfRecebedor);



        Console.WriteLine("Digite o nome do livro: ");
        string livro = Console.ReadLine();

        Livro? livroDoado = this.LivrosLeitor.Find(x => x.Titulo == livro);

        if (recebedor! != null && livroDoado! != null)
        {
            this.RemoverLivro(livroDoado);
            recebedor.AdiconarLivro(livroDoado);
        }
    }

    public Leitor(string cpf, string nome, byte idade, string contato)
    {
        this.cpf = cpf;
        this.nome = nome;
        this.idade = idade;
        this.contato = contato;
    }
    public Leitor()
    {
        this.cpf = string.Empty;
        this.nome = string.Empty;
        this.idade = 0;
        this.contato = string.Empty;
    }



    public Leitor CadastroLeitor(List<Leitor> listaDeLeitores)
    {

        Console.WriteLine("\n---Cadastro de Leitor---");

        while (true) //Validação do CPF para garantir que o identificador tenha exatamente 11 dígitos
        {
            Console.Write("Digite o CPF do leitor (11 dígitos, sem pontuação): ");
            string cpfDigitado = Console.ReadLine();


            if (!string.IsNullOrEmpty(cpfDigitado) && cpfDigitado.Length == 11)
            {

                bool cpfInvalido = listaDeLeitores.Exists(l => l.cpf == cpfDigitado);
                if (cpfInvalido)
                {
                    Console.WriteLine("CPF já cadastrado! Por favor, insira um CPF diferente.");
                    continue;
                }
                else
                {
                    cpf = cpfDigitado;
                    break;
                }
            }
            Console.WriteLine("CPF Inválido! O identificador deve ter exatamente 11 números.");
        }

        while (true)
        {
            Console.Write("Digite o nome do leitor: ");
            string entrada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                nome = entrada;
                break;
            }
            Console.WriteLine("O nome não pode estar vazio!");
        }

        while (true)
        {
            Console.Write("Digite a idade do leitor: ");
            byte.TryParse(Console.ReadLine(), out byte idadeInserida);

            if (idadeInserida <= 0 || idadeInserida == null)
            {
                Console.WriteLine("Insira um valor válido.");
                continue;
            }
            idade = idadeInserida;
            break;
        }

        while (true)
        {
            Console.Write("Digite o contato do leitor (xx xxxxx-xxxx): ");
            contato = Console.ReadLine();
            if (!string.IsNullOrEmpty(contato) && contato.Length == 13)
            {
                break;
            }
            Console.WriteLine("Contato escrito de forma errada.");
        }
        return new Leitor(cpf, nome, idade, contato);
    }

    public static void ListarLeitores(List<Leitor> listaDeLeitores)
    {
        if (listaDeLeitores.Count == 0)
        {
            Console.WriteLine("\nNenhum leitor cadastrado.");
            return;
        }

        Console.WriteLine("\n-- Todos os leitores cadastrados --");
        foreach (var leitor in listaDeLeitores)
        {
            leitor.ExibirDetalhes();
        }
    }

    public void ExibirDetalhes() // Listagem de leitor específico
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"CPF: {this.cpf} || Idade: {this.idade}");
        Console.WriteLine($"Contato: {this.contato}");
        if (LivrosLeitor.Count > 0)
        {
            Console.WriteLine($"Livros: {string.Join(", ", LivrosLeitor.Select(l => l.Titulo))}");
        }
        else
        {
            Console.WriteLine("Livros: Nenhum livro.");
        }
    }

    public void editarLeitor()
    {
        Console.WriteLine("Digite o que deseja alterar:");
        Console.WriteLine("1 - Nome");
        Console.WriteLine("2 - Idade");
        Console.WriteLine("3 - Contato");
        byte opcaoEditar = byte.TryParse(Console.ReadLine(), out byte result) ? result : (byte)0;
        switch (opcaoEditar)
        {
            case 1:
                Console.WriteLine("Digite o novo nome:");
                string nomeNovo = Console.ReadLine();
                this.nome = nomeNovo;
                Console.WriteLine("Nome editado com sucesso!");
                break;

            case 2:
                Console.WriteLine("Digite a nova idade:");
                byte.TryParse(Console.ReadLine(), out byte idadeNova);
                this.idade = idadeNova;
                Console.WriteLine("Idade editada com sucesso!");
                break;

            case 3:
                Console.WriteLine("Digite o novo contato:");
                string contatoNovo = Console.ReadLine();
                this.contato = contato;
                Console.WriteLine("Contato editado com sucesso!");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}