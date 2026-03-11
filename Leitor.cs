namespace Biblioteca;
public class Leitor
{
public string Nome;
public byte Idade;
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
}