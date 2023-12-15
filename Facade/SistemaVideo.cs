namespace Padroes;

public class SistemaVideo {

	public void ConfigurarResolucao() {
		Console.WriteLine("Resolução configurada");
	}

	public void ConfigurarCores() {
		Console.WriteLine("Esquema de cores configurado");
	}

	public void RenderizarImagem(string imagem) {
		Console.WriteLine("Imagem: " + imagem + " renderizada");
	}

}