namespace Padroes;

public class ServidorReal : IServidor
{
    public void Acessar()
    {
        Console.WriteLine("Acessando servidor real");
    }
}