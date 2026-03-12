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

    public Leitor cadastroLeitor()
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
        byte.TryParse(Console.ReadLine(), out byte idade);
        novoLeitor.Idade = idade;

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
        return novoLeitor;
    }
}