namespace Padroes;

public abstract class CoquetelDecorator : Coquetel
{
    private string? nome = string.Empty;
    public override string? Nome
    {
        get { return $"{CoquetelDecorado.Nome} + {nome}"; }
        set => nome = value;
    }

    private double preco;
    public override double Preco 
    { 
        get { return CoquetelDecorado.Preco + preco;}
        set { preco = value;} 
    }
    public Coquetel CoquetelDecorado{get; set;}

    public CoquetelDecorator(Coquetel coquetelDecorado)
    {
        CoquetelDecorado = coquetelDecorado;
    }
}