namespace Padroes;

public class Limao : CoquetelDecorator
{
  public Limao(Coquetel coquetel) : base(coquetel)
  {
    Nome = "Sapupara Limão";
    Preco = 14d;
  }
}