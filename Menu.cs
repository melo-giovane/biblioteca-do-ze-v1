public class Menu
{
    List<string> opcoesLeitor = ["Encerrar operação", "Cadastrar leitor", "Listar todos", "Exibir Leitor", "Editar leitor", "Excluir leitor", "Incluir livro", "Editar livro", "Doar", "Remover livro", "Procurar livro"];

    private short ExibirMenu(List<string> opcoes)
    {
        short opcaoEscolhida;

        while (true)
        {
            Console.WriteLine("\nDigite o numero da sua opção");

            for (int i = 0; i < opcoes.Count; i++)
            {
                Console.WriteLine($"{i} - {opcoes[i]}");
            }

            Console.Write("Escolha uma opção: ");

            if (!short.TryParse(Console.ReadLine(), out opcaoEscolhida))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            if (opcaoEscolhida < 0 || opcaoEscolhida >= opcoes.Count)
            {
                Console.WriteLine("Opção fora do intervalo.");
                continue;
            }

            return opcaoEscolhida;
        }
    }

    public short MenuLeitor()
    {
        return ExibirMenu(opcoesLeitor);
    }
}