namespace Padroes;

public abstract class ElementoSimples : IElemento
{
    public abstract void Desenhar();

    public void Inserir(IElemento elemento)
    {
        throw new NotImplementedException();
    }

    public void Remover(IElemento elemento)
    {
        throw new NotImplementedException();
    }
}