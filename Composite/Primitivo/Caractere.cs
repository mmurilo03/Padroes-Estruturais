namespace Padroes;

public class Caractere : ElementoSimples 
{
    private char Char {get; set;}

    public Caractere(char c)
    {
        Char = c;
    }

    public override void Desenhar()
    {
        Console.Write(Char);
    }
}