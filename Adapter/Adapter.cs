namespace Padroes;

public class Adapter : IAdapter
{
    ObjetoAdaptado Objeto {get; set;}
    public Adapter(ObjetoAdaptado objeto)
    {
        Objeto = objeto;
    }
    public string Ativar()
    {
        return Objeto.AtivarEspecifico();
    }
}