using System.Collections.ObjectModel;

namespace Padroes;

public abstract class ElementoComposto : IElemento
{
    protected List<IElemento> elementos = new();
    
    public void Desenhar()
    {
        DesenharComposto();
        foreach(IElemento elemento in elementos)
        {
            elemento.Desenhar();
        }
    }

    public void Inserir(IElemento elemento)
    {
        elementos.Add(elemento);
    }

    public void Remover(IElemento elemento)
    {
        elementos.Remove(elemento);
    }

    public ReadOnlyCollection<IElemento> GetFilhos(){
        return elementos.AsReadOnly();
    }

    public abstract void DesenharComposto();
} 