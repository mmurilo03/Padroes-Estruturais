namespace Padroes;

public class JanelaWindows : IJanela
{
    public void DesenharBotao(string titulo)
    {
        Console.WriteLine($"Botão: {titulo}");
    }

    public void DesenharJanela(string titulo)
    {
        Console.WriteLine("Windows é o melhor sistema do mundo! :D");
        Console.WriteLine($"Janela Windows: {titulo}");
    }
}