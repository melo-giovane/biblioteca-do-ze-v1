namespace Biblioteca;
public class Livro
{
public string Titulo;
public string SubTitulo;
public string Escritor;
public string Editora;
public string Genero;
public int AnoPublicacao;
public string TipoDaCapa;
public int NumeroDePaginas;
    public Livro()
    {
        Titulo = "";
        SubTitulo = "";
        Escritor = "";
        Editora = "";
        Genero = "";
        AnoPublicacao = 0;
        TipoDaCapa = "";
        NumeroDePaginas = 0;
    }
    public Livro(string titulo, string subTitulo, string escritor, string editora, string genero, int anoPublicacao, string tipoDaCapa, int numeroDePaginas)
    {
        Titulo = titulo;
        SubTitulo = subTitulo;
        Escritor = escritor;
        Editora = editora;
        Genero = genero;
        AnoPublicacao = anoPublicacao;
        TipoDaCapa = tipoDaCapa;
        NumeroDePaginas = numeroDePaginas;
    }

    public Livro CadastroLivro()
{
    Console.WriteLine("\n--- Cadastro de Livro ---");

    Console.Write("Título: ");
    string titulo = Console.ReadLine() ?? "";

    Console.Write("Subtítulo: ");
    string subTitulo = Console.ReadLine() ?? "";

    Console.Write("Escritor: ");
    string escritor = Console.ReadLine() ?? "";

    Console.Write("Editora: ");
    string editora = Console.ReadLine() ?? "";

    Console.Write("Gênero: ");
    string genero = Console.ReadLine() ?? "";

    Console.Write("Ano de Publicação: ");
    int.TryParse(Console.ReadLine(), out int ano);

    Console.Write("Tipo da Capa: ");
    string capa = Console.ReadLine() ?? "";

    Console.Write("Número de Páginas: ");
    int.TryParse(Console.ReadLine(), out int paginas);

    return new Livro(titulo, subTitulo, escritor, editora, genero, ano, capa, paginas);
}

public void editarLivro()
    {
        Console.WriteLine("Digite o que deseja alterar:");
        Console.WriteLine("1 - Título");
        Console.WriteLine("2 - Subtítulo");
        Console.WriteLine("3 - Escritor");
        Console.WriteLine("4 - Editora");
        Console.WriteLine("5 - Gênero");
        Console.WriteLine("6 - Ano de Publicação");
        Console.WriteLine("7 - Tipo da Capa");
        Console.WriteLine("8 - Número de Páginas");

        if (!int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.WriteLine("Digite um número válido.");
            return;
        }

        switch (opcao)
        {
            case 1:
                Console.Write("Novo Título: ");
                this.Titulo = Console.ReadLine() ?? this.Titulo;
                break;
            case 2:
                Console.Write("Novo Subtítulo: ");
                this.SubTitulo = Console.ReadLine() ?? this.SubTitulo;
                break;
            case 3:
                Console.Write("Novo Escritor: ");
                this.Escritor = Console.ReadLine() ?? this.Escritor;
                break;
            case 4:
                Console.Write("Nova Editora: ");
                this.Editora = Console.ReadLine() ?? this.Editora;
                break;
            case 5:
                Console.Write("Novo Gênero: ");
                this.Genero = Console.ReadLine() ?? this.Genero;
                break;
            case 6:
                Console.Write("Novo Ano de Publicação: ");
                int.TryParse(Console.ReadLine(), out int ano);
                if (ano > 0)
                    this.AnoPublicacao = ano;
                break;
            case 7:
                Console.Write("Novo Tipo da Capa: ");
                this.TipoDaCapa = Console.ReadLine() ?? this.TipoDaCapa;
                break;
            case 8:
                Console.Write("Novo Número de Páginas: ");
                int.TryParse(Console.ReadLine(), out int paginas);
                if (paginas > 0)
                    this.NumeroDePaginas = paginas;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}