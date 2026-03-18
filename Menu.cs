public class Menu
{
    List<string> opcoes = ["Leitor", "Livros", "Encerrar programa"];
    List<string> opcoesLeitor = ["Adicionar", "Listar todos", "Exibir Leitor", "Editar leitor", "Excluir leitor", "Incluir livro", "Editar livro", "Doar", "Remover livro", "Procurar livro"];
    List<string> opcoesLivro = ["Adicionar", "Listar", "Editar", "Remover"];

    private short ExibirMenu(List<string> opcoes)
    {
        short opcaoEscolhida;

        while (true)
        {
            Console.WriteLine("\nDigite o numero da sua opção");

            for (int i = 0; i < opcoes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {opcoes[i]}");
            }

            Console.Write("Escolha uma opção: ");

            if (!short.TryParse(Console.ReadLine(), out opcaoEscolhida))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            if (opcaoEscolhida < 1 || opcaoEscolhida > opcoes.Count)
            {
                Console.WriteLine("Opção fora do intervalo.");
                continue;
            }

            return opcaoEscolhida;
        }
    }

    public short MenuPrincipal()
    {
        return ExibirMenu(opcoes);
    }

    public short MenuLeitor()
    {
        return ExibirMenu(opcoesLeitor);
    }

    public short MenuLivro()
    {
        return ExibirMenu(opcoesLivro);
    }
}