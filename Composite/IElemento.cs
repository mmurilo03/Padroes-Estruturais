namespace Padroes;

public interface IElemento
{
    abstract void Desenhar();
    void Inserir(IElemento elemento);
    void Remover(IElemento elemento);
}