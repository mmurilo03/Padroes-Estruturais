namespace Padroes;

public class JanelaDialogo : JanelaBridge
{
    public JanelaDialogo(IJanela janela) : base(janela)
    {
        
    }
    public override void Desenhar()
    {
        DesenharJanela("Dialogo");
        DesenharBotao("Sim");
        DesenharBotao("Não");
        DesenharBotao("Talvez");
    }
}