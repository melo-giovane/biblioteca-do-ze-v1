namespace Biblioteca;

public class Leitor
{
    public string Cpf;
    public string Nome;
    public byte Idade;
    public string Contato;
    public List<Livro> LivrosLeitor = new List<Livro>();
    public void AdiconarLivro(Livro livro)
    {
        this.LivrosLeitor.Add(livro);
    }
    public void RemoverLivro(Livro livro)
    {
        this.LivrosLeitor.Remove(livro);
    }
    public void DoarLivro(Livro livroDoado, Leitor leitorDestino)
    {
        this.RemoverLivro(livroDoado);
        leitorDestino.AdiconarLivro(livroDoado);
    }

    public Leitor cadastroLeitor(List<Leitor> listaDeLeitores)
    {
        Leitor novoLeitor = new Leitor();
        Console.WriteLine("\n---Cadastro de Leitor---");

        while (true) //Validação do CPF para garantir que o identificador tenha exatamente 11 dígitos
        {
            Console.Write("Digite o CPF do leitor (11 dígitos, sem pontuação): ");
            string cpfDigitado = Console.ReadLine();


            if (!string.IsNullOrEmpty(cpfDigitado) && cpfDigitado.Length == 11)
            {

                bool cpfInvalido = listaDeLeitores.Exists(l => l.Cpf == cpfDigitado);
                if (cpfInvalido)
                {
                    Console.WriteLine("CPF já cadastrado! Por favor, insira um CPF diferente.");
                    continue;
                }
                else
                {
                    novoLeitor.Cpf = cpfDigitado;
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
                novoLeitor.Nome = entrada;
                break;
            }
            Console.WriteLine("O nome não pode estar vazio!");
        }

        while (true)
        {
            Console.Write("Digite a idade do leitor: ");
            byte.TryParse(Console.ReadLine(), out byte idade);

            if (idade <= 0 || idade == null)
            {
                Console.WriteLine("Insira um valor válido.");
                continue;
            }
            novoLeitor.Idade = idade;
            break;
        }

        while (true)
        {
            Console.Write("Digite o contato do leitor (xx xxxxx-xxxx): ");
            novoLeitor.Contato = Console.ReadLine();
            if (!string.IsNullOrEmpty(novoLeitor.Contato) && novoLeitor.Contato.Length == 13)
            {
                break;
            }
            Console.WriteLine("Contato escrito de forma errada.");
        }
        return novoLeitor;
    }

    public void listarLeitores(List<Leitor> listaDeLeitores)
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
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"CPF: {this.Cpf} || Idade: {this.Idade}");
        Console.WriteLine($"Contato: {this.Contato}");
        if (LivrosLeitor.Count > 0)
        {
            Console.WriteLine($"Livros: {string.Join(", ", LivrosLeitor.Select(l => l.Titulo))}");
        }
        else
        {
            Console.WriteLine("Livros: Nenhum livro.");
        }
    }
}