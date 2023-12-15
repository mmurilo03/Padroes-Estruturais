namespace Padroes;

public abstract class JanelaBridge
{
    public IJanela Janela {get; set;}

    public JanelaBridge(IJanela janela)
    {
        Janela = janela;
    }
    
    public void DesenharJanela(string titulo)
    {
        Janela.DesenharJanela(titulo);
    }

    public void DesenharBotao(string titulo)
    {
        Janela.DesenharBotao(titulo);
    }

    public abstract void Desenhar();
}