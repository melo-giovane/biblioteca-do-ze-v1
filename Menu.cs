public class Menu
{
    List<string> opcoes = ["Leitor", "Livros", "Encerrar programa"];
    List<string> opcoesLeitor = ["Adicionar", "Listar", "Editar", "Remover", "Doar"];
    List<string> opcoesLivro = ["Adicionar", "Listar", "Editar", "Remover"];
    List<string> dadosLeitor = ["Nome", "Idade", "Email", "Telefone"];



    public void ListarOpcoes()
    {
        short count = 0;
        foreach(string opcao in opcoes)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
    public void ListarOpcoesLeitor()
    {
        short count = 0;
        foreach(string opcao in opcoesLeitor)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
    public void ListarOpcoesLivro()
    {
        short count = 0;
        foreach(string opcao in opcoesLivro)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
}