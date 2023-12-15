namespace Padroes;

public class GolpeFlyweight 
{
    private static Dictionary<string, IGolpe> Golpes = new();

    static GolpeFlyweight ()
    {
        IniciarGolpes();
    }

    private static void IniciarGolpes()
    {
        Golpes.Add("soco", new Soco());
        Golpes.Add("chute", new Chute());
        Golpes.Add("voadora", new Voadora());
    }

    public static IGolpe GetGolpe(string nomeGolpe)
    {
        if (Golpes.ContainsKey(nomeGolpe))
        {
            return Golpes[nomeGolpe];
        }
        throw new Exception("Golpe não econtrado");
    }
}