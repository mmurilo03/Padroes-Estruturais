namespace Padroes;

public class JanelaAviso : JanelaBridge
{
    public JanelaAviso(IJanela janela) : base(janela)
    {
        
    }
    public override void Desenhar()
    {
        DesenharJanela("AAAAAAAAAVISO");
        DesenharBotao("Ok");
    }
}