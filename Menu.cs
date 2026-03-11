public class Menu
{
    List<string> opcoes = ["Leitor", "Livros", "Encerrar programa"];
    List<string> opcoesLeitor = ["Adicionar", "Listar", "Editar", "Remover", "Doar"];
    List<string> opcoesLivro = ["Adicionar", "Listar", "Editar", "Remover"];
    List<string> dadosLeitor = ["Nome", "Idade", "Email", "Telefone"];



    public void ListarOpções()
    {
        short count = 0;
        foreach(string opcao in opcoes)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
    public void ListarOpçõesLeitor()
    {
        short count = 0;
        foreach(string opcao in opcoesLeitor)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
    public void ListarOpçõesLivro()
    {
        short count = 0;
        foreach(string opcao in opcoesLivro)
        {
            Console.WriteLine($"{count+1} - {opcao};");
            count ++;
        }
    }
    
    public void CadastroLeitor()
    {
       foreach (string dado in dadosLeitor)
       {
        Console.Write($"Digite o {dado} do leitor: ");
        string resposta = Console.ReadLine();
       }
    }



}