namespace Padroes;

public class ServidorProxy : IServidor
{
    public ServidorReal? ServidorReal{get; set;}
    public void Acessar()
    {
        Console.WriteLine("Acessando Proxy e executando lógica do proxy");
        ServidorReal ??= new();

        ServidorReal.Acessar();
    }
}