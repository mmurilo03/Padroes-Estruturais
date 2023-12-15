namespace Padroes;

public class Laranja : CoquetelDecorator
{
  public Laranja(Coquetel coquetel) : base(coquetel)
  {
    Nome = "Dolly de laranja";
    Preco = 7d;
  }
}