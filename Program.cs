using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Leitor> leitores = new List<Leitor>();

        Menu menu = new Menu();
        Console.WriteLine("Digite o numero da sua opção: ");
        menu.ListarOpções();
        short opcaoEscolhida;

        while (true)
        {
            Console.Write("Escolha uma opção: ");

            if (!short.TryParse(Console.ReadLine(), out opcaoEscolhida))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            switch (opcaoEscolhida)
            {
                case 1:
                    menu.ListarOpçõesLeitor();
                    return;

                case 2:
                    menu.ListarOpçõesLivro();
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }




    }
}