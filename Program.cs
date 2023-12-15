using Padroes;

Console.WriteLine("\n===============Flyweight===============");
List<IGolpe> combo = new()
{
    GolpeFlyweight.GetGolpe("soco"),
    GolpeFlyweight.GetGolpe("chute"),
    GolpeFlyweight.GetGolpe("voadora"),
    GolpeFlyweight.GetGolpe("chute"),
    GolpeFlyweight.GetGolpe("soco")
};
foreach(IGolpe golpe in combo)
{
    Console.WriteLine(golpe.Executar());
}

Console.WriteLine("===============Composite===============");
IElemento documento = new Documento();
IElemento pagina1 = new Pagina();
IElemento linha1 = new Linha();
documento.Inserir(pagina1);
pagina1.Inserir(linha1);
linha1.Inserir(new Caractere('F'));
linha1.Inserir(new Caractere('u'));
linha1.Inserir(new Caractere('l'));
linha1.Inserir(new Caractere('e'));
linha1.Inserir(new Caractere('c'));
linha1.Inserir(new Caractere('o'));
linha1.Inserir(new Caractere(' '));
linha1.Inserir(new Caractere('e'));
linha1.Inserir(new Caractere(' '));
linha1.Inserir(new Retangulo());

documento.Desenhar();

Console.WriteLine("===============Bridge===============");
IJanela linux = new JanelaLinux();
IJanela windows = new JanelaWindows();

JanelaBridge janelaBridge = new JanelaDialogo(linux);

janelaBridge.Desenhar();
janelaBridge = new JanelaAviso(linux);
janelaBridge.Desenhar();
Console.WriteLine();

janelaBridge = new JanelaDialogo(windows);
janelaBridge.Desenhar();
janelaBridge = new JanelaAviso(windows);
janelaBridge.Desenhar();

Console.WriteLine("===============Proxy===============");
IServidor servidor = new ServidorProxy();
servidor.Acessar();

Console.WriteLine("===============Decorator===============");

Coquetel coquetel = new Vodka();
coquetel = new Limao(coquetel);
coquetel = new Laranja(coquetel);

Console.WriteLine($"Coquetel com: {coquetel.Nome}");
Console.WriteLine($"Preço : R${coquetel.Preco}");

Console.WriteLine("===============Facade===============");
SistemasFacade sistemasFacade = new();

sistemasFacade.ReproduzirAudio("Música");
sistemasFacade.LerInput("A");
sistemasFacade.RenderizarImagem("Imagem renderizada");

Console.WriteLine("===============Adapter===============");
IAdapter adapter = new Adapter(new ObjetoAdaptado());
Console.WriteLine(adapter.Ativar());