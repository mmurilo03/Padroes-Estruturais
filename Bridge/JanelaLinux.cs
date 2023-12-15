namespace Padroes;

public class JanelaLinux : IJanela
{
    public void DesenharBotao(string titulo)
    {
        Console.WriteLine($"Botão: {titulo}");
    }

    public void DesenharJanela(string titulo)
    {
        Console.WriteLine("Não usem >linux< é MUITO ruim!!");
        Console.WriteLine($"Janela Lixox: {titulo}");
    }
}